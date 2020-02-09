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

                result = (FirstNumber / SecondNumber).ToString();

>>>>>>> ed331a6a2335290a6e1002fd23f34e377e7861bd
            }

            return result;
        }
    }
}