using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ServiceCollectionExporter
{
    public static class ServiceCollectionExtensions
    {
        public static void ExportToJson(this IServiceCollection services, string filePath = "services.json")
        {
            var serviceInfos = services
                .Select(s => new
                {
                    ServiceType = s.ServiceType.FullName,
                    ImplementationType = s.ImplementationType?.FullName ?? "Factory/Instance",
                    Lifetime = s.Lifetime.ToString()
                })
                .ToList();

            string json = JsonSerializer.Serialize(serviceInfos, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filePath, json);
            Console.WriteLine($"Services exported to {Path.GetFullPath(filePath)}");
        }
    }
}
