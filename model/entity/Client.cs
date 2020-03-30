using System.ComponentModel.DataAnnotations;

namespace trpz_labs.model.entity
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Ticket Ticket { get; set; }
    }
}