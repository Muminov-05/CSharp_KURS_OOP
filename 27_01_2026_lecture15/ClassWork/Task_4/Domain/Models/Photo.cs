using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Photo : Publication
    {
        public string PhotoName { get; set; }
        public Photo(string photoName)
        {
            PhotoName = photoName;
        }
        public override void Publish()
        {
            Console.WriteLine($" Фото с именем {PhotoName} был опубликован.");
        }
    }
}
