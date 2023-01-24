using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casselle_Project
{
    internal class AcuteTriangle : AngleTriangle
    {
        public AcuteTriangle() {
            this.Name = "Acute";
        }
        public override bool validate(double angleA, double angleB, double angleC)
        {
            return angleA < 90 && angleB < 90 && angleC < 90;
        }
    }
}
