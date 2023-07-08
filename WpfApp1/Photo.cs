using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Photo
    {
        private static int id = 0;
        public int ID { get; set; }
        public Photo(string? image)
        {
            ID = ++id;
            Image = image;
        }

        public string? Image { get; set; }
    }
}
