using MyTestApi.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

ApplicationConfiguration.Configure(builder.Services);

// c_Data_Batch() 
// builder.Services.AddScopped<ICDataBatch, C_Data_Batck>()

var app = builder.Build();

// Configure the HTTP request pipeline. don't use swagger
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/

// Add middleware for Authorization 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
