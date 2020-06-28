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
using Windows.Media.Playback;
using Windows.Media.Core;
using Iteration6.Classes;
using Windows.Globalization;
//Developed by: Luke Fox 30011364

namespace Iteration6 
{
   
    public sealed partial class MainPage : Page
    {
        English find;
        Italain word;
        
        public MainPage()
        {
            this.InitializeComponent();
            

                find = new English();
                word = new Italain();
            
        }
        private void LLLButton_Click(object sender, RoutedEventArgs e)
        {
            find.WordMeaning = "Good Morning";
            find.GuessTheItalainBeforePressingButton = "Buongiorno"; 
            LLLtextBlock1.Text = find.ReturnData();

            word.WordMeaning = "Hello";
            word.TheWordIs = "Ciao";
            LLLtextBlock2.Text = word.ReturnData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   // To Login page:
            Frame.Navigate(typeof(BlankPage1));
        }

         private void Button_Click_1(object sender, RoutedEventArgs e)
        {//To Game page/continue from Main:
            
            //How to disable button gif?
            Frame.Navigate(typeof(BlankPage2));
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
                     
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Options page:
            Frame.Navigate(typeof(BlankPage3));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {   //Game page:
            
            Frame.Navigate(typeof(BlankPage2));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
            Application.Current.Exit();
        }
    
    }     
}
