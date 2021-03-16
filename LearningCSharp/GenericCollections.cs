using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class GenericCollections
    {
        [Fact]
        public void FavoriteNumbersAgain()
        {
            var favoriteNumbersString = new List<string>();

            var favoriteNumbersInt = new List<int>();

            favoriteNumbersInt.Add(9);
            favoriteNumbersString.Add("Five");

        }

        [Fact]
        public void UsingADictionary()
        {
            var mealPlan = new Dictionary<string, Dinner>();

            mealPlan.Add("Tuesday", new Dinner()
            {
                MainCourse = "Pizza"
            });
            mealPlan.Add("Monday", new Dinner()
            {
                MainCourse = "Peanut Noddles with Tofu"

            });

            Assert.Equal("Pizza", mealPlan["Tuesday"].MainCourse);
        }

        [Fact]
        public void CollectionInitializers()
        {
            var favoriteNumbers = new List<int>()
            {
                9, 20, 108

            };
            Assert.Equal(20, favoriteNumbers[1]);

            int total = 0;
            foreach (int current in favoriteNumbers)
            {
                total += current;
            }
            
            Assert.Equal(137, total);

            var friends = new Dictionary<char, string>()
            {
                {'m', "Melissa Hunter" },
                {'j', "Jeff Gonzalez" }

            };

            Assert.Equal("Jeff", friends['j']);         
        }

       
    }
}
