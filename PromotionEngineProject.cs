using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest
{
    public class Product
    {
        private const decimal PRICE_A = 50m;
        private const decimal PRICE_B = 30m;
        private const decimal PRICE_C = 20m;
        private const decimal PRICE_D = 2015m;

        public string Id { get; set; }
        public decimal Price { get; set; }


        public Product(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    this.Price = PRICE_A;

                    break;
                case "B":
                    this.Price = PRICE_B;

                    break;
                case "C":
                    this.Price = PRICE_C;

                    break;
                case "D":
                    this.Price = PRICE_D;
                    break;
                default:
                    break;
            }
        }

        public static int GetTotalPrice(List<Product> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;
        }

    }
}
