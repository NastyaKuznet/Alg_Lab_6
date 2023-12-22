using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc
{
    public class DivisionFunc : IHashFuncLink
    {
        public int Hash(int key, int size)
        {
            return Math.Abs(key % size);
        }
    }
}
