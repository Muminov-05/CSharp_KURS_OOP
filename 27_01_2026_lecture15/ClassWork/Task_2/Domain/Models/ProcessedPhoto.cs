using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProcessedPhoto : Photo
    {
        public string Filter { get; set; }
        public ProcessedPhoto(string imageName,string filter) : base(imageName)
        {
            Filter = filter;
        }
        public override void Display()
        {
            Console.WriteLine($"Файл с именем {ImageName} был загружён с филтром {Filter}.");
        }
    }
}
