using IdeasTracker;
using System.Data;
using System.Xml.Schema;
using FluentAssertions;

namespace IdeaTrackerTest
{

    public class UnitTest1
    {
        //[Fact]
        //public void Input_from_the_reviewer_should_add_to_not_more_than_20()
        //{
        //   var individualReviewer = new IndividualReviewer("john", "engineering", true);
        //    var result = individualReviewer.ReviewAndScoreIdea(new Idea());
        //    result.Should().BeLessThan(20);          
        //}

        //[Fact]
        //public void Add_the_result_of_ReviewAndScoreIdea_to_List_of_IdeaScores()
        //{
        //    var pool = new IdeasPool(DateTime.Now, "low");
        //    pool.enteredIdeas.Should().HaveCount(1);
        //}


        //[Fact]
        //public void Allows_user_input_of_the_idea_attributes()
        //{
        //    var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");
        //    string titleTest = "Enter title name:";
        //    var result = freshPool.IdeaEntry(new Idea());
        //    result.Should().Be(titleTest);
        //}

        //[Fact]
        //public void Checks_availability_of_a_category_based_on_user_input_and_adds_it_if_available()
        //{
        //    var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");
        //    var result = freshPool.CheckAndAddIdeaCategory(new Idea());

        //}

        [Fact]
        public void Returns_the_average_of_score_of_an_idea_as_inputed_by_indvidual_reviewers()
        {
            var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");

            var freshIdea = new Idea();
            freshIdea.ideaScores = new List<int>() { 8, 12 };
            var expectedOutput = (freshIdea.ideaScores[0] + freshIdea.ideaScores[1]) / freshIdea.ideaScores.Count;
            var result = freshPool.AverageIdeaScore(freshIdea);
            if (expectedOutput == result)
            {
                Console.WriteLine("The function works correctly");
            }
            else
            {
                throw new Exception();
            }
        }

        [Fact]
        public void Testing_Whether_the_averageIdeaScore_return_same_value()
        {
            var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");

            var freshIdea = new Idea();
            freshIdea.ideaScores = new List<IdeaScore>() { 8, 12 };
            var scoreOne = freshPool.AverageIdeaScore(freshIdea);
            var scoreTwo = freshPool.AverageIdeaScore(freshIdea);
            if (freshIdea.ideaScores.Count == 0)
            {
                throw new ArgumentNullException();
            }
            Assert.Equal(scoreOne, scoreTwo);

        }


        [Fact]
        public void Categorize_Ideas_Based_on_the_scores_received()
        {
            var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");
            var freshIdea = new Idea();
            var result = freshPool.AverageIdeaScore(freshIdea);
            result = 13;
            freshPool.ClassifyIdea(freshIdea);

            freshPool.acceptedIdeas.Should().Contain(freshIdea);

            throw new ArgumentOutOfRangeException();
        }

        [Fact]
        public void Check_whether_idea_with_average_score_below_12_in_the_rejected_category()
        {
            var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");
            var freshIdea = new Idea();
            freshIdea.cumulativeIdeaAverage = 10;
            
            freshPool.rejectedIdeas.Should().Contain(freshIdea);
            
            throw new ArgumentOutOfRangeException();
        }








    }

}

