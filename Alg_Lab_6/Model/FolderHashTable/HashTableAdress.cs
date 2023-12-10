using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.Interface;
using Alg_Lab_6.Model.FolderLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.Model.FolderHashTable
{
    public class HashTableAdress<T>
    {
        ItemHash<T>[] massive;
        int size;
        IHashFuncAdress hashFunc;
        double loadFactor = 0.75;

        public HashTableAdress(int lenghtMassive, IHashFuncAdress hashFunc)
        {
            size = lenghtMassive;
            massive = new ItemHash<T>[size];
            this.hashFunc = hashFunc;
        }

        public bool Add(int key, T value)
        {
            CheckSize();
            int attemp = 0;
            int hashKey = hashFunc.Hash(key, size, attemp);
            while (true)
            {
                if (hashKey == massive.Length || massive[hashKey].key.Equals(key))
                {
                    return false;
                }
                if (massive[hashKey] is null || massive[hashKey].isRemove)
                {
                    massive[hashKey] = new ItemHash<T>(key, value);
                    return true;
                }
                
                hashKey = hashFunc.Hash(key, size, ++attemp);
            }
        }

        public T GetElement(int key)
        {
            int attempt = 0;
            int hashKey = hashFunc.Hash(key, size, attempt);
            while (true)
            {
                if (hashKey == massive.Length || massive[hashKey] is null)
                {
                    return default;
                }
                if (massive[hashKey].key.Equals(key) && !massive[hashKey].isRemove)
                {
                    return massive[hashKey].value;
                }
                hashKey = hashFunc.Hash(key, size, ++attempt);
            }
        }

        public bool Remove(int key) 
        {
            int attempt = 0;
            int hashKey = hashFunc.Hash(key, size, attempt);
            while (true)
            {
                if (hashKey == massive.Length)
                {
                    return false;
                }
                if (massive[hashKey].key.Equals(key))
                {
                    if (hashKey == massive.Length - 1 || massive[hashKey++] is null)
                        massive[hashKey] = null;
                    else
                        massive[hashKey].isRemove = true;
                    return true;
                }
                hashKey = hashFunc.Hash(key, size, ++attempt);
            }
        }

        private void CheckSize()
        {
            double factor = GetFillFactor();
            if (factor >= loadFactor) ResizeTable();
        }

        private void ResizeTable()
        {
            size = size * 2;
            ItemHash<T>[] newMassive = new ItemHash<T>[size];

            foreach (ItemHash<T> item in massive)
            {
                int attemp = 0;
                int hashKey = hashFunc.Hash(item.key, size, attemp);//?
                while (true)
                {
                    if (massive[hashKey] is null || massive[hashKey].isRemove)
                    {
                        newMassive[hashKey] = new ItemHash<T>(hashKey, item.value);
                        break;
                    }
                    hashKey = hashFunc.Hash(item.key, size, ++attemp);
                }
            }
            massive = newMassive;
        }

        public double GetFillFactor()
        {
            int count = 0;
            foreach (ItemHash<T> item in massive)
            {
                if (item is not null)
                {
                    count++;
                }
            }
            return (double)count / (double)size;
        }

        public int MaxClusterL()
        {
            int max = 0;
            int count = 0;
            foreach(ItemHash<T> item in massive)
            {
                if(item is not null)
                {
                    count++;
                }
                else
                {
                    if(count > max)
                        max = count;
                    count = 0;
                }
            }
            return max;
        }
    }
}
