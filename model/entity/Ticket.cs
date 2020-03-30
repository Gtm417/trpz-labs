using System.ComponentModel.DataAnnotations;

namespace trpz_labs.model.entity
{
    public class Ticket
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public long Price { get; set; }

        public int Discount { get; set; }

        //public Ticket(string name, long price, int discount)
        //{
        //    Name = name;
        //    Price = price;
        //    Discount = discount;
        //}
    }
}