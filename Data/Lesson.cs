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
            //[Description("கடவுள் வாழ்த்து")]
            Statistics,
            ArithProg,
            Probability,
            QuadEquation
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
               VideoLink_KA = ""
            }

       };
    }
}
