using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TabellTest.Models
{
    public class TopicTag
    {
        public int Id { get; set; }

        [DisplayName("Tag")]
        public string TagValue { get; set; }

        public List<LearningResourceTopicTag> LearningResourceTopicTags { get; set; }
    }
}
