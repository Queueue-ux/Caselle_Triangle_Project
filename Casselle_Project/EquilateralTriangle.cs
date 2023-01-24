using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casselle_Project
{
    internal class EquilateralTriangle : SideTriangle
    {
        public EquilateralTriangle() {
            this.Name = "Equilateral";
        }
        public override bool validate(double sideA, double sideB, double sideC)
        {
            return sideA == sideB && sideA == sideC && sideC == sideB;
        }
    }
}
