namespace trpz_labs.model.entity
{
    public class Client
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public Ticket Ticket { get; set; }

        public Client(string name, string surname, Ticket ticket)
        {
            Name = name;
            Surname = surname;
            Ticket = ticket;
        }
    }
}