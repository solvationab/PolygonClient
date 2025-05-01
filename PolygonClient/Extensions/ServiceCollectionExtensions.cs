using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PolygonClient.Config;
using PolygonClient.DelegatingHandlers;
using Refit;
using System;
using System.Net.Http.Headers;
using System.Text.Json;
using PolygonClient.JsonConverters;

namespace PolygonClient.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// This extension method adds Polygon api to the service collection.
        /// 
        /// To work it need a PolygonConfig.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>
        /// <returns>The IServiceCollection to allow chaining</returns>
        public static IServiceCollection AddPolygonClient(this IServiceCollection services, PolygonConfig config)
        {
            // Add delegating handlers used by the Polygon Client
            services
                .AddScoped<HttpLoggingHandler>();

            // Add the Polygon API
            services
                .AddRefitClient<IPolygonClient>(sp =>
                {
                    var settings = new RefitSettings
                    {
                        ContentSerializer = new SystemTextJsonContentSerializer(GetJsonSerializerOptions()),
                        UrlParameterFormatter = new PolygonUrlParameterFormatter(new DefaultUrlParameterFormatter()),
                        //FormUrlEncodedParameterFormatter = new PolygonFormUrlEncodedParameterFormatter(new DefaultFormUrlEncodedParameterFormatter())
                    };

                    return settings;
                })
                .ConfigureHttpClient(httpClient =>
                {
                    httpClient.BaseAddress = new Uri(config.BaseUrl);

                    httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", config.ApiKey);
                })
                .AddHttpMessageHandler<HttpLoggingHandler>();

            return services;
        }

        public static T GetRequiredConfig<T>(this IConfiguration configuration, string key)
            where T : class
        {
            var config = configuration
                    .GetRequiredSection(key)
                    .Get<T>()
                ?? throw new InvalidOperationException("Unable to get " + typeof(T).Name + " from section " + key + " in config");

            return config;
        }

        public static JsonSerializerOptions GetJsonSerializerOptions()
        {
            return new JsonSerializerOptions
            {
                //NumberHandling = JsonNumberHandling.AllowReadingFromString,
                //DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Converters = { new JsonStringEnumConverterEx() }
            };
        }
    }
}
