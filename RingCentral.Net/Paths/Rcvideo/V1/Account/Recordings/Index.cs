using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Rcvideo.V1.Account.Recordings
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;
        public string recordingId;

        public Index(Account.Index parent, string recordingId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.recordingId = recordingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && recordingId != null) return $"{parent.Path()}/recordings/{recordingId}";
            return $"{parent.Path()}/recordings";
        }

        /// <summary>
        ///     Returns the list of meeting recordings belonging to all account users.
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v1/account/{accountId}/recordings
        ///     Rate Limit Group: Light
        ///     App Permission: Video
        /// </summary>
        public async Task<CloudRecordings> List(GetAccountRecordingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CloudRecordings>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns the information about particular recording.
        ///     HTTP Method: get
        ///     Endpoint: /rcvideo/v1/account/{accountId}/recordings/{recordingId}
        ///     Rate Limit Group: Light
        ///     App Permission: Video
        /// </summary>
        public async Task<CloudRecording> Get(RestRequestConfig restRequestConfig = null)
        {
            if (recordingId == null) throw new ArgumentException("Parameter cannot be null", nameof(recordingId));
            return await rc.Get<CloudRecording>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Rcvideo.V1.Account
{
    public partial class Index
    {
        public Recordings.Index Recordings(string recordingId = null)
        {
            return new Recordings.Index(this, recordingId);
        }
    }
}