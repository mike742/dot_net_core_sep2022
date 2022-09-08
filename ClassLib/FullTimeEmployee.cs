namespace Team_B
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string position) : base(position) {}

        public override void PrintFullName()
        {
            base.PrintFullName();
            Console.WriteLine(" is a full time employee");
        }
    }
}
