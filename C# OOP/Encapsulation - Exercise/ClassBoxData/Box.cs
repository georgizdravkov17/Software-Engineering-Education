using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData
{
   public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght,double width,double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Lenght
        {
            get
            {
                return this.lenght;
            }
            private set
            {
                ValidateSide(value);

                this.lenght = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
           private set
            {
                ValidateSide(value);

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                ValidateSide(value);

                this.height = value;
            }
        }


        private void ValidateSide(double side)
        {
            if(side <= 0)
            {
                throw new ArgumentException("Side must me positive number!");
            }
        }

        public double SurfaceArea()
        {
            var result = (2 * (this.Height * this.Lenght)) + (2 * (this.Width * this.Lenght)) + 
                (2 * (this.Height * this.Width));
            return result;
        }

        public double Volume()
        {
            var result = this.Width * this.Height * this.Lenght;
            return result;
        }

        public double LateralSurfaceArea()
        {
            var result = (2*(this.Height * this.Lenght)) + (2 * (this.Width * this.Height));
            return result;
        }

    }
}
