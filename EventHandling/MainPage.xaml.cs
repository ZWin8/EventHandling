using System;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace EventHandling
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // Dynamically add event handler to event.
            TxtBlck2.Tapped += TxtBlock2_Tapped;
            NextPage.Tapped += NavigateMe;
        }

        private void NavigateMe(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RoutedEvent));
        }
        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //this.FontSize = 20; has NO effect.
            // 1. Refer to the caller by sender.
            (sender as TextBlock).FontSize = 40;
            // 2. Refer to the caller by e.
            (e.OriginalSource as TextBlock).FontFamily = new FontFamily("Old English Text MT");


            byte[] rgb = new byte[3];
            Random ran = new Random();
            ran.NextBytes(rgb);
            Color c = Color.FromArgb(255, rgb[0], rgb[1], rgb[2]);
            (sender as TextBlock).Foreground = new SolidColorBrush(c);
            (sender as TextBlock).Text = "You have tapped me!\nEvent args is " + e.ToString() ;
        }

        // By the way, you can get the position of the tapped point.
        private void TxtBlock2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Point p = e.GetPosition(sender as TextBlock);
            string s = "This event handler is dynamically connected in code!\n";
            s += "The position you tapped related to Textblock is \n( " + p.X + " , " + p.Y + " )";

            (sender as TextBlock).FontSize = 30;
            (sender as TextBlock).Text = s;
        }
    }
}
