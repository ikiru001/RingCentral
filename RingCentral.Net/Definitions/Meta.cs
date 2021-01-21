namespace RingCentral
{
    // resource metadata
    public class Meta
    {
        /// <summary>
        /// </summary>
        public string created { get; set; }

        /// <summary>
        /// </summary>
        public string lastModified { get; set; }

        /// <summary>
        /// resource location URI
        /// </summary>
        public string location { get; set; }

        /// <summary>
        /// Enum: User, Group
        /// </summary>
        public string resourceType { get; set; }
    }
}