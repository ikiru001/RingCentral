namespace RingCentral
{
    public class UnifiedPresenceListEntry
    {
        /// <summary>
        ///     Internal identifier of the resource
        /// </summary>
        public string resourceId { get; set; }

        /// <summary>
        ///     Status code of resource retrieval
        ///     Format: int32
        /// </summary>
        public long? status { get; set; }

        /// <summary>
        /// </summary>
        public UnifiedPresence body { get; set; }
    }
}