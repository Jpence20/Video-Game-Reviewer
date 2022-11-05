using System;
using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;
using System.Xml.Schema;

namespace Video_Game_Reviewer
{
   public class MyReviewsRepo
    {
        private static readonly Dictionary<string, WrittenReviews> dictionary = new();
        public static readonly Dictionary<string, WrittenReviews>? Wreview = dictionary;
    }

    public class MyGamesList
    {
        private static readonly Dictionary<string, GamesToPlay> dictionary = new();
        public static readonly Dictionary<string, GamesToPlay>? GamesList = dictionary;
    }
}