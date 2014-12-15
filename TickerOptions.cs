using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yahoo
{
    public enum TickerOptions
	{
        /// <summary>
        /// Ask
        /// </summary>
        [TickerCode("a")]
        [Description("Ask")]
        Ask,
        /// <summary>
        /// Average Daily Volume
        /// </summary>
        [TickerCode("a2")]
        [Description("Average Daily Volume")]
        Average_Daily_Volume,
        /// <summary>
        /// Ask Size
        /// </summary>
        [TickerCode("a5")]
        [Description("Ask Size")]
        Ask_Size,
        /// <summary>
        /// Bid
        /// </summary>
        [TickerCode("b")]
        [Description("Bid")]
        Bid,
        /// <summary>
        /// Ask (Real-time)
        /// </summary>
        [TickerCode("b2")]
        [Description("Ask (Real-time)")]
        Ask_Realtime,
        /// <summary>
        /// Bid (Real-time)
        /// </summary>
        [TickerCode("b3")]
        [Description("Bid (Real-time)")]
        Bid_Realtime,
        /// <summary>
        /// Book Value
        /// </summary>
        [TickerCode("b4")]
        [Description("Book Value")]
        Book_Value,
        /// <summary>
        /// Bid Size
        /// </summary>
        [TickerCode("b6")]
        [Description("Bid Size")]
        Bid_Size,
        /// <summary>
        /// Change & Percent Change
        /// </summary>
        [TickerCode("c")]
        [Description("Change & Percent Change")]
        Change_and_Percent_Change,
        /// <summary>
        /// Change
        /// </summary>
        [TickerCode("c1")]
        [Description("Change")]
        Change,
        /// <summary>
        /// Commission
        /// </summary>
        [TickerCode("c3")]
        [Description("Commission")]
        Commission,
        /// <summary>
        /// Change (Real-time)
        /// </summary>
        [TickerCode("c6")]
        [Description("Change (Real-time)")]
        Change_Realtime,
        /// <summary>
        /// After Hours Change (Real-time)
        /// </summary>
        [TickerCode("c8")]
        [Description("After Hours Change (Real-time)")]
        After_Hours_Change_Realtime,
        /// <summary>
        /// Dividend/Share
        /// </summary>
        [TickerCode("d")]
        [Description("Dividend/Share")]
        Dividend_Share,
        /// <summary>
        /// Last Trade Date
        /// </summary>
        [TickerCode("d1")]
        [Description("Last Trade Date")]
        Last_Trade_Date,
        /// <summary>
        /// Trade Date
        /// </summary>
        [TickerCode("d2")]
        [Description("Trade Date")]
        Trade_Date,
        /// <summary>
        /// Earnings/Share
        /// </summary>
        [TickerCode("e")]
        [Description("Earnings/Share")]
        Earnings_Share,
        /// <summary>
        /// Error Indication (returned for symbol changed / invalid)
        /// </summary>
        [TickerCode("e1")]
        [Description("Error Indication (returned for symbol changed / invalid)")]
        Error_Indication,
        /// <summary>
        /// EPS Estimate Current Year
        /// </summary>
        [TickerCode("e7")]
        [Description("EPS Estimate Current Year")]
        EPS_Estimate_Current_Year,
        /// <summary>
        /// EPS Estimate Next Year
        /// </summary>
        [TickerCode("e8")]
        [Description("EPS Estimate Next Year")]
        EPS_Estimate_Next_Year,
        /// <summary>
        /// EPS Estimate Next Quarter
        /// </summary>
        [TickerCode("e9")]
        [Description("EPS Estimate Next Quarter")]
        EPS_Estimate_Next_Quarter,
        /// <summary>
        /// Float Shares
        /// </summary>
        [TickerCode("f6")]
        [Description("Float Shares")]
        Float_Shares,
        /// <summary>
        /// Day's Low
        /// </summary>
        [TickerCode("g")]
        [Description("Day's Low")]
        Days_Low,
        /// <summary>
        /// Holdings Gain Percent
        /// </summary>
        [TickerCode("g1")]
        [Description("Holdings Gain Percent")]
        Holdings_Gain_Percent,
        /// <summary>
        /// Annualized Gain
        /// </summary>
        [TickerCode("g3")]
        [Description("Annualized Gain")]
        Annualized_Gain,
        /// <summary>
        /// Holdings Gain
        /// </summary>
        [TickerCode("g4")]
        [Description("Holdings Gain")]
        Holdings_Gain,
        /// <summary>
        /// Holdings Gain Percent (Real-time)
        /// </summary>
        [TickerCode("g5")]
        [Description("Holdings Gain Percent (Real-time)")]
        Holdings_Gain_Percent_Realtime,
        /// <summary>
        /// Holdings Gain (Real-time)
        /// </summary>
        [TickerCode("g6")]
        [Description("Holdings Gain (Real-time)")]
        Holdings_Gain_Realtime,
        /// <summary>
        /// Day's High
        /// </summary>
        [TickerCode("h")]
        [Description("Day's High")]
        Days_High,
        /// <summary>
        /// More Info
        /// </summary>
        [TickerCode("i")]
        [Description("More Info")]
        More_Info,
        /// <summary>
        /// Order Book (Real-time)
        /// </summary>
        [TickerCode("i5")]
        [Description("Order Book (Real-time)")]
        Order_Book_Realtime,
        /// <summary>
        /// 52-week Low
        /// </summary>
        [TickerCode("j")]
        [Description("52-week Low")]
        _52week_Low,
        /// <summary>
        /// Market Capitalization
        /// </summary>
        [TickerCode("j1")]
        [Description("Market Capitalization")]
        Market_Capitalization,
        /// <summary>
        /// Market Cap (Real-time)
        /// </summary>
        [TickerCode("j3")]
        [Description("Market Cap (Real-time)")]
        Market_Cap_Realtime,
        /// <summary>
        /// EBITDA
        /// </summary>
        [TickerCode("j4")]
        [Description("EBITDA")]
        EBITDA,
        /// <summary>
        /// Change From 52-week Low
        /// </summary>
        [TickerCode("j5")]
        [Description("Change From 52-week Low")]
        Change_From_52week_Low,
        /// <summary>
        /// Percent Change From 52-week Low
        /// </summary>
        [TickerCode("j6")]
        [Description("Percent Change From 52-week Low")]
        Percent_Change_From_52week_Low,
        /// <summary>
        /// 52-week High
        /// </summary>
        [TickerCode("k")]
        [Description("52-week High")]
        _52week_High,
        /// <summary>
        /// Last Trade (Real-time) With Time
        /// </summary>
        [TickerCode("k1")]
        [Description("Last Trade (Real-time) With Time")]
        Last_Trade_Realtime_With_Time,
        /// <summary>
        /// Change Percent (Real-time)
        /// </summary>
        [TickerCode("k2")]
        [Description("Change Percent (Real-time)")]
        Change_Percent_Realtime,
        /// <summary>
        /// Last Trade Size
        /// </summary>
        [TickerCode("k3")]
        [Description("Last Trade Size")]
        Last_Trade_Size,
        /// <summary>
        /// Change From 52-week High
        /// </summary>
        [TickerCode("k4")]
        [Description("Change From 52-week High")]
        Change_From_52week_High,
        /// <summary>
        /// Percebt Change From 52-week High
        /// </summary>
        [TickerCode("k5")]
        [Description("Percebt Change From 52-week High")]
        Percebt_Change_From_52week_High,
        /// <summary>
        /// Last Trade (With Time)
        /// </summary>
        [TickerCode("l")]
        [Description("Last Trade (With Time)")]
        Last_Trade_With_Time,
        /// <summary>
        /// Last Trade (Price Only)
        /// </summary>
        [TickerCode("l1")]
        [Description("Last Trade (Price Only)")]
        Last_Trade_Price_Only,
        /// <summary>
        /// High Limit
        /// </summary>
        [TickerCode("l2")]
        [Description("High Limit")]
        High_Limit,
        /// <summary>
        /// Low Limit
        /// </summary>
        [TickerCode("l3")]
        [Description("Low Limit")]
        Low_Limit,
        /// <summary>
        /// Day's Range
        /// </summary>
        [TickerCode("m")]
        [Description("Day's Range")]
        Days_Range,
        /// <summary>
        /// Day's Range (Real-time)
        /// </summary>
        [TickerCode("m2")]
        [Description("Day's Range (Real-time)")]
        Days_Range_Realtime,
        /// <summary>
        /// 50-day Moving Average
        /// </summary>
        [TickerCode("m3")]
        [Description("50-day Moving Average")]
        _50day_Moving_Average,
        /// <summary>
        /// 200-day Moving Average
        /// </summary>
        [TickerCode("m4")]
        [Description("200-day Moving Average")]
        _200day_Moving_Average,
        /// <summary>
        /// Change From 200-day Moving Average
        /// </summary>
        [TickerCode("m5")]
        [Description("Change From 200-day Moving Average")]
        Change_From_200day_Moving_Average,
        /// <summary>
        /// Percent Change From 200-day Moving Average
        /// </summary>
        [TickerCode("m6")]
        [Description("Percent Change From 200-day Moving Average")]
        Percent_Change_From_200day_Moving_Average,
        /// <summary>
        /// Change From 50-day Moving Average
        /// </summary>
        [TickerCode("m7")]
        [Description("Change From 50-day Moving Average")]
        Change_From_50day_Moving_Average,
        /// <summary>
        /// Percent Change From 50-day Moving Average
        /// </summary>
        [TickerCode("m8")]
        [Description("Percent Change From 50-day Moving Average")]
        Percent_Change_From_50day_Moving_Average,
        /// <summary>
        /// Name
        /// </summary>
        [TickerCode("n")]
        [Description("Name")]
        Name,
        /// <summary>
        /// Notes
        /// </summary>
        [TickerCode("n4")]
        [Description("Notes")]
        Notes,
        /// <summary>
        /// Open
        /// </summary>
        [TickerCode("o")]
        [Description("Open")]
        Open,
        /// <summary>
        /// Previous Close
        /// </summary>
        [TickerCode("p")]
        [Description("Previous Close")]
        Previous_Close,
        /// <summary>
        /// Price Paid
        /// </summary>
        [TickerCode("p1")]
        [Description("Price Paid")]
        Price_Paid,
        /// <summary>
        /// Change in Percent
        /// </summary>
        [TickerCode("p2")]
        [Description("Change in Percent")]
        Change_in_Percent,
        /// <summary>
        /// Price/Sales
        /// </summary>
        [TickerCode("p5")]
        [Description("Price/Sales")]
        Price_Sales,
        /// <summary>
        /// Price/Book
        /// </summary>
        [TickerCode("p6")]
        [Description("Price/Book")]
        Price_Book,
        /// <summary>
        /// Ex-Dividend Date
        /// </summary>
        [TickerCode("q")]
        [Description("Ex-Dividend Date")]
        ExDividend_Date,
        /// <summary>
        /// P/E Ratio
        /// </summary>
        [TickerCode("r")]
        [Description("P/E Ratio")]
        P_E_Ratio,
        /// <summary>
        /// Dividend Pay Date
        /// </summary>
        [TickerCode("r1")]
        [Description("Dividend Pay Date")]
        Dividend_Pay_Date,
        /// <summary>
        /// P/E Ratio (Real-time)
        /// </summary>
        [TickerCode("r2")]
        [Description("P/E Ratio (Real-time)")]
        P_E_Ratio_Realtime,
        /// <summary>
        /// PEG Ratio
        /// </summary>
        [TickerCode("r5")]
        [Description("PEG Ratio")]
        PEG_Ratio,
        /// <summary>
        /// Price/EPS Estimate Current Year
        /// </summary>
        [TickerCode("r6")]
        [Description("Price/EPS Estimate Current Year")]
        Price_EPS_Estimate_Current_Year,
        /// <summary>
        /// Price/EPS Estimate Next Year
        /// </summary>
        [TickerCode("r7")]
        [Description("Price/EPS Estimate Next Year")]
        Price_EPS_Estimate_Next_Year,
        /// <summary>
        /// Symbol
        /// </summary>
        [TickerCode("s")]
        [Description("Symbol")]
        Symbol,
        /// <summary>
        /// Shares Owned
        /// </summary>
        [TickerCode("s1")]
        [Description("Shares Owned")]
        Shares_Owned,
        /// <summary>
        /// Short Ratio
        /// </summary>
        [TickerCode("s7")]
        [Description("Short Ratio")]
        Short_Ratio,
        /// <summary>
        /// Last Trade Time
        /// </summary>
        [TickerCode("t1")]
        [Description("Last Trade Time")]
        Last_Trade_Time,
        /// <summary>
        /// Trade Links
        /// </summary>
        [TickerCode("t6")]
        [Description("Trade Links")]
        Trade_Links,
        /// <summary>
        /// Ticker Trend
        /// </summary>
        [TickerCode("t7")]
        [Description("Ticker Trend")]
        Ticker_Trend,
        /// <summary>
        /// 1 yr Target Price
        /// </summary>
        [TickerCode("t8")]
        [Description("1 yr Target Price")]
        _1_yr_Target_Price,
        /// <summary>
        /// Volume
        /// </summary>
        [TickerCode("v")]
        [Description("Volume")]
        Volume,
        /// <summary>
        /// Holdings Value
        /// </summary>
        [TickerCode("v1")]
        [Description("Holdings Value")]
        Holdings_Value,
        /// <summary>
        /// Holdings Value (Real-time)
        /// </summary>
        [TickerCode("v7")]
        [Description("Holdings Value (Real-time)")]
        Holdings_Value_Realtime,
        /// <summary>
        /// 52-week Range
        /// </summary>
        [TickerCode("w")]
        [Description("52-week Range")]
        _52week_Range,
        /// <summary>
        /// Day's Value Change
        /// </summary>
        [TickerCode("w1")]
        [Description("Day's Value Change")]
        Days_Value_Change,
        /// <summary>
        /// Day's Value Change (Real-time)
        /// </summary>
        [TickerCode("w4")]
        [Description("Day's Value Change (Real-time)")]
        Days_Value_Change_Realtime,
        /// <summary>
        /// Stock Exchange
        /// </summary>
        [TickerCode("x")]
        [Description("Stock Exchange")]
        Stock_Exchange,
        /// <summary>
        /// Dividend Yield
        /// </summary>
        [TickerCode("y")]
        [Description("Dividend Yield")]
        Dividend_Yield
    } 
}
