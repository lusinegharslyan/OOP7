using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP7
{
    //    •Create a Class with Private Fields:
    //•	Create a Person class with private fields for name, age, and address.
    //Implement public properties to access and modify these fields.
    //•UseGet, Set public methods to Enforce Validation:
    //•	Extend the Person class to validate that age is non-negative and name is not empty.

    class Person
    {
        private string _name;
        private int _age;
        private string _address;

        public Person(string name, int age, string address)
        {
            SetName(name);
            SetAge(age);
            SetAddress(address);
        }

        public void SetName(string name)
        {
            if (name == null)
            {
                throw new Exception("Name can't be empty");
            }
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetAge(int age)
        {
            if (age < 0)
            {
                throw new Exception("Age must be positive integer");

            }
            _age = age;

        }
        public int GetAge()
        {
            return _age;
        }
        public void SetAddress(string address)
        {
            _address = address;
        }
        public string GetAddress()
        {
            return _address;
        }

    }

    //•Encapsulate a Bank Account:
    //  •	Create a BankAccount class with private fields for accountNumber, balance, 
    // and accountHolder.
    // Implement methods to deposit and withdraw money, ensuring
    // the balance cannot become negative.

    //    3. Banking System
    //Objective: Manage bank accounts and transactions.
    //Requirements:
    //•	Classes: BankAccount, Transaction
    //•	Attributes:
    //o BankAccount: AccountNumber, AccountHolder, Balance
    //o   Transaction: TransactionID, Account, Amount, TransactionDate
    //•	Methods:
    //o BankAccount: Deposit(decimal), Withdraw(decimal), DisplayAccountInfo()
    //o Transaction: DisplayTransactionInfo()

    class BankAccount
    {
        private string _accountNumber;
        private decimal _balance;
        private string _accountHolder;

        public BankAccount(string accountNumber, decimal balance, string accountHolder)
        {
            SetAccountNumber(accountNumber);
            SetBalance(balance);
            SetAccountHolder(accountHolder);
        }

        public void SetAccountNumber(string accountNumber)
        {
            _accountNumber = accountNumber;
        }
        public string GetAccountNumber()
        {
            return _accountNumber;
        }

        public void SetBalance(decimal balance)
        {

            if (balance < 0)
            {
                throw new Exception("Balance can't be negativ ");
            }
            _balance = balance;
        }
        public decimal GetBalance()
        {
            return _balance;
        }

        public void SetAccountHolder(string accountHolder)
        {
            _accountHolder = accountHolder;
        }

        public string GetAccountHolder()
        {
            return _accountHolder;
        }


        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount can't be negative");
            }
            _balance += amount;
        }

        public void WithdrawMoney(decimal amount)
        {

            if (amount > _balance)
            {
                throw new Exception("Not enough balance");
            }
            _balance -= amount;
        }


        public void DisplayAccountInfo()
        {
            Console.WriteLine($"AccountNumber: {_accountNumber} | AccountHolder: {_accountHolder} | Balance: {_balance}");
        }
    }

    //    •Encapsulate a Car:
    //•	Create a Car class with private fields for make, model, year, and speed.Provide methods to
    //  Accelerate and Brake that modify the speed.

    class Car
    {
        private string _make;
        private string _model;
        private int _year;
        private float _speed;

        public Car(string make, string model, int year, float speed)
        {
            SetMake(make);
            SetModel(model);
            SetYear(year);
            SetSpeed(speed);
        }

        public void SetMake(string make)
        {
            _make = make;
        }

        public string GetMake()
        {
            return _make;
        }

        public void SetModel(string model)
        {
            _model = model;
        }

        public string GetModel()
        {
            return _model;
        }

        public void SetYear(int year)
        {
            _year = year;
        }

        public int GetYear()
        {
            return _year;
        }

        public void SetSpeed(float speed)
        {
            _speed = speed;
        }

        public float GetSpeed()
        {
            return _speed;
        }


        public void AccellerateSpeed(float speed)
        {
            _speed += speed;
        }

        public void BreakSpeed(float speed)
        {
            _speed -= speed;
        }
    }



    //    •Encapsulate a Rectangle:
    //•	Create a Rectangle class with private fields for width and height.Implement properties 
    //        to get and set these fields and a method to calculate the area.

    class Rectangle
    {
        private float _width;
        private float _heigth;

        public Rectangle(float width, float heigth)
        {
            SetWidth(width);
            SetHeigth(heigth);
        }

        public void SetWidth(float width)
        {
            if (width < 0)
            {
                throw new Exception("Width must be more than 0");
            }
            _width = width;
        }
        public float GetWidth()
        {
            return _width;
        }

        public void SetHeigth(float heigth)
        {
            if (heigth < 0)
            {
                throw new Exception("Heigth must be more than 0");
            }

            _heigth = heigth;
        }

        public float GetHeigth(float heigth)
        {
            return _heigth;
        }


        public float CalculateArea()
        {
            return _width * _heigth;
        }
    }


    //    •Encapsulate a Student:
    //•	Create a Student class with private fields for studentID, name, and grade.
    //        Implement properties with appropriate validation and methods to print student details.





    //    •Encapsulate a Library:
    //•	Create a Library class with a private field for a list of Book objects.
    //        Implement methods to add and remove books from the library and to list all books.




    //    •Encapsulate a Shopping Cart:
    //•	Create a ShoppingCart class with a private field for a list of items and their quantities.
    //        Implement methods to add, remove, and list items in the cart.




    //    •Encapsulate a Thermostat:
    //•	Create a Thermostat class with private fields for currentTemperature and targetTemperature.
    // Implement methods to adjust the target temperature and check if the current temperature meets the target.


    //    •Encapsulate a Company:
    //•	Create a Company class with private fields for companyName, employees(a list of Employee objects). 
    //        Implement methods to add, remove, and list employees.




    //    •Encapsulate a Video Game Character:
    //•	Create a Character class with private fields for name, health, level, and inventory(a list of items). 
    //        Implement methods to add items to the inventory and take damage, ensuring health does not drop below zero.







    //    •Encapsulate an Order System:
    //•	Create an Order class with private fields for orderID, orderDate, items(a list of items), and totalAmount.
    //        Implement methods to add items to the order and calculate the total amount.



    //    5. Hotel Reservation System
    //Objective: Manage hotel rooms and reservations.
    //Requirements:
    //•	Classes: Room, Reservation, Guest
    //•	Attributes:
    //o Room: RoomNumber, Type, Price, IsReserved
    //o   Reservation: ReservationID, Room, Guest, CheckInDate, CheckOutDate
    //o   Guest: Name, GuestID, ContactInfo
    //•	Methods:
    //o Room: DisplayInfo(), ReserveRoom(), ReleaseRoom()
    //o Reservation: DisplayReservationInfo()
    //o Guest: DisplayInfo()

    class Room
    {
        private int _roomNumber;
        private string _type;
        private float _price;
        private bool _isReserved;


    }

    class Reservation
    {
        private int _reservationId;
        private Room _room;
        private Guest _guest;
        private string _checkInDate;
        private string _checkOutDate;


        public void displayReservationInfo()
        {
            Console.WriteLine($"Id: {_reservationId} | RoomNumber:{_room.GetNumber()} | GuestName:{_guest.GetName()} | CheckInDate:{_checkInDate} | CheckOutDate: {_checkOutDate}");
        }

    }
    class Guest
    {
        private string _name;
        private int _guestId;
        private string _contactInfo;

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetGuestId(int id)
        {
            _guestId = id;
        }
        public int GetGuestId()
        {
            return _guestId;
        }
        public void SetContactInfo(string contactInfo)
        {
            _contactInfo = contactInfo;
        }
        public string GetContactInfo()
        {
            return _contactInfo;
        }

        public void DispalyInfo()
        {
            Console.WriteLine($"Name: {_name} | Id: {_guestId} | Contact: {_contactInfo}");
        }
    }






    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
