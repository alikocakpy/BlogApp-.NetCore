﻿using Blog.Service.Sevices.Abstractions;
using Blog.Service.Sevices.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IArticleService,ArticleService>();
            return services;
        }
    }
}
