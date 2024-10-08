using ResumeAppApi.Infrustructre.Extentions;
using ResumeAppApi.Application.Extentions;
using ResumeAppApi.Domain.Entities;
using ServiceHost.Middelwares;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddInfrustructre(builder.Configuration);
builder.Services.AddApplication();


builder.Services.AddFileUploaderService(builder.Environment.WebRootPath);


var frontUrl = builder.Configuration.GetSection("FrontUrl").Value;

builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowFrontEndAppOrigin", builder =>
	builder.WithOrigins(frontUrl)
	.AllowAnyHeader()
	.AllowAnyMethod());
});

var app = builder.Build();

app.UseMiddleware<IdentityRouteMiddelware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowFrontEndAppOrigin");

app.UseAuthorization();

app.MapControllers();
app.MapGroup("api/Users").MapIdentityApi<User>();

app.UseStaticFiles();




await app.RunAsync();
