using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc
{
    public class PolynomialHashFunc : IHashFuncLink
    {
        public uint _const = 31;
        public int Hash(int key, int arraySize)
        {
            uint hash = 0;
            foreach (char c in key.ToString())
            {
                hash = _const * hash + c; 
            }
            
            return (int)Math.Abs(hash % arraySize);
        }
    }
}
