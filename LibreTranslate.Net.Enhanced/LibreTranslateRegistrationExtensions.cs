using System;
using System.Net.Http;
using LibreTranslate.Net.Enhanced.Constants;
using LibreTranslate.Net.Enhanced.Models;
using Microsoft.Extensions.DependencyInjection;

namespace LibreTranslate.Net.Enhanced
{
    public static class LibreTranslateRegistrationExtensions
    {
        private const string HttpClientKey = "LibreTranslate.Net.Enhanced";
        public static IServiceCollection AddLibreTranslate(this IServiceCollection services, Action<LibreTranslateConfiguration> configure = null)
        {
            var config = new LibreTranslateConfiguration
            {
                Url = LibraryConstants.DefaultUrl,
                ApiKey = LibraryConstants.DefaultApiKey
            };

            configure?.Invoke(config);

            if (!Uri.TryCreate(config.Url, UriKind.Absolute, out var uri))
                throw new ArgumentException($"Invalid URL: {config.Url}", nameof(configure));

            services.AddHttpClient(HttpClientKey, client => client.BaseAddress = uri);

            return services.AddTransient(sp =>
            {
                var clientFactory = sp.GetRequiredService<IHttpClientFactory>();
                var httpClient = clientFactory.CreateClient(HttpClientKey);

                return new LibreTranslate(httpClient, config.ApiKey);
            });
        }

        public static IServiceCollection AddLibreTranslate(this IServiceCollection services, string url, string apiKey = null)
        {
            return services.AddLibreTranslate(opt =>
            {
                opt.Url = url;
                if (apiKey != null) opt.ApiKey = apiKey;
            });
        }
    }
}