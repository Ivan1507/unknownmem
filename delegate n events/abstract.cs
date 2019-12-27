using System;
using System.Collections.Generic;
using System.Text;

namespace delegate_n_events
{
    abstract class @abstract
    {
        public abstract float Perimeter();
      
        public abstract float Area();
    }
    class Rectangle : @abstract
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }
        // переопределение получения периметра
        public override float Perimeter()
        {
           return Width * 2 + Height *2;
        }
        // переопрелеление получения площади
        public override float Area()
        {
            return Width * Height;
        }
    }
}
