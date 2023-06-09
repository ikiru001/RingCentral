namespace RingCentral
{
    public class CallMonitoringGroups
    {
        /// <summary>
        ///     Link to a call monitoring groups resource
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of call monitoring group members
        ///     Required
        /// </summary>
        public CallMonitoringGroup[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}