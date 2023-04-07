
using System.Xml.Schema;
using FluentAssertions;
using IdeasTracker;

namespace ProjectTest
{
    public class UnitTest1
    {
        [Fact]
        public void Input_from_the_reviewer_should_add_to_not_more_than_20()
        {
           var individualReviewer = new IndividualReviewer("john", "engineering", true);
            var result = individualReviewer.ReviewAndScoreIdea();
            result.Should().Be(20);
            
        }

        [Fact]
        public void Add_the_result_of_ReviewAndScoreIdea_to_List_of_IdeaScores()
        {
            var individualReviewer = new IndividualReviewer("john", "engineering", true);
            individualReviewer.AddScore(new IdeasPool(DateTime.Now, "high"));


        }
    }

}