using ChaneoDomicilio.Interface;   // Para usar la interfaz
using ChaneoDomicilio.Services;    // Aseg�rate de que el namespace es 'Services'

var builder = WebApplication.CreateBuilder(args);

// Agregar los servicios al contenedor
builder.Services.AddControllersWithViews();

// Registrar ServiceEmpleados como implementaci�n de EmpleadoInterface
builder.Services.AddScoped<EmpleadoInterface, ServiceEmpleados>();

var app = builder.Build();

// Configuraci�n del pipeline de HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
