using HotChocolate;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestesGraphQL.DataLoaders;
using TestesGraphQL.Interfaces;
using TestesGraphQL.QueryTypes;
using TestesGraphQL.Services;

namespace TestesGraphQL
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQL(sp => SchemaBuilder.New()
                .AddQueryType<Query>()
                .AddType<CustomerType>()
                .AddType<ItemType>()
                .AddServices(sp)
                .Create());

            services.AddDataLoader<ProductsByIdDataLoader>();
            services.AddTransient<IProfileRepository, ProfileRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UsePlayground();

            app.UseGraphQL();
        }
    }
}