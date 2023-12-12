using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc
{
    public class BitShifXorFunc : IHashFuncLink
    { 
        private int const1 = 131;
        public int Const1
        {
            get { return const1; }
            set { 
                if(value > 0)
                    const1 = value;
            }
        }

        private int const2 = 207;
        public int Const2
        {
            get { return const2; }
            set
            {
                if (value > 0)
                    const2 = value;
            }
        }

        private int const3 = 7;
        public int Const3
        {
            get { return const3; }
            set
            {
                if (value > 0)
                    const3 = value;
            }
        }

        public int Hash(int key, int size)
        {
            return Math.Abs((key ^ const1) >> (key ^ const2 * const3)) % size;
        }
    }
}
