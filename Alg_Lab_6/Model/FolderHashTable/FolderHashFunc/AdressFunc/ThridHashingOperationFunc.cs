﻿using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.AdressFunc
{
    public class ThridHashingOperationFunc : IHashFuncAdress
    {
        public IHashFuncLink auxiliaryHashFunc1 = new DivisionFunc();
        public IHashFuncLink auxiliaryHashFunc2 = new DivisionFunc();
        public IHashFuncLink auxiliaryHashFunc3 = new DivisionFunc();

        public int Hash(int key, int size, int attempt)
        {
            return (int)Math.Abs((auxiliaryHashFunc1.Hash(key, size) + attempt * auxiliaryHashFunc2.Hash(key, size) 
                - Math.Pow(attempt, 2) * auxiliaryHashFunc3.Hash(key, size)) % size);
        }
    }
}
