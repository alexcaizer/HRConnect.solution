using HRConnect.Server.AppDbContext;
using HRConnect.Server.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDipendenteRepository, DipendenteRepository>();
builder.Services.AddScoped<IBenefitRepository, BenefitRepository>();
builder.Services.AddScoped<ICandidatoRepository, CandidatoRepository>();
builder.Services.AddScoped<ICittaRepository, CittaRepository>();
builder.Services.AddScoped<IColloquioRepository, ColloquioRepository>();
builder.Services.AddScoped<IContrattoRepository, ContrattoRepository>();
builder.Services.AddScoped<IDocumentoRepository, DocumentoRepository>();
builder.Services.AddScoped<IEsperienzaLavorativaRepository, EsperienzaLavorativaRepository>();
builder.Services.AddScoped<IHardSkillRepository, HardSkillRepository>();
builder.Services.AddScoped<IHRRepository, HRRepository>();
builder.Services.AddScoped<ILivelloContrattualeRepository, LivelloContrattualeRepository>();
builder.Services.AddScoped<IMansioneRepository, MansioneRepository>();
builder.Services.AddScoped<ISedeRepository, SedeRepository>();
builder.Services.AddScoped<ISoftSkillRepository, SoftSkillRepository>();
builder.Services.AddScoped<ITitoloDiStudioRepository, TitoloDiStudioRepository>();






var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();

    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
