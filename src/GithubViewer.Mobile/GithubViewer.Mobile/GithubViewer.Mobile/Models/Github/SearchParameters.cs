using System;
using System.Collections.Generic;
using System.Text;

namespace GithubViewer.Core.Models.Github
{
    public class SearchParameters
    {
        public string Language { get; set; }
        public string SortBy { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
