using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.AdressFunc
{
    public class QuadraticResearchFunc : IHashFuncAdress
    {
        public IHashFuncLink auxiliaryHashFunc = new DivisionFunc();
        public int const1 = 7;
        public int const2 = 13;
        public int Hash(int key, int size, int attempt)
        {
            return (auxiliaryHashFunc.Hash(key, size) + const1 * attempt + const2 * (int)Math.Pow(attempt, 2)) % size;
        }
    }
}
