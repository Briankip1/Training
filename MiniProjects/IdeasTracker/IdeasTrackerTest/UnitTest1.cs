using IdeasTracker;
using Xunit.Sdk;

namespace IdeasTrackerTest
{
    public class UnitTest1
    {
        [Fact]
        public void IdeaTest()
        {
            var newIdea = new Idea("time machine","reverse the past", "brian", DateTime.Now);

            IdeaPool enteredIdeas.Add(newIdea);




        }
    }
}