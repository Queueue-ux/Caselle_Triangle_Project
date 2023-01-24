using Casselle_Project;
using System.Windows.Navigation;

namespace TriangleTests
{
    [TestClass]
    public class TestTriangle
    {
        private bool validate(double a, double b, double c, string expectedAngle, string expectedSide)
        {
            string sideName = ValidateTriangle.GetSideType(a,b,c);
            var angles = ValidateTriangle.GetAngles(a,b,c);
            string angleName = ValidateTriangle.GetAngleType(angles.Item1, angles.Item2, angles.Item3);
            return sideName == expectedSide && angleName == expectedAngle;
        }
        [TestMethod]
        public void TestSideAngleValidation()
        {
            Assert.AreEqual(validate(10, 11, 12, "Acute", "Scalene"), true);
            Assert.AreEqual(validate(10, 10, 10, "Acute", "Equilateral"), true);
            Assert.AreEqual(validate(10, 12, 12, "Acute", "Isosceles"), true);
            Assert.AreEqual(validate(2,3,4,"Obtuse", "Scalene"), true);
            Assert.AreEqual(validate(4, 4, 7, "Obtuse", "Isosceles"), true);
            Assert.AreEqual(validate(19.79899, 14, 14, "Right", "Isosceles"), true);
            Assert.AreEqual(validate(16.16581, 14, 8.0829, "Right", "Scalene"), true);
        }
    }
}