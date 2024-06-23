using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedMutliclientVersions
{
    static class IEnumerableExtensions
    {
        public static string Join(this IEnumerable<string> enumerable, string seperator)
        {
            return string.Join(seperator, enumerable);
        }
    }
}
