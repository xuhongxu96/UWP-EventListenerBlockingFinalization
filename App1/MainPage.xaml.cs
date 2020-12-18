using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Nav1(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(Page1));
            UpdatePageCt();
        }

        private void Nav2(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(Page2));
            UpdatePageCt();
        }

        private void GC_Click(object sender, RoutedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            UpdatePageCt();
        }

        private void UpdatePageCt()
        {
            txt.Text = $"{Global.Page1Ct} {Global.Page2Ct}";
        }
    }
}
