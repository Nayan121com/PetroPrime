using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.EntityFrameworkCore;
using PetroPrime.BAL.Services;
using PetroPrime.DAL.Data;
using PetroPrime.DAL.Repository;
using PetroPrime.DAL.Repository.InterfaceDefination;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Adding sql connection to the project
var pgSqlConnection = builder.Configuration.GetConnectionString("postgreSqlConnection");

//Adding serilog to the project
var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddControllers();

builder.Services.AddDbContext<PetroPrimeDbContext>(options => options.UseNpgsql(pgSqlConnection));
builder.Services.AddScoped<ICustomerRepository,CustomerRepository>();
builder.Services.AddScoped<ISupplierRepository,SupplierRepository>();
builder.Services.AddScoped<IProductRepository,ProductRepository>();
builder.Services.AddScoped<IOrderRepository,OrderRepository>();
builder.Services.AddScoped<IPaymentRepository,PaymentRepository>();
builder.Services.AddScoped<ICartRepository,CartRepository>();
builder.Services.AddScoped<ICourrierRepository,CourrierRepository>();
builder.Services.AddScoped<CustomerService, CustomerService>();
builder.Services.AddScoped<CartService,CartService>();
builder.Services.AddScoped<SupplierService, SupplierService>();
builder.Services.AddScoped<ProductService, ProductService>();
builder.Services.AddScoped<OrderService, OrderService>();
//builder.Services.AddScoped<PaymentService, PaymentService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
//   .AddNegotiate();

//builder.Services.AddAuthorization(options =>
//{
//    // By default, all incoming requests will be authorized according to the default policy.
//    options.FallbackPolicy = options.DefaultPolicy;
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
