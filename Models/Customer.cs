namespace BuildsByBrickwell.Models
{
    public class Customer
    {
        public int customer_ID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set;}
        public DateOnly birth_date { get; set; }
        public string country_of_residence { get; set; }
        public char gender { get; set; }
        public float age { get; set; }

    }
}
