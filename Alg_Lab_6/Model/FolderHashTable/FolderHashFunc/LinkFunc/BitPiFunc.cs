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
        private int _size = 200;
        public int Size
        {
            get { return _size; }
            set { _size = SetSize(value); }
        }
        public int Count = 100;
        public int Hash(int key, int size)
        {
            return Math.Abs(key >> Size + (int)(Math.PI * 100));
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
