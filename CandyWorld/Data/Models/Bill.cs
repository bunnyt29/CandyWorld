namespace CandyWorld.Data.Models
{
    public class Bill
    {
        public int BillId { get; set; }


        public int CandyEmployeeId;

        public CandyEmployee CandyEmployee { get; set; }


        public int ProductId;

        public Product Product { get; set; }


        public decimal TotalPrice { get; set; }
    }
}
