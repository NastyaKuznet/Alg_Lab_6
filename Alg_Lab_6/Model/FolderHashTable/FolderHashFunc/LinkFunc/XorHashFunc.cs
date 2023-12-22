using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc
{
    public class XorHashFunc : IHashFuncLink
    {
        public int Hash(int key, int arraySize)
        {
            int hashedKey = key;
            hashedKey ^= (hashedKey << 13);
            hashedKey ^= (hashedKey >> 17);
            hashedKey ^= (hashedKey << 5);
            return Math.Abs(hashedKey) % arraySize;
        }
    }
}
