namespace RingCentral
{
    public class AddPartyRequest
    {
        /// <summary>
        ///     Internal identifier of a call session
        ///     Required
        /// </summary>
        public string sessionId { get; set; }

        /// <summary>
        ///     Internal identifier of a party that should be added to the call session
        ///     Required
        /// </summary>
        public string partyId { get; set; }
    }
}