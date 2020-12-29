namespace RingCentral
{
    // Information about a call party that monitors a call
    public class SupervisePartyFrom
    {
        /// <summary>
        /// Phone number of a party
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Displayed name of a party
        /// </summary>
        public string name;

        /// <summary>
        /// Internal identifier of a device
        /// </summary>
        public string deviceId;

        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string extensionId;
    }
}