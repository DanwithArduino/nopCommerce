using Nop.Core.Domain.Orders;
using Nop.Services.Events;
using Nop.Services.Plugins;

namespace Nop.Plugin.Misc.SageIntegration;

public class SageIntegrationPlugin : BasePlugin
{
    public override async Task InstallAsync()
    {
        //Logic during installation goes here...

        await base.InstallAsync();
    }

    public override async Task UninstallAsync()
    {
        //Logic during uninstallation goes here...

        await base.UninstallAsync();
    }

    public class EventConsumer : IConsumer<OrderPlacedEvent>
    {
        public async Task HandleEventAsync(OrderPlacedEvent eventMessage)
        {
            if (eventMessage?.Order != null)
            {
                //do something
            }
        }
    }
}
