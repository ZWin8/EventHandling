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



namespace EventHandling
{
    public sealed partial class AddHandlerProperty : Page
    {
        public AddHandlerProperty()
        {
            this.InitializeComponent();
            this.AddHandler(UIElement.TappedEvent, new TappedEventHandler(PageTapped), true);
        }

        private void PageTapped(object sender, TappedRoutedEventArgs e)
        {
            (this.Content as Grid).Background = BothChanged.ChangeColor();
        }
            
        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            TextBlock txtBlk = sender as TextBlock;
            txtBlk.Text = "Color changed and Text changed if set to true!";
            e.Handled = true;
        }
    }
}
