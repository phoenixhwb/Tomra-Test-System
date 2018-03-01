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
using System.Data;
using System.IO;

namespace Tomra_Test_System
{
    /// <summary>
    /// Interaction logic for ProductSelect.xaml
    /// </summary>
    public partial class ProductSelect : Window
    {
        private string ProgramPath = "D:\\TomraTest\\";   //程序路径

        private static ProductSelect mPS;                   
        
        public static string ProductSelected;   
        public static DataTable ProductConfig;
        public static bool Ischange;
                                
        public ProductSelect()
        {
            InitializeComponent();
            Initial(); 
            
        }

        
        
        //读取程序路径下的产品文件夹，并添加到列表
        private void Initial()
        {
            string[] dirs = Directory.GetDirectories(ProgramPath, "*", SearchOption.AllDirectories);
            foreach (string dir in dirs)
            {
                TextBlock Tb = new TextBlock();
                string TbName = dir.Replace(ProgramPath, "");
                Tb.Name = TbName;
                Tb.Text = TbName;
                LbProduct.Items.Add(Tb);
            }
        }


        //OK按钮事件：读取选择Product文件下的Config文件
        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            TextBlock Tb = LbProduct.SelectedItem as TextBlock;
            if (LbProduct.SelectedItem != null)
            {
                if (ProductSelected != Tb.Name)
                {
                    try
                    {
                        ProductConfig = CSV.OpenCSV(ProgramPath + Tb.Name + "\\config.csv");
                        ProductSelected = Tb.Name;
                        Ischange = true;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    this.Close();
            }
            else
                MessageBox.Show("Please select Product!!");
        }


        //判断是否需要实例化新窗口
        public static ProductSelect PSWindow()
        {
            if (mPS == null)
            {
                mPS = new ProductSelect();
            }
            return mPS;
        }
        private void ProductSelectClose(object sender,System.EventArgs e)
        {
            mPS = null;
        }
    }
}
