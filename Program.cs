using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Pedro_AP1_P1.DAL;
using Pedro_AP1_P1.BLL;
using Microsoft.EntityFrameworkCore;
using Radzen;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var ConStr = builder.Configuration.GetConnectionString("ConStr");

builder.Services.AddDbContext<Context>(op => op.UseSqlite(ConStr));
builder.Services.AddScoped<AportesBLL>();

builder.Services.AddScoped<NotificationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
