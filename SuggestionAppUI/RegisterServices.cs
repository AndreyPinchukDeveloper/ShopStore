namespace SuggestionAppUI;

public static class RegisterServices
{
   //extension method to attach to the wep application builder
   public static void ConfigureServices(this WebApplicationBuilder builder)
   {
      // Add services to the container.
      builder.Services.AddRazorPages();
      builder.Services.AddServerSideBlazor();
      builder.Services.AddMemoryCache();
   }
}
