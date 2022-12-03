using Microsoft.Win32;
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

namespace VisualMkLink
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private String GetFolder()
        {
            OpenFileDialog dlg = new OpenFileDialog();

            bool? Result = dlg.ShowDialog();

            if (Result.GetValueOrDefault(false))
            {
                return dlg.FileName;
            }

            return "";
        }


        private void LinkOpenButton_Click(object sender, RoutedEventArgs e)
        {
            String Folder = GetFolder();
            
            if (Folder.Count() != 0)
            {
                LinkText.Text = Folder;
            }
        }

        private void TargetOpenButton_Click(object sender, RoutedEventArgs e)
        {
            String Folder = GetFolder();

            if (Folder.Count() != 0)
            {
                TargetText.Text = Folder;
            }
        }
    }
}
