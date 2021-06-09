﻿using System;
using System.Collections.Generic;
using System.Text;
using POI.repository.Entities;
using POI.repository.IRepositories;
using POI.repository.Repositories;
using POI.service.Services;
using POI.service.IServices;
using Microsoft.Extensions.DependencyInjection;


namespace POI.service.DI
{
    public static class DependencyInjectionResolver
    {
        public static void InitializeDI(this IServiceCollection services)
        {
            // Register my app service. This includes CRUD function in user repository.
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();

            // Register my app service. This includes CRUD function in hashtag repository.
            services.AddTransient<IHashtagService, HashtagService>();
            services.AddTransient<IHashtagRepository, HashtagRepository>();

            // Register my app service. This includes CRUD function in province repository.
            services.AddTransient<IProvinceService, ProvinceService>();
            services.AddTransient<IProvinceRepository, ProvinceRepository>();

            // 
            services.AddTransient<IDestinationService, DestinationService>();
            services.AddTransient<IDestinationRepository, DestinationRepository>();

            // 
            services.AddTransient<IDesTypeService, DesTypeService>();
            services.AddTransient<IDesTypeRepository, DesTypeRepository>();

            // 
            services.AddTransient<IPoiTypeService, PoiTypeService>();
            services.AddTransient<IPoiTypeRepository, PoitypeRepository>();

            // 
            services.AddTransient<IPoiService, PoiService>();
            services.AddTransient<IPoiRepository, PoiRepository>();
        }
    }
}
