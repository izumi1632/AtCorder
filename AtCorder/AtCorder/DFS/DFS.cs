using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCorder.DFS
{
    public class DFS
    {

        // 深さ優先探索
        List<bool> seen;
        void dfs(List<List<int>> G, int v)
        {
            seen[v] = true;
            foreach (var nextSeen in G[v])
            {
                if (seen[nextSeen])
                {
                    continue;
                }
                else
                {
                    // 再帰的に実行
                    dfs(G, nextSeen);
                }
            }
        }
        public DFS()
        {
            List<List<int>> Graph = new List<List<int>>();
            var NM = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            var ab = Enumerable.Range(0, NM[1]).Select(x => Console.ReadLine().Split().Select(y => int.Parse(y)).ToArray()).ToArray();
            foreach (var item in ab)
            {
                Graph[item[0]].Add(item[1]);
                Graph[item[1]].Add(item[0]);
            }

            seen = Enumerable.Range(0, NM[0]).Select(x => false).ToList();
            dfs(Graph, 0);
        }
    }
}
