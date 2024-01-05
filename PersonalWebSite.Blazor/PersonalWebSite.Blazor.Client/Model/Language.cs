using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebSite.Blazor.Client.Model
{
    public class Language
    {
        public CultureInfo CultureInfo { get; set; }

        public string Linkedin_Localization { get; set; }

        public string Icon { get; set; }
    }
}
