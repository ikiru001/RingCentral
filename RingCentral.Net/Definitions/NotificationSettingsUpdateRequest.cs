namespace RingCentral
{
    public class NotificationSettingsUpdateRequest
    {
        /// <summary>
        ///     List of notification recipient email addresses
        /// </summary>
        public string[] emailAddresses { get; set; }

        /// <summary>
        ///     List of notification recipient email addresses
        /// </summary>
        public string[] smsEmailAddresses { get; set; }

        /// <summary>
        ///     Specifies notifications settings mode. If 'True' then advanced mode is on, it allows using different emails and/or phone numbers for each notification type. If 'False' then basic mode is on. Advanced mode settings are returned in both modes, if specified once, but if basic mode is switched on, they are not applied
        /// </summary>
        public bool? advancedMode { get; set; }

        /// <summary>
        /// </summary>
        public VoicemailsInfo voicemails { get; set; }

        /// <summary>
        /// </summary>
        public InboundFaxesInfo inboundFaxes { get; set; }

        /// <summary>
        /// </summary>
        public OutboundFaxesInfo outboundFaxes { get; set; }

        /// <summary>
        /// </summary>
        public InboundTextsInfo inboundTexts { get; set; }

        /// <summary>
        /// </summary>
        public MissedCallsInfo missedCalls { get; set; }
    }
}