namespace RingCentral
{
    public class OptOutBulkAssignResponseOptIns
    {
        /// <summary>
        ///     Recipients' phone numbers which opt-ins were successfully added for.
        ///     Example: +15551237799
        /// </summary>
        public string[] successful { get; set; }

        /// <summary>
        ///     Recipients' phone numbers which opt-ins were failed to be added for. Plus, error messages
        ///     Example: [object Object]
        /// </summary>
        public OptOutBulkAssignFailedEntry[] failed { get; set; }
    }
}