using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Proj22.Entity;
using Proj22.Models.DataModels;

[assembly: HostingStartup(typeof(Proj22.Areas.Identity.IdentityHostingStartup))]
namespace Proj22.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AppDbContext>(op =>
                    op.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));


            });
        }
    }
}