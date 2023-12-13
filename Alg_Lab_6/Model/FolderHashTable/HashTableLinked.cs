using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alg_Lab_6.Model.FolderLinkedList;
using System.ComponentModel.DataAnnotations.Schema;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using Alg_Lab_6.View;

namespace Alg_Lab_6.Model.FolderHashTable
{
    public class HashTableLinked<T>
    {
        DoublyLinkedList<ItemHash<T>>[] massive;
        int size;
        IHashFuncLink hashFunc;
        double loadFactor = 0.75;

        public HashTableLinked(int lenghtMassive, IHashFuncLink hashFunc)
        {
            size = lenghtMassive;
            massive = new DoublyLinkedList<ItemHash<T>>[size];
            this.hashFunc = hashFunc;
        }

        public void Add(int key, T value)
        {
            CheckSize();
            int hashKey = hashFunc.Hash(key, size);

            if (massive[hashKey] == null)
                massive[hashKey] = new DoublyLinkedList<ItemHash<T>>();
            massive[hashKey].Add(new ItemHash<T>(key, value));
        }

        public T GetElement(int key)
        {
            int hashKey = hashFunc.Hash(key, size);

            if (massive[hashKey] != null)
            {
                foreach (ItemHash<T> item in massive[hashKey])
                {
                    if (item.key == key)
                        return item.value;
                }
            }
            return default;
        }

        public bool Remove(int key)
        {
            int hashKey = hashFunc.Hash(key, size);

            if (massive[hashKey] != null)
            {
                foreach (ItemHash<T> item in massive[hashKey])
                {
                    if (item.key == key)
                    {
                        massive[hashKey].Remove(item);
                        return true;
                    }
                }
            }
            return false;
        }

        private void CheckSize()
        {
            double factor = GetFillFactor();
            if (factor >= loadFactor) ResizeTable();
        }

        private void ResizeTable()
        {
            size = size * 2;
            DoublyLinkedList<ItemHash<T>>[] newMassive = new DoublyLinkedList<ItemHash<T>>[size];
            
            for(int i = 0; i < massive.Length; i++)
            {
                if (massive[i] is not null)
                {
                    foreach (ItemHash<T> item in massive[i])
                    {
                        int hashKey = hashFunc.Hash(item.key, size);
                        if (newMassive[hashKey] is null)
                            newMassive[hashKey] = new DoublyLinkedList<ItemHash<T>>();
                        newMassive[hashKey].Add(new ItemHash<T>(hashKey, item.value));
                    }
                }
            }
            massive = newMassive;
        }

        public double GetFillFactor()
        {
            int count = 0;
            foreach(DoublyLinkedList<ItemHash<T>> list in massive)
            {
                if (list is not null)
                {
                    foreach (ItemHash<T> item in list)
                    {
                        if (item is not null)
                            count++;
                    }
                }
            }
            return (double)count / (double)size;
        }

        public int MaxLenghtList()
        {
            int max = 0;
            foreach (DoublyLinkedList<ItemHash<T>> list in massive)
            {
                if (list is not null)
                {
                    if(list.Count > max)
                        max = list.Count;
                }
            }
            return max;
        }

        public int MinLenghtList()
        {
            int min = int.MaxValue;
            foreach (DoublyLinkedList<ItemHash<T>> list in massive)
            {
                if (list is not null)
                {
                    if (list.Count < min)
                        min = list.Count;
                }
            }
            return min;
        }

        public void Print(int lenght)
        {
            Printer printer = new Printer();
            for (int i = 0; i < massive.Length; i++)
            {
                printer.PrintCell(i.ToString(), lenght, 0, i * 3 + 1, ConsoleColor.DarkRed);

                int count = 1;
                if (massive[i] is not null)
                {
                    foreach (ItemHash<T> item in massive[i])
                    {
                        printer.PrintCell(item.key.ToString() + "|" + item.value.ToString(), lenght, (lenght + 8) * count, i * 3 + 1, ConsoleColor.Green);
                        count += 1;
                    }
                }
                else
                {
                    printer.PrintCell("null", lenght, (lenght + 8) * count, i * 3 + 1, ConsoleColor.White);
                }
            }
        }

        public void Print(int lenght, int[] keySelected, T[] valueSelected)
        {
            Printer printer = new Printer();
            for (int i = 0; i < massive.Length; i++)
            {
                printer.PrintCell(i.ToString(), lenght, 0, i * 3 + 1, ConsoleColor.DarkRed);

                int count = 1;
                if (massive[i] is not null)
                {
                    foreach (ItemHash<T> item in massive[i])
                    {
                        if(keySelected.Contains(item.key) && valueSelected.Contains(item.value))
                            printer.PrintCell(item.key.ToString() + "|" + item.value.ToString(), lenght, (lenght + 8) * count, i * 3 + 1, ConsoleColor.Red);
                        else
                            printer.PrintCell(item.key.ToString() + "|" + item.value.ToString(), lenght, (lenght + 8) * count, i * 3 + 1, ConsoleColor.Green);
                        count += 1;
                    }
                }
                else
                {
                    printer.PrintCell("null", lenght, (lenght + 8) * count, i * 3 + 1, ConsoleColor.White);
                }
            }
        }
    }
}
