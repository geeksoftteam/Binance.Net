﻿using System;
using Binance.Net.Converters;
using Binance.Net.Enums;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Binance.Net.Objects.Spot.LendingData
{
    /// <summary>
    /// Redemption record
    /// </summary>
    public class BinanceRedemptionRecord
    {
        /// <summary>
        /// Amount purchased
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Asset name
        /// </summary>
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// Redeem type
        /// </summary>
        [JsonConverter(typeof(RedeemTypeConverter))]
        public RedeemType Type { get; set; }
        /// <summary>
        /// Name of the product
        /// </summary>
        public string ProductName { get; set; } = string.Empty;
        /// <summary>
        /// Principal
        /// </summary>
        public decimal Principal { get; set; }

        /// <summary>
        /// Purchase status
        /// </summary>
        public string Status { get; set; } = string.Empty;
    }
}
