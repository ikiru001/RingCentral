namespace RingCentral
{
    /// <summary>
    ///     Schedule when an answering rule should be applied
    /// </summary>
    public class CompanyAnsweringRuleScheduleInfoRequest
    {
        /// <summary>
        /// </summary>
        public CompanyAnsweringRuleWeeklyScheduleInfoRequest weeklyRanges { get; set; }

        /// <summary>
        ///     Specific data ranges. If specified, weeklyRanges cannot be specified
        /// </summary>
        public RangesInfo[] ranges { get; set; }

        /// <summary>
        ///     Reference to Business Hours or After Hours schedule
        ///     Enum: BusinessHours, AfterHours
        /// </summary>
        public string @ref { get; set; }
    }
}