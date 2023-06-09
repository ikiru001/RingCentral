using System;
using System.Threading.Tasks;
using RingCentral.Net.AutoRefresh;
using RingCentral.Net.WebSocket;
using Xunit;

namespace RingCentral.Tests
{
    public class WebSocketTest
    {
        [Fact]
        public async void SendAndReceive()
        {
            using var rc = new RestClient(
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_ID"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_CLIENT_SECRET"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_SERVER_URL")
            );
            await rc.Authorize(
                Environment.GetEnvironmentVariable("RINGCENTRAL_USERNAME"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_EXTENSION"),
                Environment.GetEnvironmentVariable("RINGCENTRAL_PASSWORD")
            );
            var webSocketExtension = new WebSocketExtension(new WebSocketOptions {debugMode = true});
            await rc.InstallExtension(webSocketExtension);
            var autoRefreshExtension = new AutoRefreshExtension();
            autoRefreshExtension.Start();
            await rc.InstallExtension(autoRefreshExtension);
            var eventFilters = new[] {"/restapi/v1.0/account/~/extension/~/message-store"};
            var count = 0;
            await webSocketExtension.Subscribe(eventFilters, message => { count += 1; });
            await rc.Restapi().Account().Extension().CompanyPager().Post(new CreateInternalTextMessageRequest
            {
                from = new PagerCallerInfoRequest {extensionNumber = "101"},
                to = new[] {new PagerCallerInfoRequest {extensionNumber = "101"}},
                text = "Hello world"
            });
            await Task.Delay(20000);
            Assert.True(count > 0);
        }
    }
}