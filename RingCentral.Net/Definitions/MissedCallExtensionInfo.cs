namespace RingCentral
{
    /// <summary>
    ///     Specifies an extension (a calling group) which should be used for the missed call transfer. Returned only if the
    ///     `actionType` is set to 'ConnectToExtension'
    /// </summary>
    public class MissedCallExtensionInfo
    {
        /// <summary>
        ///     Internal identifier of an extension which should be used for the missed call transfer
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public MissedCallExtensionInfoExternalNumber externalNumber { get; set; }
    }
}