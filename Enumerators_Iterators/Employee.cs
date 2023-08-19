using System.Runtime.CompilerServices;

namespace Enumerators_Iterators
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal salary { get; set; }
        public string Department { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is not Employee)
                return false;

            var emp = obj as Employee;

            return this.Id == emp.Id &&
                this.Name == emp.Name &&
                this.salary == emp.salary &&
                this.Department == emp.Department;
        }
        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Id.GetHashCode();
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + salary.GetHashCode();
            hash = (hash * 7) + Department.GetHashCode();
            return base.GetHashCode();
        }

        public static bool operator ==(Employee left, Employee right) => left.Equals(right);
        public static bool operator !=(Employee left, Employee right) => !left.Equals(right);


    }

}
