using AntDesign.ProLayout;
using Configgo.Model;
using Configgo.Server.Apps.Extensions;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebApplication.CreateBuilder(args).Inject();


builder.Services.AddDatabaseContext()
                .AddAntDesign();
//builder.RootComponents.Add<App>("#app");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddAntDesign();
builder.Services.Configure<ProSettings>(builder.Configuration.GetSection("ProSettings"));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();

app.UseStaticFiles();

app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapControllers();
app.UseInject();
app.Run();
