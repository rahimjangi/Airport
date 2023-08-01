using Airport.Data;
using Airport.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.OpenApi.Models;
using Airport.Security;
using Airport.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });

    // Add the security scheme for API key authentication
    c.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
    {
        Description = "API key needed for authentication",
        Type = SecuritySchemeType.ApiKey,
        Name = "X-Api-Key", // Change this to the actual header key you are expecting
        In = ParameterLocation.Header,
        Scheme="ApiKeyScheme"
    });

    var scheme = new OpenApiSecurityScheme
    {
        Reference = new OpenApiReference
        {
            Type = ReferenceType.Schema,
            Id = "ApiKey"
        },
        In = ParameterLocation.Header
    };

    var requirment = new OpenApiSecurityRequirement
    {
        {scheme, new List<string>() }
    };

    // Add the security requirement to apply the API key to all endpoints
    c.AddSecurityRequirement(requirment);
});

builder.Services.AddScoped<ApiKeyAuthFilter>();
builder.Services.AddAutoMapper(typeof(Program));

// Configure JWT authentication
var jwtSecretKey = "your-secret-key"; // Replace with a secure secret key
var tokenValidationParameters = new TokenValidationParameters
{
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidateIssuerSigningKey = true,
    ValidIssuer = "your-issuer",       // Replace with your API's issuer
    ValidAudience = "your-audience",   // Replace with your API's audience
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecretKey))
};


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = tokenValidationParameters;
});


builder.Services.AddDbContext<ApplicationDbContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection"));
    }
    );

builder.Services.AddScoped<IUnitOfWorkRepository, UnitOfWorkRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

//app.UseMiddleware<ApiKeyAuthMiddleware>();
app.UseAuthentication();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

//app.MapGet("", () =>
//{
//    return Enumerable.Range(1, 5).Select(index => new Airline
//    {
//    })
//}
//)


app.Run();
