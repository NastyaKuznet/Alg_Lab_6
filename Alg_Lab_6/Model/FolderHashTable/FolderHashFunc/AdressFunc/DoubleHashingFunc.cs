using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.AdressFunc
{
    public class DoubleHashingFunc : IHashFuncAdress
    {
        public IHashFuncLink auxiliaryHashFunc1 = new DivisionFunc();
        public IHashFuncLink auxiliaryHashFunc2 = new DivisionFunc();
        public int Hash(int key, int size, int attempt)
        {
            return (auxiliaryHashFunc1.Hash(Math.Abs(key), size) + attempt * auxiliaryHashFunc2.Hash(Math.Abs(key), size - 1)) % size;
        }
    }
}
