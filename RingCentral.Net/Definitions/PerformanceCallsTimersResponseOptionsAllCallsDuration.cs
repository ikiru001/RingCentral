namespace RingCentral
{
    public class PerformanceCallsTimersResponseOptionsAllCallsDuration
    {
        /// <summary>
        ///     Enum: Sum, Average, Max, Min, Percent
        /// </summary>
        public string aggregationType { get; set; }

        /// <summary>
        ///     Enum: Hour, Day, Week, Month
        /// </summary>
        public string aggregationInterval { get; set; }
    }
}