using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebSite.Front.Services
{
    public class NavigationService
    {
        public enum Page
        {
            Home,
            Resume,
            Account,

        }

        NavigationManager _navManager;
        public NavigationService(NavigationManager navManager)
        {
            this._navManager = navManager;
        }
    }
}
