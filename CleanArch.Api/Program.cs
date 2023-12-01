using CleanArch.Application.IServices;
using CleanArch.Application.Services;
using CleanArch.Infrastructure;
using log4net.Config;
using Microsoft.OpenApi.Models;
//using Microsoft.AspNet.OData.Extensions;
//using Microsoft.OData.Edm;

var builder = WebApplication.CreateBuilder(args);

//ODATA

// إضافة خدمات OData
/*builder.Services.AddControllers().AddOData(opt => opt.Select().Filter().Expand().OrderBy().SetMaxTop(null).Count());

// إعداد النقاط النهاية لـ OData
builder.Services.AddOData();

// إعداد الـ DbContext الخاص بك هنا
builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
*/
//ODATA


builder.Services.AddScoped<IContactService, ContactService>();

//Configure Log4net.
XmlConfigurator.Configure(new FileInfo("log4net.config"));

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
