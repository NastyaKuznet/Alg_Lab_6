using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc
{
    public class SHA1Func : IHashFuncLink
    {
        public int Hash(int key, int size)
        {
            using(SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hash = sha1.ComputeHash(BitConverter.GetBytes(key));
                int result = BitConverter.ToInt32(hash, 0);
                return Math.Abs(result % size);
            }
        }
    }
}
