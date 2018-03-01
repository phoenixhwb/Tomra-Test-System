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
using Microsoft.Office.Interop;
using System.Data;

namespace Tomra_Test_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string ModuleName = null;

        private DataTable ModuleConfig = new DataTable();

        ManuallyVerify MV = new ManuallyVerify();
        
        public MainWindow()
        {
            InitializeComponent();
            //Initial();
            MV.ShowDialog();
            Console.WriteLine(MV.DialogResult);
        }

        private void Initial()
        {
            ILogo.Source = new BitmapImage(new Uri(App.AppPath + "\\image\\TOMRA LOGO.png"));
            ModuleSelect();            
        }
        
        private void ModuleSelect()
        {
            ProductSelect.PSWindow().ShowDialog();
            if(ProductSelect.Ischange)
            {
                ModuleName = ProductSelect.ProductSelected;
                ModuleConfig = ProductSelect.ProductConfig;
                TbModuleName.Text = ModuleName;
            }
        }
        
        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {

        }





        /// <summary>
        /// 菜单按钮事件
        /// </summary>
        private void MiCom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MiModule_Click(object sender, RoutedEventArgs e)
        {
            ModuleSelect();
        }

        private void MiExit_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MiNew_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
