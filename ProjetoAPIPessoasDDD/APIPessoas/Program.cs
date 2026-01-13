using APIPessoasDDD.Application;
using APIPessoasDDD.Application.Interfaces;
using APIPessoasDDD.Application.Interfaces.Mapper;
using APIPessoasDDD.Data;
using APIPessoasDDD.Domain.Core.Interfaces.Servicos;
using APIPessoasDDD.Infraestructure.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;


namespace APIPessoasDDD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSwagger",
                    policy =>
                    {
                        policy
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            builder.Services.AddScoped<IApplicationServicoCliente, ApplicationServicoCliente>();
            builder.Services.AddScoped<IApplicationServicoContato, ApplicationServicoContato>();
            builder.Services.AddScoped<IApplicationServicoEndereco, ApplicationServicoEndereco>();
            builder.Services.AddScoped<IApplicationServicoTipoCliente, ApplicationServicoTipoCliente>();
            builder.Services.AddScoped<IApplicationServicoTipoContato, ApplicationServicoTipoContato>();
            builder.Services.AddScoped<IApplicationServicoTipoEndereco, ApplicationServicoTipoEndereco>();

            builder.Services.AddScoped<IServicoCliente, RepositoryCliente>();
            builder.Services.AddScoped<IServicoContato, RepositoryContato>();
            builder.Services.AddScoped<IServicoEndereco, RepositoryEndereco>();
            builder.Services.AddScoped<IServicoTipoCliente, RepositoryTipoCliente>();
            builder.Services.AddScoped<IServicoTipoContato, RepositoryTipoContato>();
            builder.Services.AddScoped<IServicoTipoEndereco, RepositoryTipoEndereco>();

            builder.Services.AddScoped<IMapperCliente, MapperCliente>();
            builder.Services.AddScoped<IMapperContato, MapperContato>();
            builder.Services.AddScoped<IMapperEndereco, MapperEndereco>();
            builder.Services.AddScoped<IMapperTipoCliente, MapperTipoCliente>();
            builder.Services.AddScoped<IMapperTipoContato, MapperTipoContato>();
            builder.Services.AddScoped<IMapperTipoEndereco, MapperTipoEndereco>();



            builder.Services.AddDbContext<PessoasDbContext>(options =>
            {
               options.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING"));
            });



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("AllowSwagger");

            app.MapControllers();

            app.Run();
        }
    }
}
