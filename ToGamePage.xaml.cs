using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Playback;
using System.Drawing;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.Media.Core;



// Game Page AKA Page2

namespace Iteration6
{ 
    public partial class BlankPage2 : Page
    {       
        public BlankPage2()
        {
            this.InitializeComponent();          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
        //gp: game page
        ToGamePage gp = new ToGamePage();
        internal async void Answer_Click(object sender, RoutedEventArgs e)
        {
            
            //Result after clicked: play and pause a selected media item: in this case: ItalianWords.mp3 is loaded from the Media Folder:
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Media");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("ItalianWords.mp3");

            gp.LLLplayer.AutoPlay = false;
            gp.LLLplayer.Source = MediaSource.CreateFromStorageFile(file);
            gp.LLLplayer.Play();


            //Play and Pause:
            if (gp.LLLplaying)
            {
               
                gp.LLLplayer.Source = null;
                gp.LLLplaying = false;
            }
            else
            {
                gp.LLLplayer.Play();
                gp.LLLplaying = true;
            }

        }

        private void answerGoodMorning_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //Buongiorno = Goodmorning
            answerGoodMorning.Text = "Buongiorno";

        }
        //For loop to display Buona Notte down a list every time the button is clicked
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {          
            for (int i = 0; i < 1; i++)
            {
                answerTextBlock.Text += " Buona notte = goodnight \n";
              
            }
            answerTextBlock.Text += "\n";          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.answerGoodMorning.Text = "GOOD MORNING";
        }

        private void GoodEvening_Click(object sender, RoutedEventArgs e)
        {
            GoodEveningBlock.Text = "Did you say Buona Sera?\n If so, WELL DONE!";
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            answerGoodMorning.Text = "Sono means I am. EG Sono Paul";
        }
        private void Ciao_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            GoodEveningBlock.Text = "Press LLL back button and Exit \nto leave the game. Ciao";
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {


        }
    }
}
//Attempts:
//  ToGamePage fromGamPage = new ToGamePage(false, file);