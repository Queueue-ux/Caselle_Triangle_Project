using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Casselle_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            //DataContext="{Binding RelativeSource={RelativeSource Self}}"
            InitializeComponent();
        }
        private bool ValidateInput(string input)
        {
            // input must be integers only
            if (input == "")
            {
                return true;
            }
            double i = 0;
            return double.TryParse(input, out i);
        }
        private void ErrorOutput(string message)
        {
            output.Foreground = new SolidColorBrush(Colors.Red);
            output.Content = message;
        }
        private void Output(string message)
        {
            output.Foreground = new SolidColorBrush(Colors.Black);
            output.Content = message;
        }
        private void InputReceived(object sender, TextChangedEventArgs e)
        {
            string aInputText = aInput.Text;
            string bInputText = bInput.Text;
            string cInputText = cInput.Text;
            if (!ValidateInput(aInputText) || !ValidateInput(bInputText) || !ValidateInput(cInputText))
            {
                ErrorOutput($"Invalid Input");
                return;
            }
            else
            {
                Output(""); // clear error output if user has fixed errors
            }
            if (aInputText == "" || bInputText == "" || cInputText =="")
            {
                return;
            }
            string angleType = "";
            string sideType = "";
            
            double a = double.Parse(aInputText);
            double b = double.Parse(bInputText);
            double c = double.Parse(cInputText);

            // check if it's valid
            if (!((a + b) > c && (a + c) > b && (b + c) > a))
            {
                ErrorOutput($"These side lengths do not produce a valid triangle");
                return;
            }
            var angles = ValidateTriangle.GetAngles(a, b, c);
            double aAngle = angles.Item1;
            double bAngle = angles.Item2;
            double cAngle = angles.Item3;
            

            sideType = ValidateTriangle.GetSideType(a,b,c).ToLower();
            angleType = ValidateTriangle.GetAngleType(aAngle, bAngle, cAngle).ToLower();
            if(sideType == null || angleType == null)
            {
                ErrorOutput($"These side lengths do not produce a valid triangle");
                return;
            }

            Output($"These side lengths produce a valid {angleType} {sideType} triangle\nangle measurements: {aAngle:.##} {bAngle:.##} {cAngle:.##}");
        }
    }
    
}
