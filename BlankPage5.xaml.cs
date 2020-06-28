using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Iteration6.Classes;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.UI;
using Microsoft.Win32;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
//Control Panel page:


namespace Iteration6
{
  
    public sealed partial class BlankPage5 : Page
    {
        //Couldn't get slider working:
        // MediaElement Media = new MediaElement(); //was slider
        //  public double Value { get; set; }
        // public object Media { get; private set; }

        
        bool playing; //to pause -- declare
        MediaPlayer player;// to play
        public BlankPage5()
        {
            this.InitializeComponent();
            player = new MediaPlayer(); //instantiated MediaPlayer
            playing = false; // to pause init

            // Slider volumeSlider = new Slider();
            // volumeSlider.Header = "Volume";
            // volumeSlider.Width = 200;
            // volumeSlider.ValueChanged += Slider_ValueChanged;

            // Add the slider to a parent container in the visual tree.
            //  stackPanel1.Children.Add(volumeSlider);
        }
        internal async void ClickMeButton_Click_1(object sender, RoutedEventArgs e) //Play and pause media button in control panel page -- testing controls for Game Page
        {
            //Result after clicked
            ResultTextBlock.Text = "Find the Italain equivalate: \n Hello, Goodmorning, Goodnight, Goodevening, and I-am";
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Media");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("ItalianWords.mp3");

            player.AutoPlay = false;
            player.Source = MediaSource.CreateFromStorageFile(file);
            player.Play();

            if (playing)
            {
                //player.Pause();
                player.Source = null;
                playing = false;
            }
            else
            {
                player.Play();
                playing = true;
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {
          

        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

                   
                Slider slider = sender as Slider;
            if (slider != null)
            {
                //media.Volume = slider.Value;
               // Media.Volume = slider.Value;
            }       
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            //Name on button
            ResultTextBlock.Text = "Control Panel is disabled";
        }

        private void SettingButton_Click(object sender, RoutedEventArgs e)
        {
            //Secret clue for having a look around the app
            TextBlockSettings.Text = "Clue: Buona means good";
        }

        private void MuteButton_Click(object sender, RoutedEventArgs e)
        {
            //  Media.IsMuted = !Media.IsMuted;
        }

    }
}
