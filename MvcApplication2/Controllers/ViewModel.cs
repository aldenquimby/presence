using System;
using System.Collections.Generic;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class ViewModel
    {
        public User User { get; set; }
        public IList<UserSite> UserSites { get; set; }
        
        public string Pk(UserSite us)
        {
            return us.Site.Id > 0 ? us.Site.Id.ToString() : "";
        }

        public IList<string> SuggestedDomains
        {
            get
            {
                return new[]
                {
                    "http://" + User.Username + ".com",
                    "http://" + User.Username + ".me",
                };
            }
        } 
    }

    public class LinkModel
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public bool NewTab { get; set; }

        public LinkModel(string url, string name = null, bool newTab = true)
        {
            Url = url;
            Name = name ?? url;
            NewTab = newTab;
        }
    }
}