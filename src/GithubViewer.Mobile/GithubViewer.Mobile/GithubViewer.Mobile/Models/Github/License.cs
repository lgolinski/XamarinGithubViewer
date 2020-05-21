using System;
using System.Collections.Generic;
using System.Text;

namespace GithubViewer.Core.Models.Github
{
    public class License
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string SpdxId { get; set; }
        public string Url { get; set; }
        public string NodeId { get; set; }
    }
}
