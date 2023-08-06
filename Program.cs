using Airport.Data;
using Airport.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.OpenApi.Models;
using Airport.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));



builder.Services.AddAuthentication().AddJwtBearer();

builder.Services.AddAuthorization();
//builder.Services.AddAuthentication().AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
//{
//    options.Authority = $"https://{builder.Configuration["Auth0:Domain"]}";


//    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
//    {
//        ValidAudience = builder.Configuration["Auth0:Audience"],
//        ValidIssuer = $"{builder.Configuration["Auth0:Domain"]}"
//    };

//    AppContext.SetSwitch("Microsoft.AspNetCore.Authentication.SuppressAutoDefaultScheme", true);
//});


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

//app.UseAuthentication();
app.UseHttpsRedirection();
app.UseRouting();
//app.UseAuthorization();
app.MapControllers();


app.Run();
