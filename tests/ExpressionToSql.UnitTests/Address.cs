namespace ExpressionToSql.UnitTests
{
    public class Address
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
    }

    public class DeliveryAddress : Address
    {
        public string DeliveryName { get; set; }
    }
}