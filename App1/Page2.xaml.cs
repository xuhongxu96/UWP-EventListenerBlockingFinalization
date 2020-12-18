using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Playback;
using Windows.System.Power;
using Windows.UI.Input;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
            Global.Page2Ct++;

            // Has Issue:
            // TestRadialController();
            // TestMediaPlayer();

            // No Issue:
            // TestPage();
            TestButton();
        }

        private void TestPage()
        {
            var a = new Page();
            a.Unloaded += A_Unloaded;
        }

        private void TestButton()
        {
            var a = new Button();
            a.Click += A_Click;
        }

        private void TestRadialController()
        {
            var a = RadialController.CreateForCurrentView();
            a.ButtonClicked += A_ButtonClicked;
        }

        private void TestMediaPlayer()
        {
            var mdp = new MediaPlayer();
            mdp.MediaOpened += Mdp_MediaOpened;
        }

        private void A_Click(object sender, RoutedEventArgs e)
        {
        }

        private void A_Unloaded(object sender, RoutedEventArgs e)
        {
        }

        private void A_ButtonClicked(RadialController sender, RadialControllerButtonClickedEventArgs args)
        {
        }

        private void Mdp_MediaOpened(MediaPlayer sender, object args)
        {
        }

        ~Page2()
        {
            Global.Page2Ct--;
        }
    }
}
