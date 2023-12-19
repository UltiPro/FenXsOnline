using Microsoft.EntityFrameworkCore;
using Serilog;
using Database;
using Database.Configuration;
using Classes.Models.User;
using Microsoft.AspNetCore.Identity;
using Database.Contracts;
using Database.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Server.Middleware;
using System.Text.Json.Serialization;

const string configuration = "FenXsOnline";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString(configuration), b => b.MigrationsAssembly("Server"));
});

builder.Services.AddIdentityCore<DBUser>(model =>
{
    model.User.RequireUniqueEmail = true;
}).AddRoles<IdentityRole>()
  .AddTokenProvider<DataProtectorTokenProvider<DBUser>>(builder.Configuration["Settings:TokenProvider"])
  .AddEntityFrameworkStores<DatabaseContext>()
  .AddDefaultTokenProviders();

builder.Services.AddControllers().AddJsonOptions(option =>
{
    option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(configuration, policy =>
    {
        policy.WithOrigins("http://localhost:5500").AllowAnyMethod().AllowAnyHeader().AllowCredentials();
    });
});

builder.Host.UseSerilog((ctx, lc) =>
{
    lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration);
});

builder.Services.AddAutoMapper(typeof(MapperConfiguration));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IAuthMenager, AuthMenager>();
builder.Services.AddScoped<IAdminMenager, AdminMenager>();
builder.Services.AddScoped<IHeroMenager, HeroMenager>();
builder.Services.AddScoped<IMovementMenager, MovementMenager>();
builder.Services.AddScoped<IItemMenager, ItemMenager>();
builder.Services.AddScoped<IEquipmentMenager, EquipmentMenager>();
builder.Services.AddScoped<IMapMenager, MapMenager>();
builder.Services.AddScoped<INpcMenager, NpcMenager>();
builder.Services.AddScoped<IMobMenager, MobMenager>();
builder.Services.AddScoped<IFightMenager, FightMenager>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddCookie(cookie =>
{
    cookie.Cookie.Name = builder.Configuration["JwtSettings:TokenCookie"];
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero,
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
        ValidAudience = builder.Configuration["JwtSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Key"]))
    };
    options.Events = new JwtBearerEvents
    {
        OnMessageReceived = context =>
        {
            context.Token = context.Request.Cookies[builder.Configuration["JwtSettings:TokenCookie"]];
            return Task.CompletedTask;
        }
    };
});

builder.Services.AddResponseCaching(options =>
{
    options.MaximumBodySize = 8192;
    options.UseCaseSensitivePaths = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseCors(configuration);

app.UseResponseCaching();

app.Use(async (context, next) =>
{
    context.Response.GetTypedHeaders().CacheControl =
        new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
        {
            Public = true,
            MaxAge = TimeSpan.FromSeconds(1)
        };
    context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.Vary] =
        new string[] { "Accept-Encoding" };
    await next();
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
