using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindDuplicateEmployee
{
    public static class Extension
    {
        public static IEnumerable<T> getAllRepeated<T>(this IEnumerable<T> extList, Func<T, object> groupProps) where T : class
        {
            //Get All the lines that has repeating
            return extList
                .GroupBy(groupProps)
                .Where(z => z.Count() > 1) 
                .Select(z => z.FirstOrDefault());
        }
    }
}
