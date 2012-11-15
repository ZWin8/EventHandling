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


namespace EventHandling
{

    public sealed partial class BothChanged : Page
    {
        public BothChanged()
        {
            this.InitializeComponent();
            this.DoubleTapped += PageDoubleTapped;
        }

        private void PageDoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddHandlerProperty));
        }


        private void TextBlock_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            (e.OriginalSource as TextBlock).Text = "Text Changed and Color Changed!";
        }

        private void TextBlock_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            (e.OriginalSource as TextBlock).Text = "Text Changed but Color NOT Changed!";
            // This will tell OnTapped not to handle the tapped event again.
            e.Handled = true;
        }

        protected override void OnTapped(TappedRoutedEventArgs e)
        {
            contentGrid.Background = ChangeColor();
            base.OnTapped(e);
        }

        public static Brush ChangeColor()
        {
            Random ran = new Random();
            Byte[] ranByte = new Byte[3];
            ran.NextBytes(ranByte);
            return new SolidColorBrush (Color.FromArgb(255, ranByte[0], ranByte[1], ranByte[2]));
        }
    }
}
