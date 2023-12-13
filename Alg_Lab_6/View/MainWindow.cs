using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.LinkFunc;
using Alg_Lab_6.Model.FolderHashTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alg_Lab_6.Model.FolderHashTable.FolderHashFunc.AdressFunc;

namespace Alg_Lab_6.View
{
    public class MainWindow
    {
        public void Do()
        {
            Console.Clear();
            Console.WriteLine("_ ХЭШ-ТАБЛИЦЫ - ДЕМОНСТРАЦИЯ _");
            Console.WriteLine("1. Хэш-таблица - метод разрешения коллизий методом цепочек");
            Console.WriteLine("2. Хэш-таблица - метод разрешения коллизий методом открытой адресации");
            Console.WriteLine();
            Console.WriteLine("Напишите нужную команду:");
            Command();
        }

        private void Command()
        {
            string? answ = Console.ReadLine();
            switch (answ)
            {
                case ("1"):
                    DoLinkTable();
                    break;
                case ("2"):
                    DoAdressTable();
                    break;
                default: 
                    Do();
                    break;
            }
        }

        private void DoLinkTable()
        {
            Console.Clear();
            Console.WriteLine("_ Хэш-таблица - метод разрешения коллизий методом цепочек _");
            Console.WriteLine("1. Метод деления");
            Console.WriteLine("2. Метод умножения");
            Console.WriteLine("3. Собственная хэш-функция - BitPiFunc");
            Console.WriteLine("4. Собственная хэш-функция - BitShifXor");
            Console.WriteLine("5. Собственная хэш-функция - StartAndLenghtMod");
            Console.WriteLine("6. Назад");
            Console.WriteLine();
            Console.WriteLine("Напишите нужную команду:");
            Command2();
        }

        private void Command2()
        {
            string? answ = Console.ReadLine();
            switch (answ)
            {
                case ("1"):
                    int count = 6;
                    DivisionFunc func = new DivisionFunc();
                    HashTableLinked<int> hashTableLinkedList = new HashTableLinked<int>(count, func);
                    new Demonstration().DemonstrateLinkBase(hashTableLinkedList, 10);
                    break;
                case ("2"):
                    int count2 = 6;
                    MultiplicationFunc func2 = new MultiplicationFunc();
                    HashTableLinked<int> hashTableLinkedList2 = new HashTableLinked<int>(count2, func2);
                    new Demonstration().DemonstrateLinkBase(hashTableLinkedList2, 10);
                    break;
                case ("3"):
                    int count3 = 6;
                    BitPiFunc func3 = new BitPiFunc();
                    HashTableLinked<int> hashTableLinkedList3 = new HashTableLinked<int>(count3, func3);
                    new Demonstration().DemonstrateLinkBase(hashTableLinkedList3, 7);
                    break;
                case ("4"):
                    int count4 = 6;
                    BitShifXorFunc func4 = new BitShifXorFunc();
                    HashTableLinked<int> hashTableLinkedList4 = new HashTableLinked<int>(count4, func4);
                    new Demonstration().DemonstrateLinkBase(hashTableLinkedList4, 7);
                    break;
                case ("5"):
                    int count5 = 6;
                    StartAndLenghtModFunc func5 = new StartAndLenghtModFunc();
                    HashTableLinked<int> hashTableLinkedList5 = new HashTableLinked<int>(count5, func5);
                    new Demonstration().DemonstrateLinkBase(hashTableLinkedList5, 10);
                    break;
                case ("6"):
                    Do();
                    break;
                default:
                    DoLinkTable();
                    break;
            }
            DoLinkTable();
        }

        private void DoAdressTable()
        {
            Console.Clear();
            Console.WriteLine("_ Хэш-таблица - метод разрешения коллизий методом открытой адресации _");
            Console.WriteLine("1. Линейное исследование");
            Console.WriteLine("2. Квадратичное исследование");
            Console.WriteLine("3. Двойное хэширование");
            Console.WriteLine("4. Собственная хэш-функция - DivMinusAtempt");
            Console.WriteLine("5. Собственная хэш-функция - ThridHashingOperation");
            Console.WriteLine("6. Назад");
            Console.WriteLine();
            Console.WriteLine("Напишите нужную команду:");
            Command3();
        }

        private void Command3()
        {
            string? answ = Console.ReadLine();
            switch (answ)
            {
                case ("1"):
                    int count = 6;
                    LinearResearchFunc func = new LinearResearchFunc();
                    HashTableAdress<int> hashTableAdressList = new HashTableAdress<int>(count, func);
                    new Demonstration().DemonstrateAdressBase(hashTableAdressList, 10);
                    break;
                case ("2"):
                    int count2 = 6;
                    QuadraticResearchFunc func2 = new QuadraticResearchFunc();
                    HashTableAdress<int> hashTableAdressList2 = new HashTableAdress<int>(count2, func2);
                    new Demonstration().DemonstrateAdressBase(hashTableAdressList2, 10);
                    break;
                case ("3"):
                    int count3 = 6;
                    DoubleHashingFunc func3 = new DoubleHashingFunc();
                    HashTableAdress<int> hashTableAdressList3 = new HashTableAdress<int>(count3, func3);
                    new Demonstration().DemonstrateAdressBase(hashTableAdressList3, 7);
                    break;
                case ("4"):
                    int count4 = 6;
                    DivMinusAtemptFunc func4 = new DivMinusAtemptFunc();
                    HashTableAdress<int> hashTableAdressList4 = new HashTableAdress<int>(count4, func4);
                    new Demonstration().DemonstrateAdressBase(hashTableAdressList4, 7);
                    break;
                case ("5"):
                    int count5 = 6;
                    ThridHashingOperationFunc func5 = new ThridHashingOperationFunc();
                    HashTableAdress<int> hashTableAdressList5 = new HashTableAdress<int>(count5, func5);
                    new Demonstration().DemonstrateAdressBase(hashTableAdressList5, 10);
                    break;
                case ("6"):
                    Do();
                    break;
                default:
                    DoAdressTable();
                    break;
            }
            DoAdressTable();
        }
    }
}
