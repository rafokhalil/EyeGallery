using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGalery
{
    public class Image
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
          private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private DateTime publichDate;

        public DateTime PublishDate
        {
            get { return publichDate; }
            set { publichDate = value; }
        }

        private string imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
        private string detals;

        public string Detals
        {
            get { return detals; }
            set { detals = value; }
        }




    }
}
