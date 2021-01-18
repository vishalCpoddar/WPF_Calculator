using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Decimal? lastValueEntered;
        private Decimal currentValueEntered;
        private string arithmaticOperation;
        private Decimal? temp;
        private bool isFraction;
        private int decimalPlaces;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            lastValueEntered = null;
            currentValueEntered = 0;
            arithmaticOperation = "";
            decimalPlaces = 1;
            isFraction = false;
        }

        private void clickedPercentage(object sender, RoutedEventArgs e)
        {
            if (arithmaticOperation == "" && this.currentValueEntered != 0)
            {
                this.arithmaticOperation = "%";
                lastValueEntered = currentValueEntered;
                this.currentValueEntered = 0;
                isFraction = false;
                decimalPlaces = 1;
            }
            else
            {
                MessageBox.Show("Error: Arithmatic operation buffer overflow.");
            }
            this.display.Text = "%";
        }

        private void clickedClearEntry(object sender, RoutedEventArgs e)
        {
            this.currentValueEntered = 0;
            this.display.Text = "";
            isFraction = false;
            decimalPlaces /= 10;
        }

        private void clickedClear(object sender, RoutedEventArgs e)
        {
            this.currentValueEntered = 0;
            this.lastValueEntered = null;
            this.arithmaticOperation = "";
            this.display.Text = "";
            this.temp = null;
            isFraction = false;
            decimalPlaces = 1;
        }

        private void clickedBackSpace(object sender, RoutedEventArgs e)
        {
            if (isFraction)
            {
                //this.currentValueEntered = (this.currentValueEntered - (this.currentValueEntered % 10)) / 10;
                string inputTemp = currentValueEntered.ToString();
                inputTemp = inputTemp.Substring(0, inputTemp.Length - 1);
                currentValueEntered = Decimal.Parse(inputTemp);
                decimalPlaces /= 10;
            }
            else
            {
                this.currentValueEntered = (this.currentValueEntered - (this.currentValueEntered % 10)) / 10;
            }
            
            this.display.Text = this.currentValueEntered.ToString();
        }

        private void clickedOneByX(object sender, RoutedEventArgs e)
        {
            if (temp != null)
            {
                lastValueEntered = temp;
            }
            else
            {
                lastValueEntered = currentValueEntered;
            }
            if (lastValueEntered != null)
            {
                temp = 1 / lastValueEntered;
                decimalPlaces = 1;
                this.display.Text = temp.ToString();
            }
        }

        private void clickedSquare(object sender, RoutedEventArgs e)
        {
            if(temp != null)
            {
                lastValueEntered = temp;
            }
            else
            {
                lastValueEntered = currentValueEntered;
            }
            if (lastValueEntered != null)
            {
                temp = lastValueEntered * lastValueEntered;
                decimalPlaces = 1;
                this.display.Text = temp.ToString();
            }
        }

        private void clickedRoot(object sender, RoutedEventArgs e)
        {
            if (temp != null)
            {
                lastValueEntered = temp;
            }
            else
            {
                lastValueEntered = currentValueEntered;
            }
            if (lastValueEntered != null)
            {
                temp =Decimal.Parse(Math.Sqrt(Decimal.ToDouble(lastValueEntered.Value)).ToString());
                decimalPlaces = 1;
                this.display.Text = temp.ToString();
            }
        }

        private void clickedDivide(object sender, RoutedEventArgs e)
        {
            if (arithmaticOperation == "" && this.currentValueEntered != 0)
            {
                this.arithmaticOperation = "/";
                lastValueEntered = currentValueEntered;
                this.currentValueEntered = 0;
                isFraction = false;
                decimalPlaces = 1;
            }
            else
            {
                MessageBox.Show("Error: Arithmatic operation buffer overflow.");
            }
            this.display.Text = "/";
        }

        private void clickedSeven(object sender, RoutedEventArgs e)
        {
            if (isFraction)
            {
                currentValueEntered = currentValueEntered + 0.7M/decimalPlaces;
                decimalPlaces *= 10;
            }
            else
            {
                currentValueEntered = currentValueEntered * 10 + 7;
            }
            this.display.Text = currentValueEntered.ToString();
        }

        private void clickedEight(object sender, RoutedEventArgs e)
        {
            if (isFraction)
            {
                currentValueEntered = currentValueEntered + 0.8M / decimalPlaces;
                decimalPlaces *= 10;
            }
            else
            {
                currentValueEntered = currentValueEntered * 10 + 8;
            }
            this.display.Text = currentValueEntered.ToString();
        }

        private void clickedNine(object sender, RoutedEventArgs e)
        {
            if (isFraction)
            {
                currentValueEntered = currentValueEntered + 0.9M / decimalPlaces;
                decimalPlaces *= 10;
            }
            else
            {
                currentValueEntered = currentValueEntered * 10 + 9;
            }
            this.display.Text = currentValueEntered.ToString();
        }

        private void clickedMultiply(object sender, RoutedEventArgs e)
        {
            if (arithmaticOperation == "" && this.currentValueEntered != 0)
            {
                this.arithmaticOperation = "X";
                lastValueEntered = currentValueEntered;
                this.currentValueEntered = 0;
                isFraction = false;
                decimalPlaces = 1;
            }
            else
            {
                MessageBox.Show("Error: Arithmatic operation buffer overflow.");
            }
            this.display.Text = "X";
        }

        private void clickedFour(object sender, RoutedEventArgs e)
        {
            if (isFraction)
            {
                currentValueEntered = currentValueEntered + 0.4M / decimalPlaces;
                decimalPlaces *= 10;
            }
            else
            {
                currentValueEntered = currentValueEntered * 10 + 4;
            }
            this.display.Text = currentValueEntered.ToString();
        }

        private void clickedFive(object sender, RoutedEventArgs e)
        {
            if (isFraction)
            {
                currentValueEntered = currentValueEntered + 0.5M / decimalPlaces;
                decimalPlaces *= 10;
            }
            else
            {
                currentValueEntered = currentValueEntered * 10 + 5;
            }
            this.display.Text = currentValueEntered.ToString();
        }

        private void clickedSix(object sender, RoutedEventArgs e)
        {
            if (isFraction)
            {
                currentValueEntered = currentValueEntered + 0.6M / decimalPlaces;
                decimalPlaces *= 10;
            }
            else
            {
                currentValueEntered = currentValueEntered * 10 + 6;
            }
            this.display.Text = currentValueEntered.ToString();
        }

        private void clickedMinus(object sender, RoutedEventArgs e)
        {
            if (arithmaticOperation == "" && this.currentValueEntered != 0)
            {
                this.arithmaticOperation = "-";
                lastValueEntered = currentValueEntered;
                this.currentValueEntered = 0;
                isFraction = false;
                decimalPlaces = 1;
            }
            else
            {
                MessageBox.Show("Error: Arithmatic operation buffer overflow.");
            }
            this.display.Text = "-";
        }

        private void clickedOne(object sender, RoutedEventArgs e)
        {
            if (isFraction)
            {
                currentValueEntered = currentValueEntered + 0.1M / decimalPlaces;
                decimalPlaces *= 10;
            }
            else
            {
                currentValueEntered = currentValueEntered * 10 + 1;
            }
            this.display.Text = currentValueEntered.ToString();
        }

        private void clickedTwo(object sender, RoutedEventArgs e)
        {
            if (isFraction)
            {
                currentValueEntered = currentValueEntered + 0.2M / decimalPlaces;
                decimalPlaces *= 10;
            }
            else
            {
                currentValueEntered = currentValueEntered * 10 + 2;
            }
            this.display.Text = currentValueEntered.ToString();

        }

        private void clickedThree(object sender, RoutedEventArgs e)
        {
            if (isFraction)
            {
                currentValueEntered = currentValueEntered + 0.3M / decimalPlaces;
                decimalPlaces *= 10;
            }
            else
            {
                currentValueEntered = currentValueEntered * 10 + 3;
            }
            this.display.Text = currentValueEntered.ToString();
        }

        private void clickedPlus(object sender, RoutedEventArgs e)
        {
            if (arithmaticOperation == "" && this.currentValueEntered != 0)
            {
                this.arithmaticOperation = "+";
                lastValueEntered = currentValueEntered;
                this.currentValueEntered = 0;
                isFraction = false;
                decimalPlaces = 1;
            }
            else
            {
                MessageBox.Show("Error: Arithmatic operation buffer overflow.");
            }
            this.display.Text = "+";
        }

        private void clickedPlusMinus(object sender, RoutedEventArgs e)
        {
            this.currentValueEntered = this.currentValueEntered * (-1);
            this.display.Text = this.currentValueEntered.ToString();
        }

        private void clickedZero(object sender, RoutedEventArgs e)
        {
            if (isFraction)
            {
                currentValueEntered = currentValueEntered + 0.0M / decimalPlaces;
                decimalPlaces *= 10;
            }
            else
            {
                currentValueEntered = currentValueEntered * 10;
            }
            this.display.Text = currentValueEntered.ToString();
        }

        private void clickedDot(object sender, RoutedEventArgs e)
        {
            // Implement later
            //MessageBox.Show("Info: Not implemented in this version.");
            isFraction = true;
            decimalPlaces = 1;
            this.display.Text = currentValueEntered.ToString() + ".";
        }

        private void clickedEquals(object sender, RoutedEventArgs e)
        {
            if (this.arithmaticOperation != "")
            {
                calculate();
            }
            else
            {
                this.display.Text = this.currentValueEntered.ToString();
            }
        }

        private void calculate()
        {
            if (this.arithmaticOperation != "")
            {
                if(temp != null)
                {
                    this.lastValueEntered = temp;
                }

                switch (this.arithmaticOperation)
                {
                    case "+":
                        this.temp = this.lastValueEntered + this.currentValueEntered;
                        this.display.Text = temp.ToString();
                        this.arithmaticOperation = "";
                        break;
                    case "-":
                        temp = this.lastValueEntered - this.currentValueEntered;
                        this.display.Text = temp.ToString();
                        this.arithmaticOperation = "";
                        break;
                    case "X":
                        temp = this.lastValueEntered * this.currentValueEntered;
                        this.display.Text = temp.ToString();
                        this.arithmaticOperation = "";
                        break;
                    case "/":
                        if (this.currentValueEntered != 0)
                        {
                            temp = this.lastValueEntered / this.currentValueEntered;
                            this.display.Text = temp.ToString();
                            this.arithmaticOperation = "";
                        }
                        else
                        {
                            MessageBox.Show("Arithmatic Exeception");
                        }
                        break;
                    case "%":
                        if (this.currentValueEntered != 0 || this.lastValueEntered != 0)
                        {
                            temp = (this.currentValueEntered / this.lastValueEntered);
                            this.display.Text = temp.ToString();
                            this.arithmaticOperation = "";
                        }
                        else
                        {
                            MessageBox.Show("Arithmatic Exeception");
                        }
                        break;
                    default:
                        MessageBox.Show("Arithmatic operation error occurred.");
                        break;
                }
            }
        }

    }
}
