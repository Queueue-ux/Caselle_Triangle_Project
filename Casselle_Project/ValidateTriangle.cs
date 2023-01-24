using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Casselle_Project
{
    public class ValidateTriangle
    {
        public static (double, double, double) GetAngles(double a, double b, double c)
        {
            double aAngle = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)) * (180 / Math.PI);
            double bAngle = Math.Acos((Math.Pow(c, 2) + Math.Pow(a, 2) - Math.Pow(b, 2)) / (2 * c * a)) * (180 / Math.PI);
            double cAngle = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)) * (180 / Math.PI);
            aAngle = Math.Round(aAngle,4);
            bAngle = Math.Round(bAngle, 4);
            cAngle = Math.Round(cAngle, 4);
            return (aAngle, bAngle, cAngle);
        }
        public static string GetSideType(double a, double b, double c)
        {
            List<SideTriangle> sideList = new List<SideTriangle>();

            sideList.Add(new ScaleneTriangle());
            sideList.Add(new IsoscelesTriangle());
            sideList.Add(new EquilateralTriangle());

            foreach (SideTriangle angle in sideList)
            {
                if (angle.validate(a, b, c))
                {
                    return angle.Name;
                }
            }
            return null; // no angle could validate
        }
        public static string GetAngleType(double a, double b, double c)
        {
            List<AngleTriangle> angleList = new List<AngleTriangle>();
            angleList.Add(new AcuteTriangle());
            angleList.Add(new ObtuseTriangle());
            angleList.Add(new RightTriangle());

            foreach (AngleTriangle angle in angleList)
            {
                if (angle.validate(a, b, c))
                {
                    return angle.Name;
                }
            }
            return null; // no angle could validate
        }
    }
}
