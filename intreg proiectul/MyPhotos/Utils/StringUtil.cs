using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyPhotos.Utils
{
    internal class StringUtil
    {
        public static string JoinValues<T>(ICollection<T> collection, Func<T, string> func)
        {
            return string.Join(",", collection.Select(func));
        }

        public static HashSet<T> Parse<T>(string data, Func<string, T> func) where T : class
        {
            if (data.Contains(','))
                return data.Split(',')
                    .Select(func)
                    .ToHashSet();
            return new HashSet<T>() {func(data)};
        }
    }
}