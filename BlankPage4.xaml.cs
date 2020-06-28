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
   
    public sealed partial class BlankPage4 : Page
    {
        public BlankPage4()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) =>
            //Logo Back button:
            Frame.Navigate(typeof(MainPage));

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Choose your language
            //Disabled for now
            
        }
    }
}
