using Microsoft.Extensions.Localization;
using PersonalWebSite.Front.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebSite.Front.Services
{
    public class LanguageService
    {
        IStringLocalizer<LanguageService> _l;

        public LanguageService(IStringLocalizer<LanguageService> l)
        {
            _l = l;
        }
        public IEnumerable<Language> GetDefaults()
        {
            yield return new Language()
            {
                Localization = "en",
                Name = _l["NameEn"],
                Icon = "uk.png",
                Linkedin_Localization = "en_US"
            };
            yield return new Language()
            {
                Localization = "fr",
                Name = _l["NameFr"],
                Icon = "france.png",
                Linkedin_Localization = "fr_FR"
            };
            
        }

        public Language GetCurrentLanguage()
        {
            var d = GetDefaults().FirstOrDefault(l => l.Localization.Equals(CultureInfo.CurrentUICulture.TwoLetterISOLanguageName, StringComparison.InvariantCultureIgnoreCase));
            return d ?? GetDefaults().First();
        }

        //public void SetLanguage(Language l)
        //{
        //    CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture(l.Localization);
        //}
    }
}
