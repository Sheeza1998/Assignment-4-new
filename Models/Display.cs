using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4__new_.Models
{
    public class Display
    {
        private static List<Suggestions> suggestions_added_private = new List<Suggestions>();

        public static IEnumerable<Suggestions> suggestions_added_public => suggestions_added_private;

        public static void AddSuggestions(Suggestions Suggested)
        {
            suggestions_added_private.Add(Suggested);
        }
    }
}
