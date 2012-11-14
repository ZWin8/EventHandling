using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

// Demonstration of Routed Tapped Event Handling
namespace EventHandling
{

    public sealed partial class RoutedEvent : Page
    {
        public RoutedEvent()
        {
            this.InitializeComponent();
            NextPage.Tapped += NavigateMe;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (e.OriginalSource.GetType() == typeof(TextBlock))        // e.OriginalSource is TextBlock; is more reasonable.
            {
                // (sender as TextBlock).Text = "I am tapped!!";         sender is a Grid, but e.OriginalSource is a TextBlock !!
                (e.OriginalSource as TextBlock).Text = "I am tapped!!";
            }
        }
        // Notice this event handler overrides the above event handler.
        private void NavigateMe(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PageEvent));
        }
    }
}
