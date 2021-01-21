namespace RingCentral
{
    public class AutomaticLocationUpdatesTaskInfo
    {
        /// <summary>
        /// Internal identifier of a task
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Status of a task
        /// Enum: Accepted, InProgress, Completed, Failed
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Task creation time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// Time of the task latest modification
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        /// Type of a task
        /// Enum: WirelessPointsBulkCreate, WirelessPointsBulkUpdate, SwitchesBulkCreate, SwitchesBulkUpdate
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public TaskResultInfo result { get; set; }
    }
}