using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddSingleton<IBreakfastService, BreakfastService>(); //when implemented DB, change to AddScoped
    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

