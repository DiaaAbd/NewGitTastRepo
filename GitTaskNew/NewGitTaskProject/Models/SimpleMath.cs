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
                result = (FirstNumber * SecondNumber).ToString();
            }

            return result;
        }
    }
}