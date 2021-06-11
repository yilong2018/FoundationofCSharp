using System;
using M07L12MVCMessageWall.Areas.Identity.Data;
using M07L12MVCMessageWall.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(M07L12MVCMessageWall.Areas.Identity.IdentityHostingStartup))]
namespace M07L12MVCMessageWall.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MVCMessageWallContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MVCMessageWallContextConnection")));

                services.AddDefaultIdentity<MVCMessageWallUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MVCMessageWallContext>();
            });
        }
    }
}