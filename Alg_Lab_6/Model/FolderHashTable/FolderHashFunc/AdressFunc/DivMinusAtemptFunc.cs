using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.AdressFunc
{
    public class DivMinusAtemptFunc : IHashFuncAdress
    {
        public IHashFuncLink auxiliaryHashFunc = new DivisionFunc();
        public int Hash(int key, int size, int attempt)
        {
            return (Math.Abs(auxiliaryHashFunc.Hash(key, size) / (int)(Math.Pow(attempt + 1, 2)) - attempt)) % size;
        }
    }
}
