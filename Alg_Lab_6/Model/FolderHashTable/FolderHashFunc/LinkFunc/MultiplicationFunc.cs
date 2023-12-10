using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;

namespace Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc
{
    public class MultiplicationFunc : IHashFuncLink
    {
        private double _constMultiplication = 0.14159;
        public double ConstMultiplication
        {
            get { return _constMultiplication; }
            set
            {
                if (value > 0 && value < 1)
                { _constMultiplication = value; }
            }
        }

        public int Hash(int key, int size)
        {
            double step1 = Math.Abs(key) * ConstMultiplication;
            return (int)Math.Truncate((step1 - Math.Truncate(step1)) * size);
        }
    }
}
