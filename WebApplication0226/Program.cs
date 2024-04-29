var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson();
builder.Services.AddSingleton<LineBotConfig, LineBotConfig>((s)=> new LineBotConfig
{
    channelSecret = builder.Configuration.GetSection("LineBot")["channelSecret"]!,
    accessToken = builder.Configuration.GetSection("LineBot")["accessToken"]!,
});

builder.Services.AddSingleton<ILineService, LineService>();
builder.Services.AddHttpContextAccessor();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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