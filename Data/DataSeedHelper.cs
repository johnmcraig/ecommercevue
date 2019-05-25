using System;
using System.Collections.Generic;

namespace ecommercevue.Data
{
    public class DataSeedHelper
    {
        private static Random _rand = new Random();
        private static string GetRandom(IList<string> items)
        {
            return items[_rand.Next(items.Count)];
        }

        internal static string MakeUniqueUserNames(List<string> names)
        {
            var maxNames = userFirstName.Count * userLastName.Count;

            if(names.Count == maxNames)
            {
                throw new InvalidOperationException("Max number of unique names exceeded");
            }

            var firstName = GetRandom(userFirstName);
            var lastName = GetRandom(userLastName);
            var fullName = firstName + " " + lastName;

            if(names.Contains(firstName) && names.Contains(lastName))
            {
                MakeUniqueUserNames(names);
            }

            return firstName + lastName;
        }

        internal static string MakeUserEmail(string fullName)
        {
            return $"contact@{fullName.ToLower().Replace(" ", "")}.com";
        }

        private static readonly List<string> userFirstName = new List<string>()
        {
            "JAMES", "JOHN", "ROBERT", "MICHAEL", "MARY", 
            "WILLIAM", "DAVID", "RICHARD", "CHARLES", "JOSEPH",
            "THOMAS", "PATRICIA", "CHRISTOPHER", "LINDA",
            "BARBARA", "DANIEL", "PAUL", "MARK", "ELIZABETH",
            "DONALD", "JENNIFER", "GEORGE", "MARIA", "KENNETH"
        };

        private static readonly List<string> userLastName = new List<string>()
        {
            "SMITH", "JOHNSON ", "WILLIAMS", "JONES", "BROWN",
            "DAVIS", "MILLER", "WILSON", "MOORE", "TAYLOR",
            "ANDERSON", "THOMAS", "JACKSON", "WHITE", "HARRIS",
            "MARTIN", "THOMPSON", "GARCIA", "MARTINEZ", "ROBINSON",
            "CLARK", "RODRIGUEZ", "LEWIS", "LEE", "WALKER"
        };   
    }
}