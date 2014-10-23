using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DBUtility;

namespace ERPWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            
        }

        private void image3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void image2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }


        private void txt1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txt1.Text == "请输入用户名")
            {
                txt1.Text = "";
            }
        }

        private void txt2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txt2.Password == "请输入密码")
            {
                txt2.Password = "";
            }
        }

        private void txt1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txt1.Text == "")
            {
                txt1.Text = "请输入用户名";
            }
        }

        private void txt2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txt2.Password == "")
            {
                txt2.Password = "请输入密码";
            }
        }

        private void border_MouseUp(object sender, MouseButtonEventArgs e)
        {
                      
        }
        



    }
}
