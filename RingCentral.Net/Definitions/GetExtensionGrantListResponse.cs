namespace RingCentral
{
    public class GetExtensionGrantListResponse
    {
        /// <summary>
        ///     Link to the list of extension grants
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of extension grants with details
        ///     Required
        /// </summary>
        public GrantInfo[] records { get; set; }

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