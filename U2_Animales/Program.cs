var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(); //Patron MVC MODELS VIEWS Y CONTROLLERS

var app = builder.Build();
app.MapDefaultControllerRoute();
app.UseStaticFiles();

app.Run();
