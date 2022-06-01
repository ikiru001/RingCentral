using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Xunit;

namespace RingCentral.Tests
{
    public class LowLevelApiTest
    {
        [Fact]
        public async void DifferentResponseTypes()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );

                // return a definition type
                var country = await rc.Get<CountryInfo>("/restapi/v1.0/dictionary/country/46");
                Assert.Equal("China", country.name);

                // return a string
                var str = await rc.Get<string>("/restapi/v1.0/dictionary/country/46");
                Assert.Contains("China", str);

                // return HttpResponseMessage
                var responseMessage = await rc.Get<HttpResponseMessage>("/restapi/v1.0/dictionary/country/46");
                Assert.Equal(HttpStatusCode.OK, responseMessage.StatusCode);

                // non-generic version
                var responseMessage2 = await rc.Get("/restapi/v1.0/dictionary/country/46");
                Assert.Equal(HttpStatusCode.OK, responseMessage2.StatusCode);
            }
        }

        [Fact]
        public async void GetExtensionInfo()
        {
            using (var rc = new RestClient(
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                       Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
                   ))
            {
                await rc.Authorize(
                    Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                    Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
                );
                // normal way to get extension info
                var extInfo = await rc.Restapi().Account().Extension().Get();
                Assert.NotNull(extInfo.id);

                // low level way to get extension info + headers info
                var httpResponseMessage = await rc.Get(rc.Restapi().Account().Extension().Path());
                var headers = httpResponseMessage.Headers;
                Assert.NotNull(headers);
                var responseBodyStr = await httpResponseMessage.Content.ReadAsStringAsync();
                Assert.NotNull(responseBodyStr);
                extInfo = JsonConvert.DeserializeObject<GetExtensionInfoResponse>(responseBodyStr);
                Assert.NotNull(extInfo.id);
            }
        }
    }
}