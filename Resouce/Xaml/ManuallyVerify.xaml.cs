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
using System.Windows.Shapes;

namespace Tomra_Test_System
{
    /// <summary>
    /// Interaction logic for ManuallyVerify.xaml
    /// </summary>
    public partial class ManuallyVerify : Window
    {

        private static ManuallyVerify mMV = null;

        public void mManuallyVerify()
        {
            InitializeComponent();
            BitmapImage Image = new BitmapImage(new Uri(App.AppPath + "\\image\\"+ ImageName + ".png"));
            IRef.Source = Image;
        }

        private void BtnPass_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }

        private void BtnFail_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        public static ManuallyVerify MVWindow()
        {
            if (mMV == null)
            {
                mMV = new ManuallyVerify();
            }
            return mMV;
        }



    }
}
