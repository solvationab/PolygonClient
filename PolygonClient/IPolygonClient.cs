using System;
using System.Threading.Tasks;
using PolygonClient.Dto;
using PolygonClient.Dto.Stocks.Tickers;
using Refit;

namespace PolygonClient
{
    public interface IPolygonClient
    {
        #region Stocks

        #region Tickers

        /// <summary>
        /// Retrieve a comprehensive list of ticker symbols supported by Polygon.io across various asset classes (e.g., stocks, indices, forex, crypto). Each ticker entry provides essential details such as symbol, name, market, currency, and active status.
        ///
        /// Use Cases: Asset discovery, data integration, filtering/selection, and application development.
        /// </summary>
        /// <param name="ticker"></param>
        /// <param name="type"></param>
        /// <param name="market"></param>
        /// <param name="exchange"></param>
        /// <param name="cusip"></param>
        /// <param name="cik"></param>
        /// <param name="date"></param>
        /// <param name="search"></param>
        /// <param name="active"></param>
        /// <param name="order"></param>
        /// <param name="limit"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        [Get("/v3/reference/tickers")]
        Task<CollectionResponse<TickerListItemDto>> GetAllTickers(
            [AliasAs("ticker")] string ticker = null,
            [AliasAs("type")] string type = null,
            [AliasAs("market")] MarketTypesDto? market = null,
            [AliasAs("exchange")] bool? exchange = null,
            [AliasAs("cusip")] string cusip = null,
            [AliasAs("cik")] string cik = null,
            [AliasAs("date")] DateTime? date = null,
            [AliasAs("search")] string search = null,
            [AliasAs("active")] bool? active = null,
            [AliasAs("order")] TickerOrderTypesDto? order = null,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("sort")] TickerSortTypesDto? sort = null
            );

        /// <summary>
        /// Retrieve comprehensive details for a single ticker supported by Polygon.io. This endpoint offers a deep look into a company’s fundamental attributes, including its primary exchange, standardized identifiers (CIK, composite FIGI, share class FIGI), market capitalization, industry classification, and key dates. Users also gain access to branding assets (e.g., logos, icons), enabling them to enrich applications and analyses with visually consistent, contextually relevant information.
        ///
        /// Use Cases: Company research, data integration, application enhancement, due diligence & compliance.
        /// </summary>
        /// <param name="ticker"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        [Get("/v3/reference/tickers/{ticker}")]
        Task<Response<TickerDetailDto>> GetTicker(
            [AliasAs("ticker")] string ticker,
            [AliasAs("date")] DateTime? date = null
            );

        /// <summary>
        /// Retrieve a list of all ticker types supported by Polygon.io. This endpoint categorizes tickers across asset classes, markets, and instruments, helping users understand the different classifications and their attributes.
        ///
        /// Use Cases: Data classification, filtering mechanisms, educational reference, system integration.
        /// </summary>
        /// <param name="assetClass"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        [Get("/v3/reference/tickers/types")]
        Task<CollectionResponse<TickerTypeDto>> GetTickerTypes(
            [AliasAs("asset_class")] AssetClassesDto? assetClass = null,
            [AliasAs("locale")] TickerLocalesDto? locale = null
            );

        /// <summary>
        /// Retrieve a list of tickers related to a specified ticker, identified through an analysis of news coverage and returns data. This endpoint helps users discover peers, competitors, or thematically similar companies, aiding in comparative analysis, portfolio diversification, and market research.
        ///
        /// Use Cases: Peer identification, comparative analysis, portfolio diversification, market research.
        /// </summary>
        /// <param name="ticker"></param>
        /// <returns></returns>
        [Get("/v1/related-companies/{ticker}")]
        Task<CollectionResponse<RelatedTickerDto>> GetRelatedTickers(
            [AliasAs("ticker")] string ticker
            );

        #endregion

        #region Aggregate Bars(OHLC)
        #endregion

        #region Snapshots
        #endregion

        #region Trades & Quotes
        #endregion

        #region Technical Indicators
        #endregion

        #region Market Operations
        #endregion

        #region Corporate Actions
        #endregion

        #region News
        #endregion

        #endregion

        #region Options

        #region Contracts
        #endregion

        #region Aggregate Bars(OHLC)
        #endregion

        #region Snapshots
        #endregion

        #region Trades & Quotes
        #endregion

        #region Technical Indicators
        #endregion

        #region Market Operations
        #endregion

        #endregion

        #region Indices

        #region Tickers
        #endregion

        #region Aggregate Bars(OHLC)
        #endregion

        #region Snapshots
        #endregion

        #region Technical Indicators
        #endregion

        #region Market Operations
        #endregion

        #endregion

        #region Forex

        #region Tickers
        #endregion

        #region Currency Conversion
        #endregion

        #region Aggregate Bars(OHLC)
        #endregion

        #region Snapshots
        #endregion

        #region Quotes
        #endregion

        #region Technical Indicators
        #endregion

        #region Market Operations
        #endregion

        #endregion

        #region Crypto

        #region Tickers
        #endregion

        #region Aggregate Bars(OHLC)
        #endregion

        #region Snapshots
        #endregion

        #region Trades
        #endregion

        #region Technical Indicators
        #endregion

        #region Market Operations
        #endregion

        #endregion

        #region Economy

        #region Treasury Yields
        #endregion

        #endregion
    }
}
