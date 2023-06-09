namespace RingCentral
{
    /// <summary>
    ///     Currency information
    /// </summary>
    public class CurrencyInfo
    {
        /// <summary>
        ///     Internal identifier of a currency
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Official code of a currency
        /// </summary>
        public string code { get; set; }

        /// <summary>
        ///     Official name of a currency
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Graphic symbol of a currency
        /// </summary>
        public string symbol { get; set; }

        /// <summary>
        ///     Minor graphic symbol of a currency
        /// </summary>
        public string minorSymbol { get; set; }
    }
}