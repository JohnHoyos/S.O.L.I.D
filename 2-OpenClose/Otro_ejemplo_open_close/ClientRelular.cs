namespace OpenClose_example
{
    public class ClientRegular: Client
    {
        public ClientRegular(string fullname, int cost)
        {
            Name = fullname;
            Value = cost;
        }

       public override decimal CalculateDiscount()
         {
            decimal discount = Value * 0.5m;
            return discount;
        }
    }
}