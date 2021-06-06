namespace M06L07MethodOverridingDemo
{
    public class CommissionEmployeeModel : EmployeeModel
    {
        public decimal CommisionAmount { get; set; }
        public override decimal GetPaycheckAmount(int hoursWorked)
        {
            decimal initialPay =  base.GetPaycheckAmount(hoursWorked);
            return initialPay + CommisionAmount;
        }
    }
}
