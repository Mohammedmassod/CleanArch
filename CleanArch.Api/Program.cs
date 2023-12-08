using CleanArch.Application.IServices;
using CleanArch.Application.Services;
using CleanArch.Infrastructure;
using log4net.Config;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.ModelBuilder;
using CleanArch.Domain.Entities;
using Microsoft.OData.Edm;

var builder = WebApplication.CreateBuilder(args);

/*var modelBuilder = new ODataConventionModelBuilder();
modelBuilder.EntitySet<Contact>("Contacts");*/
builder.Services.AddControllers()
.AddOData(options =>
    options.Select().Filter().Count().OrderBy().Expand().SetMaxTop(100)
    .AddRouteComponents("odata", GetEdmModel()));

builder.Services.AddDbContext<CleanArch.Infrastructure.Data.AppDbContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
    });
//Configure Log4net.
XmlConfigurator.Configure(new FileInfo("log4net.config"));
builder.Services.AddScoped<IContactService, ContactService>();
//Injecting services.
builder.Services.RegisterServices();

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
    {
        Description = "api key.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "basic"
                },
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });
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

app.MapControllers();

app.Run();
static IEdmModel GetEdmModel()
{
    ODataConventionModelBuilder modelBuilder = new ODataConventionModelBuilder();
    modelBuilder.EntitySet<Contact>("ContactOData");
    return modelBuilder.GetEdmModel();
}