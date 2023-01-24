using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casselle_Project
{
    internal abstract class AngleTriangle : ITriangle
    {
        public abstract bool validate(double angleA, double angleB, double angleC);
    }
}
