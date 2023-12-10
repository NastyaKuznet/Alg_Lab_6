using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.AdressFunc
{
    public class LinearResearchFunc : IHashFuncAdress
    {
        public IHashFuncLink auxiliaryHashFunc = new DivisionFunc();
        public int Hash(int key, int size, int attempt)
        {
            return (auxiliaryHashFunc.Hash(key, size) + attempt) % size;
        }
    }
}
