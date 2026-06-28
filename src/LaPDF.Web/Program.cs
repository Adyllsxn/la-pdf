var builder = WebApplication.CreateBuilder(args);

// Configurar serviços
builder.Services.AddControllersWithViews();

// Configurar AppSettings
builder.Services.Configure<PdfSettings>(
    builder.Configuration.GetSection("PdfSettings"));
builder.Services.Configure<FileLimits>(
    builder.Configuration.GetSection("FileLimits"));

// Registrar serviços personalizados
builder.Services.AddScoped<IPdfService, PdfService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();