using Microsoft.OpenApi.Models;

namespace DynamoStudentManager.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Student Management - WebApi",
                    Description = "Student Management API."
                });
            });
        }
    }
}
