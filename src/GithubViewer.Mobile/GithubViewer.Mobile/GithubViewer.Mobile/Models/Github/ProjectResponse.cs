using System;
using System.Collections.Generic;
using System.Text;

namespace GithubViewer.Core.Models.Github
{
    public class ProjectResponse
    {
        public int TotalCount { get; set; }
        public bool IncompleteResults { get; set; }
        public IEnumerable<Project> Items { get; set; }
    }
}
