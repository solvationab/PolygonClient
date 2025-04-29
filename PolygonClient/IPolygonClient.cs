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

        [Get("/v3/reference/tickers")]
        Task<CollectionResponse<TickerListItemDto>> GetTickers(
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

        [Get("/v3/reference/tickers/types")]
        Task<CollectionResponse<TickerTypeDto>> GetTickerTypes(
            [AliasAs("asset_class")] AssetClassesDto? assetClass = null,
            [AliasAs("locale")] TickerLocalesDto? locale = null
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
