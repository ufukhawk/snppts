using Snppts.Authors;
using Snppts.Extensions;
using Snppts.Infrastructure;
using System;
using System.Collections.Generic;

namespace Snppts.Snippets
{
    public class XamCall : IAmASnippet
    {
        public string Slug => "Dark-Store";
        public string Title => "DarkStore";
        public string Description => "Xamarin Forms Dark Store UI Design";
        public GitHubRepoInfo GitHubRepoInfo => new GitHubRepoInfo("ufukhawk/DarkStore");
        public Uri ExternalUri => null;
        public bool ContainsAndroidSample => true;
        public bool ContainsiOSSample => true;
        public bool ContainsUWPSample => false;
        public IAmAnAuthor AuthorInfo => new UfukHawk();

        public IEnumerable<Uri> ImageUris => new List<Uri>
        {
            new Uri("https://raw.githubusercontent.com/ufukhawk/Xamarin-Forms-UI-Library/master/Images/68747470733a2f2f696d6775722e636f6d2f575373506f63312e706e67.png"),
        };

        public IList<Category> Categories => new List<Category>
        {
            Category.PHOTOS,
            Category.DASHBOARD,
            Category.PROFILES,
            Category.NAVIGATIONS,
            Category.LISTS,
            Category.PHOTOS,
            Category.PRODUCTS,
        };
    }
}
