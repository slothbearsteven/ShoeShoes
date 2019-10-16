using System.ComponentModel.DataAnnotations;
using ShoeStore.Interfaces;

namespace ShoeStore.Models
{
    public class Shoe : IShoe
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Size { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
    }
}