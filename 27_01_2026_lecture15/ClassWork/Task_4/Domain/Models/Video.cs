using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Video : Publication
    {
        public string VideoName { get; set; }
        public int Prod { get ; set; }
        public Video(string videoName, int prod )
        {
            VideoName = videoName;
            Prod = prod;
        }
        public override void Publish()
        {
            Console.WriteLine($" Видео с именем {VideoName} c длителностью {Prod} секунд был опубликован.");
        }
    }
}
