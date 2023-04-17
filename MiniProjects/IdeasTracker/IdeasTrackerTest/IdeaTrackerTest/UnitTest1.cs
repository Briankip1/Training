using IdeasTracker;
using System.Data;
using System.Xml.Schema;
using FluentAssertions;

namespace IdeaTrackerTest
{

    public class UnitTest1
    {

        [Fact]
        public void Returns_the_average_of_score_of_an_idea_as_inputed_by_indvidual_reviewers()
        {
            var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");

            var freshIdea = new Idea();
            freshIdea.ideaScores = new List<IdeaScore>() { 8, 12 };
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

