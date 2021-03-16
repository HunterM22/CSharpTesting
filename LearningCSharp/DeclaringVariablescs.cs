using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LearningCSharp
{
    public class DeclaringVariablescs
    {
        [Fact]
        public void SamplesOfExplicitLocalVariables()
        {
            int age = 2;
            decimal pay = 52.32M;

            string yourName = "Gambit";
            DateTime myBirthday = new DateTime(2019, 3, 22);

            Assert.Equal("Gambit", yourName);
            Assert.Equal(2, age);
        }
        [Fact]
        public void ImplicitlyTypedLocalVariables()
        {

            var age = 2;
            var pay = 52.32M;

            var yourName = "Gambit";
            var myBirthday = new DateTime(2019, 3, 22);

            DateTime yourBirthday = new();

        }

        [Fact]
        public void ObjectInitializers()
        {
            var myDinner = new Dinner()
            {
                MainCourse = "Tacos",
                Drinks = "Beer",
                Desert = "Another Beer"
            };
            //myDinner.MainCourse = "Tacos";
            //myDinner.Drinks = "Beer";
            //myDinner.HasSides = false;
            //myDinner.Desert = "Another Beer";

            Assert.Equal("For Dinner you will have Tacos With Another Beer",
                myDinner.GetPlan());
        }

    }
}
