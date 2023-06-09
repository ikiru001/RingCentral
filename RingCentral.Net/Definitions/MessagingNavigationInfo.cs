namespace RingCentral
{
    /// <summary>
    ///     Information on navigation
    /// </summary>
    public class MessagingNavigationInfo
    {
        /// <summary>
        /// </summary>
        public MessagingNavigationInfoURI firstPage { get; set; }

        /// <summary>
        /// </summary>
        public MessagingNavigationInfoURI nextPage { get; set; }

        /// <summary>
        /// </summary>
        public MessagingNavigationInfoURI previousPage { get; set; }

        /// <summary>
        /// </summary>
        public MessagingNavigationInfoURI lastPage { get; set; }
    }
}