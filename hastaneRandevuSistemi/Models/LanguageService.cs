using hastaneRandevuSistemi.Models;
using Microsoft.Extensions.Localization;
using System.Reflection;

namespace hastaneRandevuSistemi.Models

{
    public class LanguageService

    {
        private readonly IStringLocalizer _localizer;

        public LanguageService(IStringLocalizerFactory factory)
        {
            var type = typeof(LanguageService);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create(nameof(ShareResource), assemblyName.Name);
        }
        public LocalizedString Getkey(string key)
        {
            return _localizer[key];
        }
    }
}
