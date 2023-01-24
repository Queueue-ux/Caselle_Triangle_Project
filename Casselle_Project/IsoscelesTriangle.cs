using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing.IndexedProperties;
using System.Text;
using System.Threading.Tasks;

namespace Casselle_Project
{
    internal class IsoscelesTriangle : SideTriangle
    {
        public IsoscelesTriangle() {
            this.Name = "Isosceles";
        }
        public override bool validate(double sideA, double sideB, double sideC)
        {
            bool[] sides = { sideA == sideB, sideA == sideC, sideC == sideB };
            return sides.Where(c => c).Count() == 1; // can only have exactly 1 pair of equal sides
        }
    }
}
