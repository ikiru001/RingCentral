namespace RingCentral
{
    public class PerformanceCallsTimersResponseOptionsCallsDurationByResult
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