using Microsoft.Extensions.Localization;
using PersonalWebSite.Blazor.Client.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebSite.Blazor.Client.Services
{
    public class LanguageService
    {
        private readonly IStringLocalizer<LanguageService> _l;

        public event EventHandler OnLanguageChanged;

        public LanguageService(IStringLocalizer<LanguageService> l)
        {
            _l = l;
        }

        public void Reload()
        {
            this.OnLanguageChanged?.Invoke(this, EventArgs.Empty);
        }
        public IEnumerable<Language> GetDefaults()
        {
            yield return new Language()
            {
                CultureInfo = new CultureInfo("en"),
                Icon = "uk.png",
                Linkedin_Localization = "en_US"
            };
            yield return new Language()
            {
                CultureInfo  = new CultureInfo("fr"),
                Icon = "france.png",
                Linkedin_Localization = "fr_FR"
            };
            
        }

        public Language GetCurrentLanguage()
        {
            var d = GetDefaults().FirstOrDefault(l => l.CultureInfo.TwoLetterISOLanguageName.Equals(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName, StringComparison.InvariantCultureIgnoreCase));
            return d ?? GetDefaults().First();
        }


        //public void SetLanguage(Language l)
        //{
        //    CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture(l.Localization);
        //}
    }
}
