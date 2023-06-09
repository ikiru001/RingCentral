namespace RingCentral
{
    public class PagingOnlyGroupDevices
    {
        /// <summary>
        ///     Link to a list of devices assigned to the paging only group
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of paging devices assigned to this group
        /// </summary>
        public PagingDeviceInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}