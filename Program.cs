var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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


app.Use(async (context,next) =>
{
	Console.WriteLine("before Use");
	await next();
	Console.WriteLine("after Use");
});
app.Use(async (context, next) =>
{
	Console.WriteLine("before2 Use2");
	await next.Invoke();
	Console.WriteLine("after2 Use2");
});
app.Run(async context =>
{
	Console.WriteLine("before start2");
	await context.Response.WriteAsync("Hello2.");
	Console.WriteLine("after start2");
});
app.Run();
