using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
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
            ResizeMode = ResizeMode.CanMinimize;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ShowAnimation();
            ShowGDJYAnimation();
        }

        /// <summary>
        /// 展示功德
        /// </summary>
        private void ShowGD()
        {
            Gd_Number.Content = NowGd;
        }

        /// <summary>
        /// 播放敲击声 dududu
        /// </summary>
        private static void PlayDuDuDU()
        {
            var soundPlayer = new SoundPlayer($"{Environment.CurrentDirectory}/mp3/du.mp3");
            soundPlayer.Play();
        }

        /// <summary>
        /// 木鱼敲击动画
        /// </summary>
        private void ShowAnimation()
        {
            var isShow = false;

            if (!isShow)
            {
                isShow = true;
                var sb = new Storyboard();
                var anima = new DoubleAnimation()
                {
                    By = -30,
                    Duration = TimeSpan.FromMilliseconds(70),
                    AutoReverse = true,
                };

                Storyboard.SetTarget(anima, MuYu);
                Storyboard.SetTargetProperty(anima, new PropertyPath("Width"));
                Storyboard.SetTargetProperty(anima, new PropertyPath("Height"));
                sb.Children.Add(anima);
                sb.Begin();

                NowGd++;
                PlayDuDuDU();
                ShowGD();
                isShow = false;
            }


        }

        /// <summary>
        /// 功德加一动画
        /// </summary>
        private void ShowGDJYAnimation()
        {

            var sb = new Storyboard();
            var marginAnim = new ThicknessAnimation()
            {
                From = new Thickness(690, 142, 0, 0),
                To = new Thickness(690, 82, 0, 0),
                Duration = TimeSpan.FromMilliseconds(300),
            };

            var opaAnima = new DoubleAnimation()
            {
                From = 1,
                To = 0,
                Duration = TimeSpan.FromMilliseconds(300),
            };
            Storyboard.SetTarget(marginAnim, LBL_GDJY);
            Storyboard.SetTarget(opaAnima, LBL_GDJY);

            Storyboard.SetTargetProperty(marginAnim, new PropertyPath("Margin"));
            Storyboard.SetTargetProperty(opaAnima, new PropertyPath("Opacity"));

            sb.Children.Add(marginAnim);
            sb.Children.Add(opaAnima);

            sb.Begin();

        }
    }

}
