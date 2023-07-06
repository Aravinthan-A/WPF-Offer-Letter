using System;
using System.Collections.Generic;
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
using System.Xml.Linq;

namespace String_Offer_letter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                String Before = "";
                String Adress= txtadress.Text;
                String After = $"This is delighted to offer you the full-time position of MANAGER with an anticipated start date of{txtdate.Text}contingent upon background check. \r\n \r\nAs the MANAGER, you will be responsible for the company management.You will report directly to supervisor  at Company.\r\n \r\n Working hours are from 09:00Am-04:00Pm.The starting salary for this position is '500000' per year. Payment is on a monthl basis\r\n \r\n by direct deposit. In addition, you will be eligible to receive discuss additional compensation potential.[amazon] offers a comprehensive\r\n \r\n benefits program, which includes medical insurance.Your employment with amazon will be on an at-will basis, which means you and\r\n \r\n the company are free to terminate employment at any time, with or without cause or advance notice. This letter is not a contract indicating\r\n \r\n employment terms or duration.Please confirm your acceptance of this offer by signing and returning this letter by 15-01-2023.\r\n \r\n Sincerlly;\r\n Hunamn Resource.";
                Before = $"Dear {txtname.Text}";



                Offer oOffer = new Offer();
                oOffer.lblsend.Content = Adress;
                oOffer.lblwith.Content = Before;
                oOffer.lblshow.Content = After;
                oOffer.Show();
            }
        }
    }

