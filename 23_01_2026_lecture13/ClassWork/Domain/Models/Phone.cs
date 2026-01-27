
namespace Domain.Models
{
    public class Phone : Product
    {
        public string BrandPhone { get; set; }
        public string MemoryPhone { get; set; }

        public Phone(string name, int price, string brandPhone, string memoryPhone)
            : base(name, price)
        {
            BrandPhone = brandPhone; 
            MemoryPhone = memoryPhone;
        }
    }
}