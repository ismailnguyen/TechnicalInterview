using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalInterview.Exercice1
{
    public class Order
    {
        public int Id { get; set; }
        public List<string> Articles { get; set; }
        public bool Isvalid { get; set; }

        public void Prepare()
        {
            for (int i = 0; i < Articles.Count; i++)
            {
                if (Articles[i].ToUpper() == "CHOUCROUTE")
                {
                    Articles = null;
                    Isvalid = false;
                    break;
                }
            }

            Isvalid = true;
        }

        public void Save()
        {
            // Implementation of save
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.Id = 42;
            o.Articles = new List<string>();
            o.Articles.Add("Artichaud");
            o.Articles.Add("Choucroute");

            o.Prepare();

            if (!o.Isvalid)
            {
                throw new Exception("Order is invalid !");
            }
            else
            {
                Console.WriteLine("Order Id : " + o.Id);
                Console.WriteLine("Saving order with first article " + o.Articles.First());
                o.Save();
            }
        }
    }
}