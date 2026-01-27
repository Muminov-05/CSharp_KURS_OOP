using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Photo
    {
        public string ImageName { get; set; }
        public Photo(string imageName)
        {
            ImageName = imageName;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Фото с именем {ImageName} был загружён .");
        }
    }
}
