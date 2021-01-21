namespace RingCentral
{
    public class DeleteMessageParameters
    {
        /// <summary>
        /// If the value is 'True', then the message is purged immediately with all the attachments
        /// </summary>
        public bool? purge { get; set; }

        /// <summary>
        /// Internal identifier of a message thread
        /// </summary>
        public long? conversationId { get; set; }
    }
}