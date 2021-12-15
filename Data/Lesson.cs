using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnOn.Data
{
    public class Lesson
    {
        public ChapterEnum ChapterId { get; set; }
        public string ChapterName { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string VideoLink { get; set; }
        public string VideoLink_KA { get; set; }

        public enum ChapterEnum
        {
            
            
            //[Description("Arithmetic Progressions")]
            ArithProg,
            Probability,
            QuadEquation,
            Statistics,
            Trigonometry,
            Circles,
            CircleAreas

        }

        public static readonly Lesson[] Collection
       = new Lesson[]
       {
            // Start Statistics
           new Lesson //1
            {
               ChapterId = ChapterEnum.Statistics,
                ChapterName = "Statistics",
                Title="Statistics Lesson 1: Calculating the mean of grouped data",
                Description="This covers a part of the Karnataka SSLC Std X Maths textbook.  Here, we explain how the mean of grouped data is calculated.",
                VideoLink = "https://youtu.be/6iYcDYAgJuQ",
                VideoLink_KA = ""
             },
            new Lesson //2
            {
                ChapterId = ChapterEnum.Statistics,
                ChapterName = "Statistics",
                Title="Statistics Lesson 2: Calculating Means Using the Assumed Mean Method",
                Description="This video covers a part of the Statistics chapter of the Karnataka SSLC Std X Maths textbook.  We explain the Assumed Mean Method, a faster method for calculating the mean of grouped data.",
                VideoLink = "https://youtu.be/UI26H7S0n8g",
                VideoLink_KA = ""
            },
             new Lesson //3
            {
              ChapterId = ChapterEnum.Statistics,
              ChapterName = "Statistics",
              Title="Statistics Lesson 3: Calculating Mean using the Step Deviation Method",
              Description="This covers part of the Statistics chapter in the Karnataka SSLC Maths textbook.",
              VideoLink = "https://youtu.be/BuCi1TZA1-o",
              VideoLink_KA = ""
            },
            new Lesson //4
            {
              ChapterId = ChapterEnum.Statistics,
              ChapterName = "Statistics",
              Title="Statistics Lesson 4:  Calculating Mode for Grouped Data",
              Description="This covers part of the Statistics chapter in the Karnataka SSLC Maths textbook.",
              VideoLink = "https://youtu.be/2cbXZXowGi4",
              VideoLink_KA = ""
            },
             new Lesson //5
            {
               ChapterId = ChapterEnum.Statistics,
               ChapterName = "Statistics",
               Title="Statistics Lesson 5:  Medians and Grouped Data (Part 1)",
               Description="This covers a part of the Karnataka 10th Std Statistics chapter.  We explain how the median is calculated for grouped data.  Here, we talk about data in which repeated observations are grouped.  The next part will discuss medians for data grouped into classes.",
               VideoLink = "https://youtu.be/fasCPRuUx1s",
               VideoLink_KA = "https://youtu.be/kDyd6hZ7nS0"
             },
            new Lesson //6
            {
               ChapterId = ChapterEnum.Statistics,
               ChapterName = "Statistics",
               Title="Statistics Lesson 6: Median for Class Data (Part 2)",
               Description="This video covers part of the Statistics chapter of the Karnataka SSLC Std X Maths textbook.  WE explain how the median is computed for grouped data presented in class, or interval, form.",
               VideoLink = "https://youtu.be/HM30rgQyaPk",
               VideoLink_KA = ""
            },
            new Lesson //7
            {
               ChapterId = ChapterEnum.Statistics,
               ChapterName = "Statistics",
               Title="Statistics Lesson 7:  Graphical Representation using Ogives",
               Description="This video covers part of the Statistics chapetr of the Karnataka SSLC Std X Mathematics textbook.",
               VideoLink = "https://youtu.be/R38mwrKTTEI",
               VideoLink_KA = ""
            },
            //End Statistics
            //Start Arithmetic Progression
             new Lesson //1
            {
               ChapterId = ChapterEnum.ArithProg,
               ChapterName = "Arithmetic Progression",
               Title="Karnataka SSLC Arithmetic Progression Introduction",
               Description="Concepts of Arithmetic Progression Different type of Arithmetic Progression Example – Find Nth Value of Arithmetic Progression Example – Given the Nth Value, Find the Value of Nth in the sequence",
               VideoLink = "https://youtu.be/-woagBi_wNY",
               VideoLink_KA = "https://youtu.be/0xYI1za7H-k"
            },
             new Lesson //2
            {
               ChapterId = ChapterEnum.ArithProg,
               ChapterName = "Arithmetic Progression",
               Title="Arithmetic Progression - Calculate Sum",
               Description="Learning objective and Summary of the Presentation Approach of Arithmetic Progression – Calculate sum of N Terms Example – Calculate sum of N Terms Problem Solving – Arithmetic Progression",
               VideoLink = "https://youtu.be/j64hoAZq8Us",
               VideoLink_KA = "https://youtu.be/ZKgZqMkECOU"
            },
             //End Arithmetic Progression
             //Start Probability
            new Lesson //1
            {
               ChapterId = ChapterEnum.Probability,
               ChapterName = "Probability",
               Title="Probability Lesson 1 Lets talk about Probability V3",
               Description="Introduction to Probability",
               VideoLink = "https://youtu.be/y79dSPIJXfs",
               VideoLink_KA = ""
            },
            new Lesson //2
            {
               ChapterId = ChapterEnum.Probability,
               ChapterName = "Probability",
               Title="Probability Lesson 2 9th Std probability recap Part1",
               Description="Recap of what we studied in the 9th std Probability class",
               VideoLink = "https://youtu.be/HK_3FQ2yj70",
               VideoLink_KA = ""
            },
            new Lesson //3
            {
               ChapterId = ChapterEnum.Probability,
               ChapterName = "Probability",
               Title="Probability Lesson 2 9th Std Probability recap Part2",
               Description="Recap of what we studied in 9th Std Probability class",
               VideoLink = "https://youtu.be/v-KOvslSr5c",
               VideoLink_KA = ""
            },
             new Lesson //4
            {
               ChapterId = ChapterEnum.Probability,
               ChapterName = "Probability",
               Title="Probability Lesson3 Theoretical Probability",
               Description="We start with some definitions to gain grounding for the concept of theoretical probability, then recap what we learned about Empirical probability from the previous lesson, discuss some shortcomings of Empirical  Probability, then move on to  focus on Theoretical Probability that alleviates issues we discussed about Empirical probability.",
               VideoLink = "https://youtu.be/eepe730PbHE",
               VideoLink_KA = ""
            },
            //End Probability
            //Start Quadratic Equations
             new Lesson //1
            {
               ChapterId = ChapterEnum.QuadEquation,
               ChapterName = "Quadratic Equations",
               Title="Quadratic Equations Lesson1 Introduction to Quadratic Equations",
               Description="Basic introduction of quadratic equations. Starts with definition , then we go on to give some examples on how to represent some common life situations as quadratic equations and then proceed to take some example equations and determine whether they are quadratic or not.",
               VideoLink = "https://youtu.be/RurylNDTZUw",
               VideoLink_KA = ""
            },
             //End Quadratic Equations
             //Start Trigonometry
             new Lesson //1
            {
               ChapterId = ChapterEnum.Trigonometry,
               ChapterName = "Trigonometry",
               Title="Trigonometry Lesson1:  Why Trigonometry?",
               Description="This is an introductory lesson explaining what trigonometry is and why trigonometry is useful in real life.   It covers part of Chapter 11 in the Karnataka SSLC Std X Mathematics textbook.",
               VideoLink = "https://youtu.be/8PRpycNhMjw",
               VideoLink_KA = ""
            },
             //End Trigonometry
       };
    }
}
