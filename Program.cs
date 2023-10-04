using System;
using System.Security.AccessControl;

namespace Shape
{
    public abstract class ThreeDShape
    {
        private readonly string type; // Cone, Sphere

        protected ThreeDShape(string type)
        {
            this.type = type;
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        public abstract double CalcVolume();

        public override string ToString()
        {
            return $"A {type} shape";
        }
    }

    // Subclass
    public class Sphere : ThreeDShape // a Sphere is a ThreeDShape
    {
        private double radius;

        // Constructors
        public Sphere(double radius) : base("Sphere")
        {
            Radius = radius;
        }

        public Sphere() : this(0)
        {
        }

        // Read-write property of radius
        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius must be non-negative");
                }
            }
        }

        public override double CalcVolume()
        {
           double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
           return Math.Round(volume, 2);
        }

        public override string ToString()
        {
            return base.ToString() + " of radius: " + radius.ToString();
        }
    }

    public class Cone : ThreeDShape
    {
        private double radius;
        private double height;

        public Cone(double radius, double height) : base("Cone")
        {
            this.Radius = radius;
            this.Height = height; // Use the property setter for height
        }

        public Cone() : this(0, 0) { }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius cannot be a negative number");
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value >= 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be a negative number");
                }
            }
        }

        public override double CalcVolume()
        {
            double volume = (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height; // Corrected the volume formula
            return Math.Round(volume, 2);

        }

        public override string ToString()
        {
            return base.ToString() + " of height " + height.ToString() + " and radius: " + radius.ToString();
        }
    }

    public class Cylinder : ThreeDShape
    {
        private double radius;
        private double height;

        public Cylinder (double radius, double height) : base("Cylinder")
        {
            this.radius = radius;
            this.height = height;
        }

        public Cylinder() : this(0, 0) { }

        public double Radius
        {
            get { return radius; }

            set { 
                 if(value >= 0)
                    {
                        radius = value;
                    } 
                 if(value < 0)
                    {
                    throw new ArgumentException("Radius cannot be negative number");
                 }
            }
        }

        public double Height
        {
            get { return height; }

            set
            {
                if(value >= 0)
                {
                    height = value;
                }
                if(value < 0)
                {
                    throw new ArgumentException("Height cannot be negative number");
                }
            }
        }

        public override double CalcVolume()
        {
            double volume = (Math.PI * Math.Pow(radius, 2)) * height;
            return Math.Round(volume, 2);
        }

        public override string ToString()
        {
            return base.ToString() + " of height " + height.ToString() + " and radius of " + radius.ToString();
        }


    }

    public class Cube : ThreeDShape
    {
        private double length;

        public Cube(double length) : base("Cube")
        {
            this.length = length;
        }

        public Cube() : this(0) { }

        public double Length
        {
            get { return length; }

            set
            {
                if(value >= 0)
                {
                    length = value;
                }
                if (value < 0)
                {
                    throw new ArithmeticException("Length cannot be negative number");
                }
            }
        }

   

        public override double CalcVolume()
        {
            double sideArea = 6 * Math.Pow(length, 2);
            double volume = Math.Pow(sideArea, 3);
            return Math.Round(volume, 2);
        }

        public override string ToString()
        {
            return base.ToString() + " of length " + length.ToString();
        }


    }

    public class RectangularPrism : ThreeDShape
    {
        private double width;
        private double length;
        private double height;

        public RectangularPrism(double width, double length, double height) : base("Rectangular Prism")
        {
            this.width = width;
            this.length = length;
            this.height = height;
        }

        public RectangularPrism(): this(0,0,0){}

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                if(value >= 0)
                {
                    width = value;
                }
                if(value < 0)
                {
                    throw new ArithmeticException("Width cannot be negative number");
                }
            }
        }
        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                if (value >= 0)
                {
                    length = value;
                }
                if (value < 0)
                {
                    throw new ArithmeticException("Length cannot be negative number");
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value >= 0)
                {
                    height = value;
                }
                if (value < 0)
                {
                    throw new ArithmeticException("Height cannot be negative number");
                }
            }
        }

        public override double CalcVolume()
        {
            double volume = length * width * height;
            return Math.Round(volume, 2);
        }

        public override string ToString()
        {
            return base.ToString() + " of Width " + width.ToString() + " Length of " + length.ToString() + " and Height of " + height.ToString();
        }
    }

    public class Cuboid : ThreeDShape
    {
        private double length;
        private double width;
        private double height;

        public Cuboid(double length, double width, double height) : base("Cuboid")
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public Cuboid() : this(0, 0, 0) { }


        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value >= 0)
                {
                    width = value;
                }
                if (value < 0)
                {
                    throw new ArithmeticException("Width cannot be negative number");
                }
            }
        }
        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                if (value >= 0)
                {
                    length = value;
                }
                if (value < 0)
                {
                    throw new ArithmeticException("Length cannot be negative number");
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value >= 0)
                {
                    height = value;
                }
                if (value < 0)
                {
                    throw new ArithmeticException("Height cannot be negative number");
                }
            }
        }

        public override double CalcVolume()
        {
            double volume = length * width * height;
            return Math.Round(volume, 2);
        }

        public override string ToString()
        {
            return base.ToString() + " of Width " + width.ToString() + " Length of " + length.ToString() + " and Height of " + height.ToString();
        }


    }
     



    // Test class, default namespace
    static class Test
    {
        public static void Main()
        {
            // Polymorphic collection
            ThreeDShape[] collection =
            {
                new Sphere(10),
                new Cone(10,10),
                new Cylinder(10,10),
                new Cube(10),
                new RectangularPrism(10,10,10),
                new Cuboid(10,10,10)
            };

            foreach (ThreeDShape s in collection)
            {
                Console.WriteLine(s + " volume: " + s.CalcVolume());
            }
        }
    }
}
