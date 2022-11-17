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

namespace ElectronicWoodfish
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitWindows();
        }
        public int NowGd = 0;
        private void InitWindows()
        {
            this.ResizeMode = ResizeMode.CanMinimize;       
        }

        private void MuYu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NowGd++;
            ShowGD();
        }

        private void ShowGD()
        {
            Gd_Number.Content = NowGd;
        }
    }
    
}
