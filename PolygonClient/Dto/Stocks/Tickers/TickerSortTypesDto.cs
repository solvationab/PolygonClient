using System.Runtime.Serialization;

namespace PolygonClient.Dto.Stocks.Tickers
{
    public enum TickerSortTypesDto
    {
        [EnumMember(Value = "ticker")]
        Ticker,

        [EnumMember(Value = "name")]
        Name,

        [EnumMember(Value = "market")]
        Market,

        [EnumMember(Value = "locale")]
        Locale,

        [EnumMember(Value = "primary_exchange")]
        PrimaryExchange,

        [EnumMember(Value = "type")]
        Type,

        [EnumMember(Value = "currency_symbol")]
        CurrencySumbol,

        [EnumMember(Value = "currency_name")]
        CurrencyName,

        [EnumMember(Value = "base_currency_symbol")]
        BaseCurrencySymbol,

        [EnumMember(Value = "base_currency_name")]
        BaseCurrencyName,

        [EnumMember(Value = "cik")]
        Cik,

        [EnumMember(Value = "composite_figi")]
        CompositeFigi,

        [EnumMember(Value = "share_class_figi")]
        ShareClassFigi,

        [EnumMember(Value = "last_updated_utc")]
        LastUpdatedUtc,

        [EnumMember(Value = "delisted_utc")]
        DelistedUtc,
    }
}