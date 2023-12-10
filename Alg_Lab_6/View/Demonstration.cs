using Alg_Lab_6.Model;
using Alg_Lab_6.Model.FolderHashTable;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.View
{
    public class Demonstration
    {
        public void Demonstrate()
        {
            int count = 10;
            MultiplicationFunc func = new MultiplicationFunc();
            //func.Const = count;
            HashTableLinked<int> hashTableLinkedList = new HashTableLinked<int>(count, func);
            RandomItemHash random = new RandomItemHash();
            SetMassiveInHashTable(hashTableLinkedList, random.DoRandomRange(new ItemHash<int>[100], -10000, 10000));
            Console.WriteLine(hashTableLinkedList.GetFillFactor());
            Console.WriteLine(hashTableLinkedList.MaxLenghtList());
            Console.WriteLine(hashTableLinkedList.MinLenghtList());
            //сравнительный анализ сделаю наверное в виде таблички
        }

        private void SetMassiveInHashTable(HashTableLinked<int> hashTable, ItemHash<int>[] items)
        {
            foreach(ItemHash<int> item in items)
            {
                hashTable.Add(item.key, item.value);
            }
        }
    }
}
