using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewGitTaskProject.Models
{
    public class SimpleMath
    {
        public double? FirstNumber { get; set; }
        public double? SecondNumber { get; set; }

        public string GetResult()
        {
            string result = string.Empty;
            if (FirstNumber.HasValue && SecondNumber.HasValue)
            {
<<<<<<< HEAD
                result = (FirstNumber / SecondNumber).ToString();
=======
                result = (FirstNumber * SecondNumber).ToString();
>>>>>>> 8f494e9576f55d38702d3a542f00be84ad59d047
            }

            return result;
        }
    }
}