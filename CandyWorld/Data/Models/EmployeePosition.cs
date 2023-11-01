namespace CandyWorld.Data.Models
{
    public class EmployeePosition
    {
        public int EmployeePositionId { get; set; }

        public string JobTitle { get; set; }

        public ICollection<CandyEmployee> Employees { get; set; } = new HashSet<CandyEmployee>();
    }
}
