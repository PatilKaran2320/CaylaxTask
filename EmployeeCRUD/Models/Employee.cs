using NuGet.Protocol.Core.Types;

namespace EmployeeCRUD.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string Gender { get; set; }

    }
}
