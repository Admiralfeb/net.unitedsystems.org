using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UnitedSystemsCooperativeWebsite.Client;
using UnitedSystemsCooperativeWebsite.Client.Pages;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

AddHttpClients(builder);

builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAdB2C", options.ProviderOptions.Authentication);
    options.ProviderOptions.DefaultAccessTokenScopes.Add(
        "https://unitedsystemscooperative.onmicrosoft.com/aa9ec6f0-b9d9-43cb-a1a1-8cf39fa159ad/Api.Access");
});

await builder.Build().RunAsync();

static void AddHttpClients(WebAssemblyHostBuilder builder)
{
    builder.Services.AddHttpClient("Auth",
            client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
        .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

    builder.Services.AddHttpClient("NoAuth",
        client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

// Supply HttpClient instances that include access tokens when making requests to the server project
    builder.Services.AddScoped(sp =>
        sp.GetRequiredService<IHttpClientFactory>().CreateClient("Auth"));
}