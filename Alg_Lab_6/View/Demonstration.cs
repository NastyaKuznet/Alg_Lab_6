using Alg_Lab_6.Model;
using Alg_Lab_6.Model.FolderHashTable;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.AdressFunc;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.View
{
    public class Demonstration
    {
        public void Demonstrate()
        {
            int count = 1000;

            PolynomialHashFunc polynomialHash = new PolynomialHashFunc();
            PerlinNoiseFunc perlinNoise = new PerlinNoiseFunc();
            SHA1Func sha1 = new SHA1Func();
            DivisionFunc divisionFunc = new DivisionFunc();
            MultiplicationFunc multiplicationFunc = new MultiplicationFunc();
            //func.auxiliaryHashFunc1 = new StartAndLenghtModFunc();
            //func.auxiliaryHashFunc2 = new DivisionFunc();
            //func.auxiliaryHashFunc3 = new BitShifXorFunc();
            //func.Const = count;

            //HashTableLinked<int> hashTableLinkedList = new HashTableLinked<int>(count, func);

            DoubleHashingFunc func = new DoubleHashingFunc();
            func.auxiliaryHashFunc1 = sha1;
            func.auxiliaryHashFunc2 = multiplicationFunc;
            HashTableAdress<int> hashTableadress = new HashTableAdress<int>(count, func);
            RandomItemHash random = new RandomItemHash();
            SetMassiveInHashTable(hashTableadress, random.DoRandomRange(new ItemHash<int>[100000], -100000, 100000));
            //hashTableLinkedList.Print(10);
            //Console.ReadKey();
            //hashTableLinkedList.Add(9, 1);
            //hashTableLinkedList.Print(10);
            Console.WriteLine(hashTableadress.GetFillFactor());
            Console.WriteLine(hashTableadress.MaxClusterL());
            //Console.WriteLine(hashTableLinkedList.MaxLenghtList());
            //Console.WriteLine(hashTableLinkedList.MinLenghtList());
            //сравнительный анализ сделаю наверное в виде таблички
        }

        public void DemonstrateLinkBase(HashTableLinked<int> hashTableLinkedList, int count1)
        {
            int start = -1000;
            int finish = 1000;
            

            RandomItemHash random = new RandomItemHash();
            SetMassiveInHashTable(hashTableLinkedList, random.DoRandomRange(new ItemHash<int>[count1], start, finish));

            Console.Clear();
            Console.WriteLine("ДЕМОНСТРАЦИЯ ИДЕТ ПО НАЖАТИЮ ЛЮБОЙ КЛАВИШИ В ПОРЯДКЕ: ДОБАВЛЕНИЕ ЭЛЕМЕНТА, УДАЛЕНИЕ ЭЛЕМЕНТА, ПОЛУЧЕНИЕ ЭЛЕМЕНТА");
            Console.WriteLine("нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("ДОБАВЛЕНИЕ ДО");
            Console.WriteLine("нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
            hashTableLinkedList.Print(10);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("ДОБАВЛЕНИЕ ПОСЛЕ: (9, 12), (6, 50)");
            Console.WriteLine("нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
            hashTableLinkedList.Add(9, 12);
            hashTableLinkedList.Add(6, 50);
            hashTableLinkedList.Print(10, new int[2] {9, 6}, new int[2] {12, 50 });
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"УДАЛЕНИЕ ПОСЛЕ: (9, 12) -> {hashTableLinkedList.Remove(9)}");
            Console.WriteLine($"УДАЛЕНИЕ ПОСЛЕ: (2, 324) -> {hashTableLinkedList.Remove(2)}");
            Console.WriteLine("нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
            hashTableLinkedList.Print(10);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"ПОЛУЧЕНИЕ: КЛЮЧ - 9 -> ЗНАЧЕНИЕ {hashTableLinkedList.GetElement(9)}");
            Console.WriteLine("нажмите любую клавишу, чтобы продолжить");
            Console.WriteLine($"ПОЛУЧЕНИЕ: КЛЮЧ - 6 -> ЗНАЧЕНИЕ {hashTableLinkedList.GetElement(6)}");
            Console.WriteLine("нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
        }

        public void DemonstrateAdressBase(HashTableAdress<int> hashTableLinkedList, int count1)
        {
            int start = -1000;
            int finish = 1000;


            RandomItemHash random = new RandomItemHash();
            SetMassiveInHashTable(hashTableLinkedList, random.DoRandomRange(new ItemHash<int>[count1], start, finish));

            Console.Clear();
            Console.WriteLine("ДЕМОНСТРАЦИЯ ИДЕТ ПО НАЖАТИЮ ЛЮБОЙ КЛАВИШИ В ПОРЯДКЕ: ДОБАВЛЕНИЕ ЭЛЕМЕНТА, УДАЛЕНИЕ ЭЛЕМЕНТА, ПОЛУЧЕНИЕ ЭЛЕМЕНТА");
            Console.WriteLine("нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("ДОБАВЛЕНИЕ ДО");
            Console.WriteLine("нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
            hashTableLinkedList.Print(10);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("ДОБАВЛЕНИЕ ПОСЛЕ: (9, 12), (6, 50)");
            Console.WriteLine("нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
            hashTableLinkedList.Add(9, 12);
            hashTableLinkedList.Add(6, 50);
            hashTableLinkedList.Print(10, new int[2] { 9, 6 }, new int[2] { 12, 50 });
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"УДАЛЕНИЕ ПОСЛЕ: 9 -> {hashTableLinkedList.Remove(9)}");
            Console.WriteLine($"УДАЛЕНИЕ ПОСЛЕ: 2 -> {hashTableLinkedList.Remove(2)}");
            Console.WriteLine("нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
            hashTableLinkedList.Print(10);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"ПОЛУЧЕНИЕ: КЛЮЧ - 9 -> ЗНАЧЕНИЕ {hashTableLinkedList.GetElement(9)}");
            Console.WriteLine($"ПОЛУЧЕНИЕ: КЛЮЧ - 6 -> ЗНАЧЕНИЕ {hashTableLinkedList.GetElement(6)}");
            Console.WriteLine("нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
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
