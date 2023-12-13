using Alg_Lab_6.Model.FolderHashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model
{
    public class RandomItemHash
    {
        List<int> unicKey = new List<int>();
        Random random = new Random();
        public ItemHash<int>[] DoRandomRange(ItemHash<int>[] itemsHash, int from, int to)
        {
            int count = itemsHash.Length;

            for (int i = 0; i < count; i++)
            {
                int key = GetUnicKey(from, to);
                itemsHash[i] = new ItemHash<int>(key, random.Next(from, to));
            }
            return itemsHash;
        }

        private int GetUnicKey(int from, int to)
        {
            int randomKey = random.Next(from, to);
            while (true)
            {
                if (!unicKey.Contains(randomKey))
                {
                    unicKey.Add(randomKey);
                    return randomKey;
                }
                randomKey = random.Next(from, to);
            }
        }
}
}
