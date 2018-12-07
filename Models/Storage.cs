using System;
namespace Vanguard.Models
{
    public class Storage
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public bool Availibility { get; set; }
        public string Address { get; set; }

        public Storage()
        {
        }
    }
}
