namespace RingCentral
{
    public class GlipPersonInfo
    {
        /// <summary>
        /// Internal identifier of a user
        /// Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// First name of a user
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        /// Last name of a user
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        /// Email of a user
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Photo of a user
        /// </summary>
        public string avatar { get; set; }

        /// <summary>
        /// Internal identifier of a company
        /// </summary>
        public string companyId { get; set; }

        /// <summary>
        /// Time of creation in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// Time of the last modification in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        /// </summary>
        public string lastModifiedTime { get; set; }
    }
}