// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using ServiceCollectionExporter;
using Test;

var services = new ServiceCollection();

// 다양한 Lifetime 지정
services.AddTransient<IServiceA, ServiceA>();
services.AddScoped<IServiceB, ServiceB>();
services.AddSingleton<IServiceC, ServiceC>();
services.AddTransient<IServiceD, ServiceD>();
services.AddScoped<IServiceE, ServiceE>();
services.AddSingleton<IServiceF, ServiceF>();
services.AddTransient<IServiceG, ServiceG>();
services.AddScoped<IServiceH, ServiceH>();
services.AddSingleton<IServiceI, ServiceI>();
services.AddTransient<IServiceJ, ServiceJ>();

// JSON으로 내보내기
services.ExportToJson();