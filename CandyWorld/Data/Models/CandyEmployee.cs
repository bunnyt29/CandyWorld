namespace CandyWorld.Data.Models
{
    public class CandyEmployee
    {
        public int CandyEmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime HireDate { get; set; }

        public int Salary { get; set; }

        public int EmployeePositionId { get; set; }

        public EmployeePosition Position { get; set; }

        public ICollection<Bill> Bills { get; set; } = new HashSet<Bill>();

        public ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
