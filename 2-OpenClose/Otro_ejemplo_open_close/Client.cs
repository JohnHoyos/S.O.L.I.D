namespace OpenClose_example
{
    public abstract class Client
    {
        public string? Name { get; set; }       
        public int Value { get; set; }
        public abstract decimal CalculateDiscount();
        
    }
}