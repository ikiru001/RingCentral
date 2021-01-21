namespace RingCentral
{
    public class MobilePickupData
    {
        /// <summary>
        /// The list of extension IDs, configured to pick a call from Desktop/Mobile applications
        /// </summary>
        public string[] ccMailboxes { get; set; }

        /// <summary>
        /// SIP proxy registration name
        /// </summary>
        public string to { get; set; }

        /// <summary>
        /// User data
        /// </summary>
        public string sid { get; set; }

        /// <summary>
        /// User data
        /// </summary>
        public string srvlvl { get; set; }

        /// <summary>
        /// User data
        /// </summary>
        public string srvLvlExt { get; set; }
    }
}