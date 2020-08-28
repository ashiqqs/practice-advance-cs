using PracticeAdvanceCS.EmployeePart;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeAdvanceCS
{
    //Asynchronous method
    //Await
    public class Program
    {
       public static void Main(string[] args)
        {
            //Console.Write("Press Enter to Start count:");
            //Console.ReadLine();

            // OnPressEnter();
            //  Console.WriteLine(a);

            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ')
                .Select(val => Convert.ToInt32(val)).ToArray();
            int i, j, temp;
            for(i=0; i<length; i++)
            {
                bool isSwapped = false;
                for(j=0; i<length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        isSwapped = true;
                    }
                }
                if (!isSwapped) { break; }
            }
            int medianIndex = length / 2;
            if (length % 2 != 0)
            {
                Console.WriteLine(arr[medianIndex+1]);
            }
            else
            {
                int median = (arr[medianIndex] + arr[medianIndex + 1]) / 2;
                Console.WriteLine(median);
            }
            
        }

        public async static void OnPressEnter()
        {
            Task<int> task = new Task<int>(StartProcessToCountChar);
            task.Start();
            Console.WriteLine("Please wait while reading the file...");
            int count = await task;
            Console.WriteLine("Total Charecter = " + count);
        }
        private static int StartProcessToCountChar()
        {

            using (StreamReader reader = new StreamReader("I:\\PracticeBasicCS\\Program.cs"))
            {
                int count = 0;
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
                return count;
            }
        }
    }

    public class Account
    {
        public Account(int id, double balance)
        {
            Id = id;
            Balance = balance;
        }
        public int Id { get; set; }
        public double Balance { get; set; }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }

    public class AccountManager
    {
        public AccountManager(Account fromAcc, Account toAcc, double transferAmount)
        {
            FromAccount = fromAcc;
            ToAccount = toAcc;
            AmountToTransfer = transferAmount;
        }
        Account FromAccount { get; set; }
        Account ToAccount { get; set; }
        double AmountToTransfer { get; set; }
        public void Transfer()
        {
            object _lock1, _lock2;
            if (FromAccount.Id < ToAccount.Id)
            {
                _lock1 = FromAccount;
                _lock2 = ToAccount;
            }
            else
            {
                _lock1 = ToAccount;
                _lock2 = FromAccount;
            }
            Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on {((Account)_lock1).Id.ToString()}");
            lock (_lock1)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {((Account)_lock1).Id.ToString()}");
                Console.WriteLine($"{Thread.CurrentThread.Name} suspende for 1 sec");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} back on action and trying to acquire lock on {((Account)_lock2).Id.ToString()}");
                lock (_lock2)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {((Account)_lock2).Id.ToString()}");
                    FromAccount.Withdraw(AmountToTransfer);
                    ToAccount.Deposit(AmountToTransfer);
                    Console.WriteLine($"{Thread.CurrentThread.Name} Transfered {AmountToTransfer} From {FromAccount.Id} to {ToAccount.Id}");
                }
            }
        }

    }

    public class Base
    {
        public string Parent { get; set; }
    }
    public class Derived : Base
    {
        public string  Child { get; set; }
    }
}