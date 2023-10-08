﻿using FinReportBuilder.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace FinReportBuilder;

public class Program
{
    public static void Main(string[] args)
    {
        // Syncfusion License
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjc0NzE5OEAzMjMzMmUzMDJlMzBXK2sybmZ0QkRnM0tyZnNSdzM2ZWprT09yWWJGNWVZbS9CbjgwUXl5RXlvPQ==");

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddSingleton<WordService>();
        builder.Services.AddSingleton<FinancialReportService>();

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
    }
}
