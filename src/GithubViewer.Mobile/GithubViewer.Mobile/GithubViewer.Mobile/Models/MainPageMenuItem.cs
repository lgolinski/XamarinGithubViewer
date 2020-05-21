using System;

namespace GithubViewer.Core.Models
{
    public class MainPageMenuItem
    {
        public MainPageMenuItem()
        {
            TargetType = typeof(MainPageMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
