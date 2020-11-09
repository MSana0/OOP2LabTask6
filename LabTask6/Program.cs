using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
        
        private double cgpa;
        public double Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private Book[] borrowedBook;
        public Book[] BorrowedBook
        {
            get { return borrowedBook; }
            set { borrowedBook = value; }
        }
        private int borrowedBookCount;
        public int BorrowedBookCount
        {
            get { return borrowedBookCount; }
            set { borrowedBookCount = value; }
        }
        public Student()
        {
            Console.WriteLine("Empty Constructor");
        }
        public Student(string name, string id, string dept, double cgpa)
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
        public void showBorrowedBookInfo()
        {
            for (int i = 0; i < borrowedBookCount; i++)
            {
                borrowedBook[i].showInfo();
            }
        }
    }
    class Account
    {
        private string accName;
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        private string accId;
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
        public Account(string accName, string accId, int balance)
        {
            this.accName = accName;
            this.accId = accId;
            this.balance = balance;
        }
        private int amount;
        public void Deposit(int amount)
        {
            this.balance += amount;
            Console.WriteLine("Deposited amount: " + amount + "Current balance:" + balance);
        }
        public void Withdraw(int amount)
        {
            if (this.amount < balance) { this.balance -= amount; }
            else { Console.WriteLine("Insufficient Balance"); }
            Console.WriteLine("Withdrawn amount: " + amount + "Current balance:" + balance);
        }
        public void Transfer(int amount, Account reciever)
        {
            if (this.balance < amount) { Console.WriteLine("Insufficient balance"); }
            else
            {
                if(reciever!=null)
                {
                    reciever.balance += amount;
                    this.balance -= amount;
                    Console.WriteLine("Transferred amount: "+reciever.balance);
                }
                else { Console.WriteLine("Reciever not found."); }
            }
        }
    }
    class Book
    {
        private string bookName;
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private string bookAuthor;
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
            get { return bookType; }
            set { bookType = value; }
        }
        int bookCopy;
        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }
        public Book()
        { }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }
        public void showInfo()
        {
            Console.WriteLine("Book Name: " + bookName);
            Console.WriteLine("Book Author: " + bookAuthor);
            Console.WriteLine("Book ID: " + bookId);
            Console.WriteLine("Book Type: " + bookType);
            Console.WriteLine("Number of copies: " + bookCopy);
        }
        public void addBookCopy(int b)
        {
            this.bookCopy += b;
        }
    }
    class Library
    {
        private string libName;
        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }
        private string libAddress;
        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
        private Book[] listOfBook;
        public Book[] ListOfBook
        {
            get { return listOfBook; }
            set { listOfBook = value; }
        }
        private int totalBook;
        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
        private Student[] libMembers;
        public Student[] LibMembers
        {
            get { return libMembers; }
            set { libMembers = value; }
        }
        public Library() { }
        public Library(string libName, string libAddress, Book[] listOfBook, int totalBook)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.listOfBook = listOfBook;
            this.totalBook = totalBook;
        }
        public void showLibInfo()
        {
            Console.WriteLine("Library Name: " + libName);
            Console.WriteLine("Library Address: " + libAddress);
            Console.WriteLine("Total Books: " + totalBook);
        }
        public void showAllBook()
        {
            for (int i=0;i<=totalBook;i++)
            {
                listOfBook[i].showInfo();
                Console.WriteLine(listOfBook[i]);
            }
        }
        public void addNewBook(Book book)
        {
            listOfBook[totalBook++] = book;
        }
        public void deleteBook(Book book)
        {
            for (int i = 0; i <= totalBook; i++)
            {
                if(listOfBook[i]==book)
                {
                    listOfBook[i] = null;
                    break;
                }
                if (i < totalBook)
                {
                    for (int j = i; j <= totalBook - 1; j++)
                    {
                        listOfBook[j] = listOfBook[j + 1];
                    }
                }
            }
        }
        public void addNewBookCopy(Book book, int copy)
        {

            listOfBook[totalBook++] = book;
        }
        public void showAllBorrowInfo()
        {
            for (int i = 0; i < libMembers.Length;i++)
            {
                libMembers[i].showInfo();
                libMembers[i].showBorrowedBookInfo();
            }
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Marium Sana","18-39059-3","CSE",3.73);
            Student s2 = new Student("ABC", "123", "CBA", 321);
            Student s3 = new Student("DEF", "456", "FED", 654);
            Student s4 = new Student("GHI", "789", "IHG", 987);
            
        }
    }
}
