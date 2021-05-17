// this is a namespace alias
using point2D = Namespaces.Graphics2D;
using point3D = Namespaces.Graphics3D;

// this represents a type alias
using Point2D = Namespaces.Graphics2D.Point;
using Point3D = Namespaces.Graphics3D.Point;

namespace Namespaces.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            // code using namespace alias
            point2D::Point p2D1 = new point2D::Point();
            p2D1.X = 100;
            p2D1.Y = 200;

            point3D::Point p3D1 = new point3D::Point();
            p3D1.X = 150;
            p3D1.Y = 250;
            p3D1.Z = 175;

            // code using type alias
            Point2D p2D2 = new Point2D();
            p2D2.X = 100;
            p2D2.Y = 200;

            Point3D p3D2 = new Point3D();
            p3D2.X = 150;
            p3D2.Y = 250;
            p3D2.Z = 175;

            global::Point p = new global::Point();
            p.Label = "Test";

            global::System.Console.WriteLine("Samples with namespaces and naming colisions");
        }
    }
}
