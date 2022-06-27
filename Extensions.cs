using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLanguageFeatures.Try
{    
    public static class FilterExtensions
    {
        public static IEnumerable<T> Filter<T> (this IEnumerable<T> input, FilterDelegate<T> predicate)
        {
            foreach(var item in input)
            {
                if (predicate(item))
                {
                    yield return item; 
                }
            }
        }
        public delegate bool FilterDelegate<T>(T item);
    }       
}
