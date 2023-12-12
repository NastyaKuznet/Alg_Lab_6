using Alg_Lab_6.Model;
using Alg_Lab_6.Model.FolderHashTable;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.AdressFunc;
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
            int count = 10000;
            ShiftMinusAtemptFunc func = new ShiftMinusAtemptFunc();
            func.auxiliaryHashFunc = new StartAndLenghtModFunc();
            //func.auxiliaryHashFunc2 = new StartAndLenghtModFunc();
            //func.Const = count;
            HashTableAdress<int> hashTableLinkedList = new HashTableAdress<int>(count, func);
            RandomItemHash random = new RandomItemHash();
            SetMassiveInHashTable(hashTableLinkedList, random.DoRandomRange(new ItemHash<int>[10000], -100000, 100000));
            Console.WriteLine(hashTableLinkedList.GetFillFactor());
            Console.WriteLine(hashTableLinkedList.MaxClusterL());
            //Console.WriteLine(hashTableLinkedList.MaxLenghtList());
            //Console.WriteLine(hashTableLinkedList.MinLenghtList());
            //сравнительный анализ сделаю наверное в виде таблички
        }

        private void SetMassiveInHashTable(HashTableLinked<int> hashTable, ItemHash<int>[] items)
        {
            int count = 0;
            foreach(ItemHash<int> item in items)
            {
                
                hashTable.Add(item.key, item.value);
                count++;
                Console.WriteLine(count);
            }
        }

        private void SetMassiveInHashTable(HashTableAdress<int> hashTable, ItemHash<int>[] items)
        {
            int count = 0;
            foreach (ItemHash<int> item in items)
            {
                hashTable.Add(item.key, item.value);
                count++;
                Console.WriteLine(count);
            }
        }
    }
}
