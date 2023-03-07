using RestaurantMenu;
using Xunit.Sdk;

namespace ItemJoinsTest
{
    public class UnitTest1
    {
        [Fact]
        public void InnerJoinTest()
        {
            ItemJoins JoinedItems = new ItemJoins();

            var hamburger = new MenuItem("Hamburger", 205, 5.99f);
            var eggSalad = new MenuItem("Egg Salad", 189, 3.69f);
            var teriyaki = new MenuItem("Teriyaki Beef", 210, 6.78f);
            var prawn = new MenuItem("Whole Prawn Toast", 230, 6.90f);
            var chicken = new MenuItem("Salth and Pepper Chicken", 190, 5.80f);
            var mexicanRolls = new MenuItem("Mexican Rolls", 250, 4.80f);
            var omlettes = new MenuItem("Tex Mex Omlettes", 230, 2.98f);
            var frenchFries = new MenuItem("French Fries", 290, 3.80f);

            var left = new List<MenuItem> { hamburger, eggSalad, teriyaki, prawn, chicken, mexicanRolls, omlettes, frenchFries };



            var right = new List<MenuItem> { hamburger, eggSalad, teriyaki, prawn, chicken };

            var expectedOutput = new List<string>() { hamburger.name, eggSalad.name, teriyaki.name, prawn.name, chicken.name };
            
            var actualOutput = JoinedItems.InnerJoin(left, right);

            foreach(var item in expectedOutput)
            {
                Assert.True(actualOutput.Contains(item));
                  
            }

            foreach(var itemOne in actualOutput) 
            {
                Assert.True(expectedOutput.Contains(itemOne));
            }
        }

        [Fact]
        public void LeftJoinTests()
        {
            ItemJoins joinedLeft = new ItemJoins();

            var hamburger = new MenuItem("Hamburger", 205, 5.99f);
            var eggSalad = new MenuItem("Egg Salad", 189, 3.69f);
            var teriyaki = new MenuItem("Teriyaki Beef", 210, 6.78f);
            var prawn = new MenuItem("Whole Prawn Toast", 230, 6.90f);
            var chicken = new MenuItem("Salth and Pepper Chicken", 190, 5.80f);
            var mexicanRolls = new MenuItem("Mexican Rolls", 250, 4.54f);
            var omlettes = new MenuItem("Tex Mex Omlettes", 230, 3.36f);
            var frenchFries = new MenuItem("French Fries", 290, 3.80f);


            var right = new List<MenuItem> { hamburger, eggSalad, teriyaki, prawn, chicken, mexicanRolls, omlettes, frenchFries };
            var left = new List<MenuItem> { hamburger, eggSalad, teriyaki, prawn, chicken };



            var expectedOutput = new List<MenuItem> { hamburger, eggSalad, teriyaki, prawn, chicken, null, null, null };

            var actualOutput = joinedLeft.LeftJoin(left, right);

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void RightJoinTests()
        {
            ItemJoins joinedRight = new ItemJoins();

            var hamburger = new MenuItem("Hamburger", 205, 5.99f);
            var eggSalad = new MenuItem("Egg Salad", 189, 3.69f);
            var teriyaki = new MenuItem("Teriyaki Beef", 210, 6.78f);
            var prawn = new MenuItem("Whole Prawn Toast", 230, 6.90f);
            var chicken = new MenuItem("Salth and Pepper Chicken", 190, 5.80f);
            var mexicanRolls = new MenuItem("Mexican Rolls", 250, 4.54f);
            var omlettes = new MenuItem("Tex Mex Omlettes", 230, 3.36f);
            var frenchFries = new MenuItem("French Fries", 290, 3.80f);


            var left = new List<MenuItem> { hamburger, eggSalad, teriyaki, prawn, chicken, mexicanRolls, omlettes, frenchFries };
            var right = new List<MenuItem> { hamburger, eggSalad, teriyaki, prawn, chicken };



            var expectedOutput = new List<MenuItem> { hamburger, eggSalad, teriyaki, prawn, chicken, null, null, null };

            var actualOutput = joinedRight.RightJoin(left, right);

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void OuterJoinTests()
        {
            ItemJoins joinedOuter = new ItemJoins();

            var hamburger = new MenuItem("Hamburger", 205, 5.99f);
            var eggSalad = new MenuItem("Egg Salad", 189, 3.69f);
            var teriyaki = new MenuItem("Teriyaki Beef", 210, 6.78f);
            var prawn = new MenuItem("Whole Prawn Toast", 230, 6.90f);
            var chicken = new MenuItem("Salth and Pepper Chicken", 190, 5.80f);
            var mexicanRolls = new MenuItem("Mexican Rolls", 250, 4.54f);
            var omlettes = new MenuItem("Tex Mex Omlettes", 230, 3.36f);
            var frenchFries = new MenuItem("French Fries", 290, 3.80f);


            var left = new List<MenuItem> { hamburger, eggSalad, teriyaki, prawn, chicken };
            var right = new List<MenuItem> { mexicanRolls, omlettes, frenchFries };



            var expectedOutput = new List<MenuItem> { hamburger, eggSalad, teriyaki, prawn, chicken, mexicanRolls, omlettes, frenchFries };

            var actualOutput = joinedOuter.OuterJoin(left, right);

            Assert.Equal(expectedOutput, actualOutput);
        }


    }
}