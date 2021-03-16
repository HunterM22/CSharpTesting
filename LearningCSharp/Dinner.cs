using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Dinner
    {
        public string MainCourse;
        public string Desert;
        public bool HasSides;
        public string Drinks;

        public string GetPlan()
        {
            return $"For Dinner you will have {MainCourse} With {Desert}";
        }

    }
}
