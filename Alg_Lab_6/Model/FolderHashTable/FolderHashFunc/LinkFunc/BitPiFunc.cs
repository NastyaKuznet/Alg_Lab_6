using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc
{
    public class BitPiFunc : IHashFuncLink
    {
        public double _const = 0.14;
        public int Hash(int key, int size)
        {
            return Math.Abs((key >>  SetSize(size)) % size + (int)(Math.PI * _const));
        }

        private int SetSize(int val)
        {
            int storage = 0;
            for (int i = 1; ; i++)
            {
                if (Math.Pow(2, i) > val)
                {
                    break;
                }
                storage = i;
            }
            return storage;
        }
    }
}
