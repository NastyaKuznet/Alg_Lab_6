using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc
{
    public class StartAndLenghtModFunc : IHashFuncLink
    {
        public int Hash(int key, int size)
        {
            int start = int.Parse(Math.Abs(key).ToString().Substring(0, 1));
            return (start + key.ToString().Length) % size;
        }
    }
}
