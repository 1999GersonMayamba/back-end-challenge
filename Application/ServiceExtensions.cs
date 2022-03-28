
using Application.Features.services;
using Application.Interfaces.Services;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<IAutorService, AutorService>();
            services.AddTransient<IGeneroService, GeneroService>();
            services.AddTransient<ILivroService, LivroService>();



        }
    }
}
