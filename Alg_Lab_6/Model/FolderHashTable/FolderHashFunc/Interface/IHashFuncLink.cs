using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface
{
    public interface IHashFuncLink
    {
        int Hash(int key, int size);
    }
}
