using System.ComponentModel.DataAnnotations;

namespace trpz_labs.model.entity
{
    public class Plane
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public int Capacity { get; set; }

        public int CurrentCapacity { get; set; }

        //public Plane(string name, int number, int capacity, int currentCapacity)
        //{
        //    Name = name;
        //    Number = number;
        //    Capacity = capacity;
        //    CurrentCapacity = currentCapacity;
        //}
    }
}