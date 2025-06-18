namespace OpenClose_example
{
    public class ClientVIP: Client
    {
        public ClientVIP(string fullname, int cost)
        {
            Name = fullname;
            Value = cost;
        }

       public override decimal CalculateDiscount()
         {
            decimal discount = Value * 0.1m;
            return discount;
        }
    }
}