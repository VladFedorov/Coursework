using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    class Mechstore
    {
        string name;
        string manufact;
        double price;
        int amount;
        int drugNumb;
        int consignment;
        byte error = 0;

        public string Name { get => name; set => name = value; }
        public string Manufact { get => manufact; set => manufact = value; }
        public double Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public int StoreNumb { get => drugNumb; set => drugNumb = value; }
        public int Consignment { get => consignment; set => consignment = value; }
        public byte Error { get => error; set => error = value; }

        public Mechstore(string name, string manufact, double price, int amount, int drugNumb, int consignment)
        {
            Name = name;
            Manufact = manufact;
            Price = price;
            Amount = amount;
            StoreNumb = drugNumb;
            Consignment = consignment;
        }
        //Checking
        public bool check()
        {
            if (Name == "")
            {
                error = 1;
                return false;
            }
            if (Manufact == "")
            {
                error = 2;
                return false;
            }
            return true;
        }
    }

}
