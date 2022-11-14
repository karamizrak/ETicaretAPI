using ETicaret.Application.Validators.Products;
using ETicaret.Application.ViewModel.Products;
using ETicaret.Persistence;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(policyBuilder =>
        policyBuilder.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader()
            .AllowAnyMethod()));
builder.Services.AddControllers();
//1. way
//builder.Services.AddScoped<IValidator<VM_Create_Product>, CreateProductValidator>();

//2. way FluentValidation.DependencyInjectionExtensions
builder.Services.AddValidatorsFromAssemblyContaining<CreateProductValidator>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistenceServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();