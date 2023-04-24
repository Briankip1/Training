using IdeasTracker;
using System.Data;
using System.Xml.Schema;
using FluentAssertions;
using System.ComponentModel.Design;

namespace IdeaTrackerTest
{

    public class UnitTest1
    {

        [Fact]
        public void Returns_the_average_of_score_of_an_idea_as_inputed_by_indvidual_reviewers()
        {
            var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");

            var freshIdea = new Idea();
            freshIdea.ideaScores = new List<IdeaScore>();
            var score = new IdeaScore();
            score.totalScore = 10;
            var score1 = new IdeaScore();
            score1.totalScore = 12;
            freshIdea.ideaScores.Add(score);
            freshIdea.ideaScores.Add(score1);

            var expectedOutput = (10 + 12) / freshIdea.ideaScores.Count;
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
            freshIdea.ideaScores = new List<IdeaScore>();
            var score = new IdeaScore();
            score.totalScore = 10;
            var score1 = new IdeaScore();
            score1.totalScore = 12;
            freshIdea.ideaScores.Add(score);
            freshIdea.ideaScores.Add(score1);

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
            freshIdea.cumulativeIdeaAverage = 15;

            freshPool.ClassifyIdea(freshIdea);

            freshPool.acceptedIdeas.Should().Contain(freshIdea);
        }

        [Fact]
        public void Check_whether_idea_with_average_score_below_12_in_the_rejected_category()
        {
            var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");
            var freshIdea = new Idea();
            freshIdea.cumulativeIdeaAverage = 10;
            freshPool.ClassifyIdea(freshIdea);
            freshPool.rejectedIdeas.Should().Contain(freshIdea);
        }
        [Fact]
        public void Accept_user_input_of_idea_initialization()
        {
            var testConsole = new TestConsole();
            var freshIdea = new Idea();
            var freshPool = new IdeasPool(DateTime.Now.AddDays(1), "high");
            freshPool.IdeaEntry(freshIdea, testConsole);
            freshIdea.title.Should().Be(string.Empty);
        }

        [Fact]
        public void Score_is_added_to_idea_list()
        {
            var score = new IdeaScore();
            var freshIdea = new Idea();
            freshIdea.ideaScores.Add(score);
            freshIdea.ideaScores.Should().Contain(score);
        }

        [Fact]
        public void Each_score_should_be_an_integer_of_one_to_five()
        {
            var freshIdea = new Idea();
            var testConsole = new TestConsole();
            var reviewer = new IndividualReviewer("brian","tech",false);
            var score = new IdeaScore();
            reviewer.ReviewAndScoreIdea(score, freshIdea, testConsole);
            score.timeScore = Convert.ToInt32(testConsole.ReadLine());

            score.timeScore.Should().BeOneOf(0,1,2,3,4,5);
        }

        [Fact]
        public void Check_whether_idea_is_assigned_to_two_reviewers()
        {
            var freshIdea = new Idea();
            var reviewers = new ReviewersGroup("tech", true, 5);
            var reviewer = new IndividualReviewer("brian", "tech", true);
            var reviewer1 = new IndividualReviewer("Mani", "product", false);
            IdeasPool pool = new IdeasPool(DateTime.Now, "high");
            List<IndividualReviewer>twoChosenReviewers = new List<IndividualReviewer> { reviewer, reviewer1 };
            //reviewers.assignedReviewers.Add(freshIdea, twoChosenReviewers);
            reviewers.AssignIdeasForReview(pool, reviewer);
            reviewers.assignedReviewers.Should().Contain(freshIdea,twoChosenReviewers);
        }

        [Fact]
        public void Confirm_That_Assigned_Ideas_Are_Not_In_Available_Ideas() 
        {
            var freshIdea = new Idea();
            var reviewers = new ReviewersGroup("tech", true, 5);
            var reviewer = new IndividualReviewer("brian", "tech",true);
            var reviewer1 = new IndividualReviewer("Mani", "product", false);
            reviewers.availableReviewers.Add(reviewer);
            reviewers.availableReviewers.Add(reviewer1);
            IdeasPool pool = new IdeasPool(DateTime.Now, "high");
            pool.enteredIdeas.Add(freshIdea);
            reviewers.AssignIdeasForReview(pool, reviewer);
            reviewer.assignedIdeas.Should().Contain(freshIdea);
            pool.enteredIdeas.Should().NotContain(freshIdea);
        }











    }

}

