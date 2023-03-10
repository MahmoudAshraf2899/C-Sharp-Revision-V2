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
            //If Object you send is null
            if (obj == null) { return false; }
            //If object Type You Send is Not Employee Type
            if (!(obj is Employee)) { return false; }

            //Then Obj you send operate with him as Employee
            var emp = obj as Employee;
            //Make Sure That Values Has The Same Value 
            return this.Id == emp.Id &&
                this.Name == emp.Name &&
                this.salary == emp.salary &&
                this.Department == emp.Department;

        }
        public static bool operator ==(Employee lhs, Employee rhs) => lhs.Equals(rhs);
        public static bool operator !=(Employee lhs, Employee rhs) => !lhs.Equals(rhs);

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Id.GetHashCode();
            hash = (hash * 7) + salary.GetHashCode();
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + Department.GetHashCode();

            return hash;
        }
    }

}
