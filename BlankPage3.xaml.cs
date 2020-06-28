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


namespace Iteration6
{
   
    public sealed partial class BlankPage3 : Page
    {
        public BlankPage3()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) =>
            //Home page
            Frame.Navigate(typeof(MainPage));

        private void Button_Click_1(
            object sender, RoutedEventArgs e)
        {
            //Saved Page
            Frame.Navigate(typeof(BlankPage6));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) =>
            //Go to Language from options 
            Frame.Navigate(typeof(BlankPage4));

        private void Button_Click_3(object sender, RoutedEventArgs e) =>
            //Go to controls 
            Frame.Navigate(typeof(BlankPage5));

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //options label
        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {
            //To put in dark theme
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) =>
            //Levels Page from Options 
            Frame.Navigate(typeof(BlankPage7));
    }
}
