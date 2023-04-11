
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
            var result = individualReviewer.ReviewAndScoreIdea(new Idea());
            result.Should().BeLessThan(20);          
        }

        [Fact]
        public void Add_the_result_of_ReviewAndScoreIdea_to_List_of_IdeaScores()
        {
            var pool = new IdeasPool(DateTime.Now, "low");
            pool.enteredIdeas.Should().HaveCount(1);
        }

        [Fact]

        public void Outputs_the_Heading_of_the_idea_to_be_entered()
        {
            var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");
            string titleTest = "Enter title name:";
            var result = freshPool.IdeaEntryQuiz();
            result.Should().Be(titleTest);
        }

        [Fact]
        public void Allows_user_input_of_the_idea_attributes()
        {
            var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");
            string titleTest = "Enter title name:";
            var result = freshPool.IdeaEntry(new Idea());
            result.Should().Be(titleTest);
        }

        [Fact]
        public void Checks_availability_of_a_category_based_on_user_input_and_adds_it_if_available()
        {
            var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");
            var result = freshPool.CheckAndAddIdeaCategory(new Idea());
            var userInput = "religion";
            Assert("Other");
            


        }
    }

}