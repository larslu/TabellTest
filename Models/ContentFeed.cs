using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TabellTest.Models
{
    public class ContentFeed
    {
        public int Id { get; set; }

        [DisplayName("Feed Url")]
        public string FeedUrl { get; set; }
        public int LearningResourceId { get; set; }
        public LearningResource LearningResource { get; set; }
    }
}
