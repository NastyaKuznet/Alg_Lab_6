using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable
{
    public class ItemHash<T>
    {
        public int key;
        public T value;
        public bool isRemove = false;

        public ItemHash(int key, T value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
