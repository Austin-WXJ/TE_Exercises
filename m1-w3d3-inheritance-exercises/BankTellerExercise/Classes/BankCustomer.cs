using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankCustomer
    {
        //Private Instance Variables
        private List<BankAccount> accountList = new List<BankAccount>();

        //Properties
        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public BankAccount[] Accounts
        {
            get
            {
                return accountList.ToArray(); ;
            }
        }

        public bool IsVIP { get; set; }

        //Constructor
        public BankCustomer(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        //Methods
        public void AddAccount(BankAccount newAccount)
        {
            accountList.Add(newAccount);// add into accounts array
        }
    }
}
