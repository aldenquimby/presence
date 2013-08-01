using System.Collections.Generic;

namespace MvcApplication2.Models
{
    public class Site
    {
        public int Id { get; set; }
        public string BaseUrl { get; set; }
        public SiteType Type { get; set; }
        public string ProfileUrlFormat { get; set; }
        public IList<string> OtherProfileUrlFormats { get; set; } 

        public static IList<Site> KnownSites()
        {
            var sites = new List<Site>();

            sites.Add(new Site
            {
                Type = SiteType.Facebook,
                BaseUrl = "https://www.facebook.com/",
                ProfileUrlFormat = "https://www.facebook.com/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Twitter,
                BaseUrl = "https://twitter.com/",
                ProfileUrlFormat = "https://twitter.com/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Instagram,
                BaseUrl = "http://instagram.com/",
                ProfileUrlFormat = "http://instagram.com/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Foursquare,
                BaseUrl = "https://foursquare.com/",
                ProfileUrlFormat = "https://foursquare.com/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.LinkedIn,
                BaseUrl = "http://www.linkedin.com/",
                ProfileUrlFormat = "http://www.linkedin.com/in/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.GooglePlus,
                BaseUrl = "http://plus.google.com/",
                ProfileUrlFormat = "http://plus.google.com/{userid}",
                OtherProfileUrlFormats = new[] { "http://profiles.google.com/{username}", "http://gplus.to/{username}" }
            });

            sites.Add(new Site
            {
                Type = SiteType.Reddit,
                BaseUrl = "http://www.reddit.com/",
                ProfileUrlFormat = "http://www.reddit.com/user/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Pandora,
                BaseUrl = "http://www.pandora.com/",
                ProfileUrlFormat = "http://www.pandora.com/profile/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Grooveshark,
                BaseUrl = "http://grooveshark.com/",
                ProfileUrlFormat = "http://grooveshark/#!/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.StackOverflow,
                BaseUrl = "http://stackoverflow.com/",
                ProfileUrlFormat = "http://stackoverflow.com/users/{userid}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Gravatar,
                BaseUrl = "http://gravatar.com/",
                ProfileUrlFormat = "http://gravatar.com/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.AboutMe,
                BaseUrl = "http://about.me/",
                ProfileUrlFormat = "http://about.me/{username}",
            });
            
            sites.Add(new Site
            {
                Type = SiteType.FlavorsMe,
                BaseUrl = "http://flavors.me/",
                ProfileUrlFormat = "http://flavors.me/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Strikingly,
                BaseUrl = "http://www.strikingly.com/",
                ProfileUrlFormat = "http://www.strikingly.com/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Tumblr,
                BaseUrl = "http://www.tumblr.com/",
                ProfileUrlFormat = "http://{username}.tumblr.com",
            });

            sites.Add(new Site
            {
                Type = SiteType.WordPress,
                BaseUrl = "http://www.wordpress.com/",
                ProfileUrlFormat = "http://{username}.wordpress.com",
            });

            sites.Add(new Site
            {
                Type = SiteType.Quora,
                BaseUrl = "http://www.quora.com/",
                ProfileUrlFormat = "http://www.quora.com/{firstname}-{lastname}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Github,
                BaseUrl = "https://github.com/",
                ProfileUrlFormat = "https://github.com/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.HackerRank,
                BaseUrl = "https://www.hackerrank.com/",
                ProfileUrlFormat = "https://www.hackerrank.com/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Venmo,
                BaseUrl = "https://www.venmo.com/",
                ProfileUrlFormat = "https://www.venmo.com/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.HackerLeague,
                BaseUrl = "https://www.hackerleague.org/",
                ProfileUrlFormat = "https://www.hackerleague.org/users/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Nuget,
                BaseUrl = "https://www.nuget.org/",
                ProfileUrlFormat = "https://www.nuget.org/profiles/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Hunch,
                BaseUrl = "http://hunch.com/",
                ProfileUrlFormat = "http://hunch.com/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Meetup,
                BaseUrl = "http://www.meetup.com/",
                ProfileUrlFormat = "http://www.meetup.com/members/{userid}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Yelp,
                BaseUrl = "http://www.yelp.com/",
                ProfileUrlFormat = "http://{username}.yelp.com",
            });

            sites.Add(new Site
            {
                Type = SiteType.Coursera,
                BaseUrl = "https://www.coursera.org/",
                ProfileUrlFormat = "https://www.coursera.org/user/i/{userid}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Newsle,
                BaseUrl = "http://newsle.com/",
                ProfileUrlFormat = "http://newsle.com/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Skillshare,
                BaseUrl = "http://www.skillshare.com/",
                ProfileUrlFormat = "http://www.skillshare.com/profile/{firstname}-{lastname}/{userid}",
            });

            sites.Add(new Site
            {
                Type = SiteType.TurntableFm,
                BaseUrl = "https://turntable.fm/",
                ProfileUrlFormat = "https://turntable.fm/profile/{userid}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Spotify,
                BaseUrl = "https://www.spotify.com/",
                ProfileUrlFormat = "https://play.spotify.com/user/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.AngelList,
                BaseUrl = "https://angel.co/",
                ProfileUrlFormat = "https://angel.co/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Etsy,
                BaseUrl = "http://www.etsy.com/",
                ProfileUrlFormat = "http://www.etsy.com/people/{username}",
            });

            sites.Add(new Site
            {
                Type = SiteType.Pinterest,
                BaseUrl = "http://pinterest.com/",
                ProfileUrlFormat = "http://pinterest.com/{username}",
            });

            sites.ForEach(x => x.Id = (int)x.Type);

            return sites;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class UserSite
    {
        public User User { get; set; }
        public Site Site { get; set; }

        public string Username { get; set; }
        public string ProfileUrl { get; set; }
        public string UserId { get; set; }

        public string SuggestedProfileUrl()
        {
            return Site.ProfileUrlFormat
                       .Replace("{username}", User.Username)
                       .Replace("{firstname}", User.FirstName)
                       .Replace("{lastname}", User.LastName)
                       .Replace("{userid}", UserId ?? "{userid}");
        }
    }

    public enum SiteType
    {
        Other = 0,
        Facebook = 1,
        LinkedIn = 2,
        GooglePlus = 3,
        Foursquare = 4,
        Instagram = 5,
        Twitter = 6,
        Reddit = 7,
        Pandora = 8,
        Grooveshark = 9,
        StackOverflow = 10,
        Gravatar = 11,
        AboutMe = 12,
        FlavorsMe = 13,
        Strikingly = 14,
        Tumblr = 15,
        WordPress = 16,
        Quora = 17,
        Github = 18,
        HackerRank = 19,
        Venmo = 20,
        HackerLeague = 21,
        Nuget = 22,
        Hunch = 23,
        Meetup = 24,
        Yelp = 25,
        Coursera = 26,
        Newsle = 27,
        Skillshare = 28,
        TurntableFm = 29,
        Spotify = 30,
        AngelList = 31,
        Etsy = 32,
        Pinterest = 33,
    }
}