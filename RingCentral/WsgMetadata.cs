using System.Collections.Generic;

namespace RingCentral
{
    public class WsgMetadata
    {
        public string type;
        public string messageId;
        public string method;
        public string path;
        public Dictionary<string, string> headers;
    }
}
