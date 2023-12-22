using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc
{
    public class QuadraticProbingHashFunc : IHashFuncLink
    {
        public int Hash(int key, int arraySize)
        {
            return (key + 3 * key * key + 7) % arraySize; // пример квадратичной функции хеширования
        }
    }
}
