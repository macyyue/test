// 这是创建Web应用程序的起始点。它会创建一个WebApplicationBuilder对象，该对象用于配置和构建ASP.NET Core Web应用程序。
var builder = WebApplication.CreateBuilder(args);

// 将Razor页面服务添加到DI（Dependency Injection）容器中。Razor页面是用于构建Web页面的一种视图引擎，这里是将其添加到应用程序以供使用。
builder.Services.AddRazorPages();

// 这行代码用于构建应用程序。在这之后，你将能够配置HTTP请求处理管道并启动应用程序。
var app = builder.Build();

// 下面的代码块用于配置HTTP请求处理管道

// 这里检查应用程序是否处于开发环境。如果不是开发环境，接下来的中间件将生效。
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
