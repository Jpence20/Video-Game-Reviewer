using System;
using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;
using System.Xml.Schema;

namespace Video_Game_Reviewer
{
    //These are the dictionarys for the custom Written Reviews and Games that get add to a list to paly
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