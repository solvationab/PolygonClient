using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PolygonClient.Dto;
using PolygonClient.Dto.Stocks;
using PolygonClient.Dto.Stocks.AggregateBars;
using PolygonClient.Dto.Stocks.AggregateBars.CustomBars;
using PolygonClient.Dto.Stocks.AggregateBars.DailyMarketSummary;
using PolygonClient.Dto.Stocks.AggregateBars.DailyTickerSummary;
using PolygonClient.Dto.Stocks.AggregateBars.PreviousDayBar;
using PolygonClient.Dto.Stocks.MarketOperations.Exchanges;
using PolygonClient.Dto.Stocks.MarketOperations.UpcomingMarketHolidays;
using PolygonClient.Dto.Stocks.TechnicalIndicators.SimpleMovingAverage;
using PolygonClient.Dto.Stocks.Tickers;
using PolygonClient.Dto.Stocks.Tickers.AllTickers;
using PolygonClient.Dto.Stocks.Tickers.RelatedTickers;
using PolygonClient.Dto.Stocks.Tickers.TickerDetail;
using PolygonClient.Dto.Stocks.Tickers.TickerTypes;
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
            [AliasAs("order")] OrderTypesDto? order = null,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("sort")] TickerSortTypesDto? sort = null
            );

        /// <summary>
        /// Retrieve comprehensive details for a single ticker supported by Polygon.io. This endpoint offers a deep look into a company’s fundamental attributes, including its primary exchange, standardized identifiers (CIK, composite FIGI, share class FIGI), market capitalization, industry classification, and key dates. Users also gain access to branding assets (e.g., logos, icons), enabling them to enrich applications and analyses with visually consistent, contextually relevant information.
        ///
        /// Use Cases: Company research, data integration, application enhancement, due diligence &amp; compliance.
        /// </summary>
        /// <param name="ticker"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        [Get("/v3/reference/tickers/{ticker}")]
        Task<Response<TickerDetailDto>> GetTickerDetail(
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
            [AliasAs("locale")] LocalesDto? locale = null
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

        /// <summary>
        /// Retrieve aggregated historical OHLC (Open, High, Low, Close) and volume data for a specified stock ticker over a custom date range and time interval in Eastern Time (ET). Aggregates are constructed exclusively from qualifying trades that meet specific conditions. If no eligible trades occur within a given timeframe, no aggregate bar is produced, resulting in an empty interval that indicates a lack of trading activity during that period. Users can tailor their data by adjusting the multiplier and timespan parameters (e.g., a 5-minute bar), covering pre-market, regular market, and after-hours sessions. This flexibility supports a broad range of analytical and visualization needs.
        ///
        /// Use Cases: Data visualization, technical analysis, backtesting strategies, market research.
        /// </summary>
        /// <param name="stocksTicker"></param>
        /// <param name="multiplier"></param>
        /// <param name="timespan"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="adjusted"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        [Get("/v2/aggs/ticker/{stocksTicker}/range/{multiplier}/{timespan}/{from}/{to}")]
        Task<AggregateBarsResponse<CustomBarDto>> GetCustomBars(
            [AliasAs("stocksTicker")] string stocksTicker,
            [AliasAs("multiplier")] int multiplier,
            [AliasAs("timespan")] TimespansDto timespan,
            [AliasAs("from")] DateTime from,
            [AliasAs("to")] DateTime to,
            [AliasAs("adjusted")] bool? adjusted = null,
            [AliasAs("sort")] OrderTypesDto? sort = null,
            [AliasAs("limit")] int? limit = null
            );

        /// <summary>
        /// Retrieve daily OHLC (open, high, low, close), volume, and volume-weighted average price (VWAP) data for all U.S. stocks on a specified trading date. This endpoint returns comprehensive market coverage in a single request, enabling wide-scale analysis, bulk data processing, and research into broad market performance.
        ///
        /// Use Cases: Market overview, bulk data processing, historical research, and portfolio comparison.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="adjusted"></param>
        /// <param name="includeOtc"></param>
        /// <returns></returns>
        [Get("/v2/aggs/grouped/locale/us/market/stocks/{date}")]
        Task<AggregateBarsResponse<DailyMarketSummaryDto>> GetDailyMarketSummary(
            [AliasAs("date")] DateTime date,
            [AliasAs("adjusted")] bool? adjusted = null,
            [AliasAs("include_otc")] bool? includeOtc = null
            );

        /// <summary>
        /// Retrieve the opening and closing prices for a specific stock ticker on a given date, along with any pre-market and after-hours trade prices. This endpoint provides essential daily pricing details, enabling users to evaluate performance, conduct historical analysis, and gain insights into trading activity outside regular market sessions.
        ///
        /// Use Cases: Daily performance analysis, historical data collection, after-hours insights, portfolio tracking.
        /// </summary>
        /// <param name="stocksTicker"></param>
        /// <param name="date"></param>
        /// <param name="adjusted"></param>
        /// <returns></returns>
        [Get("/v1/open-close/{stocksTicker}/{date}")]
        Task<DailyTickerSummaryResponse> GetDailyTickerSummary(
            [AliasAs("stocksTicker")] string stocksTicker,
            [AliasAs("date")] DateTime date,
            [AliasAs("adjusted")] bool? adjusted = null
            );

        /// <summary>
        /// Retrieve the previous trading day's open, high, low, and close (OHLC) data for a specified stock ticker. This endpoint provides key pricing metrics, including volume, to help users assess recent performance and inform trading strategies.
        ///
        /// Use Cases: Baseline comparison, technical analysis, market research, and daily reporting.
        /// </summary>
        /// <param name="stocksTicker"></param>
        /// <param name="adjusted"></param>
        /// <returns></returns>
        [Get("/v2/aggs/ticker/{stocksTicker}/prev")]
        Task<AggregateBarsResponse<PreviousDayBarDto>> GetPreviousDayBar(
            [AliasAs("stocksTicker")] string stocksTicker,
            [AliasAs("adjusted")] bool? adjusted = null
            );

        #endregion

        #region Snapshots
        #endregion

        #region Trades & Quotes
        #endregion

        #region Technical Indicators

        [Get("/v1/indicators/sma/{stockTicker}")]
        Task<SimpleMovingAverageResponse> GetSimpleMovingAverage(
            [AliasAs("stockTicker")] string stockTicker,
            [AliasAs("timestamp")] int? timestamp = null,
            [AliasAs("timespan")] TimespansDto? timespan = null,
            [AliasAs("adjusted")] bool? adjusted = null,
            [AliasAs("window")] int? window = null,
            [AliasAs("series_type")] SeriesTypesDto? seriesType = null,
            [AliasAs("expand_underlying")] bool? expandUnderlying = null,
            [AliasAs("order")] OrderTypesDto? order = null,
            [AliasAs("limit")] int? limit = null
            );
        #endregion

        #region Market Operations

        [Get("/v3/reference/exchanges")]
        Task<CollectionResponse<ExchangesDto>> GetExchanges(
            [AliasAs("asset_class")] AssetClassesDto? assetClass = null,
            [AliasAs("locale")] LocalesDto? locale = null
            );

        [Get("/v1/marketstatus/upcoming")]
        Task<IReadOnlyCollection<UpcomingMarketHolidayDto>> GetUpcomingMarketHolidays();

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
