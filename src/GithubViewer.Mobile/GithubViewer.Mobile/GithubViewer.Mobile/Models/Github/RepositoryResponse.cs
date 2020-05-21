using System;
using System.Collections.Generic;
using System.Text;

namespace GithubViewer.Core.Models.Github
{
    public class RepositoryResponse
    {
        public int TotalCount { get; set; }
        public bool IncompleteResults { get; set; }
        public IList<Repository> Items { get; set; }
    }
}
