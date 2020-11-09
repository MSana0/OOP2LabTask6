using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabTask6
{
    class Student 
    {

        string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        string dept;
        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        
        private float cgpa;
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student()
        {
            Console.WriteLine("Empty Constructor");
        }
        public Student(string name, string id, string dept, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.dept = dept;
            this.cgpa = cgpa;
        }
        public void showInfo()
        {
            Console.WriteLine("Student Name: " +name);
            Console.WriteLine("Student Id: " + id);
            Console.WriteLine("Department: " + dept);
            Console.WriteLine("Cgpa: " + cgpa);
        }
    }
    class Account
    {
        string accName;
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        string accId;
        public string AccId
        {
            get { return accId; }
            set { accId = value; }
        }
        private int balance;
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account()
        {
            Console.WriteLine("Empty Constructor");
        }
        public Account(string accname, string accId, int balance)
        {
            this.accname = accname;
            this.accId = accId;
            this.balance = balance;
        }
        int amount;
        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposited amount: " + amount + "Current balance:" + balance);
        }
        public void Withdraw(int amount)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn amount: " + amount + "Current balance:" + balance);
        }
        public void Transfer(int amount, Account reciever)
        {

        }
    }
    class Book
    {
        string bookName;
        public string BookName
        {
            get { return bookName; }
            set {bookName=value; }
        }
        string bookAuthor;
        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        private string bookId;
        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        string bookType;
        public string BookType
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
