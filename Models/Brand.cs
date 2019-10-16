using ShoeStore.Interfaces;

namespace ShoeStore.Models
{
    public class Brand : IBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}