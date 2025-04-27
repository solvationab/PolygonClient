using Refit;

namespace PolygonClient
{
    public interface IPolygonClient
    {
        #region Stocks

        #region Tickers
        [Get("")]
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
