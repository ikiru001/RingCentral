using Newtonsoft.Json;

namespace RingCentral.Net
{
    // Format of response in case that any error occured during request processing
    public class ErrorResponse : Serializable
    {
        // Collection of all gathered errors
        public Error[] errors;
    }
}