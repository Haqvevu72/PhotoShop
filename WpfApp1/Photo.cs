using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Photo
    {
        public Photo(string? image)
        {
            Image = image;
        }

        public string? Image { get; set; }
    }
}
