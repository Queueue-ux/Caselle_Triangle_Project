using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casselle_Project
{
    internal class ScaleneTriangle : SideTriangle
    {
        public ScaleneTriangle() {
            this.Name = "Scalene";
        }
        public override bool validate(double sideA, double sideB, double sideC)
        {
            return sideA != sideB && sideA != sideC && sideC != sideB;
        }
    }
}
