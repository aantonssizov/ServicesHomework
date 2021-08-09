using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
using Services;

namespace ServicesHomework
{
    public static class Extensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAddContentService, AddContentService>();
            services.AddTransient<ICheckArticleService, CheckArticleService>();
            services.AddScoped<ISaveInfoService, SaveInfoService>();
            services.AddTransient<IUploadArticleService, UploadArticleService>();
            services.AddTransient<IPublishArticleService, PublishArticleService>();
        }
    }
}
