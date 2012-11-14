using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

// This page demonstrate how to override a virtual event handler in the Control:Page class.
namespace EventHandling
{
    public sealed partial class PageEvent : Page
    {
        public PageEvent()
        {
            this.InitializeComponent();
        }

        protected override void OnTapped(TappedRoutedEventArgs e)
        {
            if (e.OriginalSource is TextBlock)
            {
                (e.OriginalSource as TextBlock).Text = "Help! I am tapped!!";
                // this = page.
                (this.Content as Grid).Background = new SolidColorBrush(Colors.DarkKhaki);
            }
        }
        protected override void OnDoubleTapped(DoubleTappedRoutedEventArgs e)
        {
            //Window.Current.Close(); This is not allowed.
            App.Current.Exit(); // This will not close the app. If you want to sell the app, you can not close an app.
        }
    }
}
