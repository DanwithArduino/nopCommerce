using System.Diagnostics;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Orders;
using Nop.Core.Events;
using Nop.Core.Infrastructure;
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

public class EventConsumer2 : IConsumer<CustomerLoggedinEvent>
{
    public async Task HandleEventAsync(CustomerLoggedinEvent eventMessage)
    {
        if (eventMessage?.Customer != null)
        {
            Debug.WriteLine("im here");
            //do something
        }
    }
}

public class NopStartup : INopStartup
{
    public virtual void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        //register UPSService

    }

    /// <summary>
    /// Configure the using of added middleware
    /// </summary>
    /// <param name="application">Builder for configuring an application's request pipeline</param>
    public void Configure(IApplicationBuilder application)
    {
    }
    /// <summary>
    /// Gets order of this startup configuration implementation
    /// </summary>
    public int Order => 3000;
}
