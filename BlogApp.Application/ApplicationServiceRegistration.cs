﻿using System.Reflection;
using BlogApp.Application.Services.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApp.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}