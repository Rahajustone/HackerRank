using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Easy
{
    class MigratoryBirdsSolution
    {
        public static int MigratoryBirds(List<int> arr)
        {
            var listArrayKey = arr.GroupBy(x => x).Select(a => new
            {
                a.Key,
                Count = a.Count()
            });

            var f = listArrayKey.Select(b => new
            {
                b.Key,
                b.Count
            }).Where(x => x.Count == listArrayKey.Max(_ => _.Count));

            var res = f.Where(_ => _.Key == f.Min(p => p.Key)).Select(x => x.Key);

            var result = 0;

            foreach (var v in res)
            {
                result = v;
            }

            return result;
        }
    }
}