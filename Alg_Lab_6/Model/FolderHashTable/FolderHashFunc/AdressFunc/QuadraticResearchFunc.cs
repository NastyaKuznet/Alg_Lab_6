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
        private int const1 = 7;
        public int Const1
        { 
            get { return const1; }
            set { 
                if(value > 0)
                    const1 = value; 
            }
        }

        private int const2 = 13;

        public int Const2
        {
            get { return const2; }
            set
            {
                if (value > 0)
                    const2 = value;
            }
        }
        public int Hash(int key, int size, int attempt)
        {
            return Math.Abs((auxiliaryHashFunc.Hash(key, size) + const1 * attempt + const2 * (int)Math.Pow(attempt, 2)) % size);
        }
    }
}
