using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabellTest.Models
{
    public class LearningResourceTopicTag
    {
        public int Id { get; set; }
        public LearningResource LearningResource { get; set; }
        public int TopicTagId { get; set; }
        public TopicTag TopicTag { get; set; }

    }
}
