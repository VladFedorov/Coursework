using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    class Drugstore
    {
        string name;
        string manufact;
        double price;
        int amount;
        int drugNumb;
        int[] expDate = new int[3];
        byte error = 0;

        public string Name { get => name; set => name = value; }
        public string Manufact { get => manufact; set => manufact = value; }
        public double Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public int DrugNumb { get => drugNumb; set => drugNumb = value; }
        public int[] ExpDate { get => expDate; set => expDate = value; }
        public byte Error { get => error; set => error = value; }

        public Drugstore(string name, string manufact, double price, int amount, int drugNumb, int[] expDate)
        {
            Name = name;
            Manufact = manufact;
            Price = price;
            Amount = amount;
            DrugNumb = drugNumb;
            ExpDate = expDate;
        }
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
            if (Price < 0)
            {
                error = 3;
                return false;
            }
            if ( ExpDate[0] > 31)
            {
                error = 4;
                return false;
            }
            if ( ExpDate[1] > 12)
            {
                error = 5;
                return false;
            }
            if (ExpDate[2] <1990 || ExpDate[2] > 2019)
            {
                error = 6;
                return false;
            }
            return true;
        }
    }

}
