// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.Http;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;
// using RecipeApi.Data;


// namespace RecipeApi
// {
//     public class Startup
//     {
//         public Startup(IConfiguration configuration)
//         {
//             Configuration = configuration;
//         }

//         public IConfiguration Configuration { get; }

//         // This method gets called by the runtime. Use this method to add services to the container.
//         public void ConfigureServices(IServiceCollection services)
//         {
//             services.AddControllers();
//             services.AddDbContext<RecipeDbContext>(options =>
//                 options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//             services.AddCors(options =>
//             {
//                 options.AddPolicy("AllowAll",
//                     builder =>
//                     {
//                         builder.AllowAnyOrigin()
//                             .AllowAnyMethod()
//                             .AllowAnyHeader();
//                     });
//             });
//         }

//         // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//         {
//             if (env.IsDevelopment())
//             {
//                 app.UseDeveloperExceptionPage();
//             }

//             app.UseHttpsRedirection();

//             app.UseRouting();

//             app.UseCors("AllowAll");

//             app.UseAuthorization();

//             app.UseEndpoints(endpoints =>
//             {
//                 endpoints.MapControllers();
//             });
//         }
//     }
// }
