using SalesWebMvc.Models.Enums;
using System;


namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus SaleStatus { get; set; }
        public Seller Seller { get; set; } //#Every seller has a registered sale. BB

        public SalesRecord()
        {
            //Empty Constructor
        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus saleStatus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            SaleStatus = saleStatus;
            Seller = seller;
        }
    }
}
