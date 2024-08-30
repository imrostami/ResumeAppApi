using ResumeAppApi.Infrustructre.Extentions;
using ResumeAppApi.Application.Extentions;
using ResumeAppApi.Domain.Entities;



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
app.MapGroup("api/Users").MapIdentityApi<User>();

app.UseStaticFiles();


await app.RunAsync();
