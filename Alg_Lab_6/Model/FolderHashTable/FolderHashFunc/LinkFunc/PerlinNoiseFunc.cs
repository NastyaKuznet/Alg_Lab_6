using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc
{
    public class PerlinNoiseFunc : IHashFuncLink
    {
        public int const1 = 15731;
        public int const2 = 789221;
        public int const3 = 1376312589;
        public int Hash(int key, int arraySize)
        {
            int hash = key;
            hash = (hash << 13) ^ hash;
            return Math.Abs((hash * (hash * hash * const1 + const2) + const3) % arraySize);
        }
    }
}
