namespace RingCentral
{
    public class TMCreateNoteRequest
    {
        /// <summary>
        ///     Title of a note. Max allowed length is 250 characters
        ///     Required
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     Contents of a note; HTML markup text. Max allowed length is 1048576 characters (1 Mb).
        /// </summary>
        public string body { get; set; }
    }
}