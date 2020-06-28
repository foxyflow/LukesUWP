using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.UI;
using Microsoft.Win32;
using Iteration6.Classes;
using Windows.Media.Core;
using Windows.Media.Playback;

namespace Iteration6
    //This class is called from ToGamePage.xaml.cs
{
    public class ToGamePage//: BlankPage2
    {
        public MediaPlayer LLLplayer;
        public bool LLLplaying;
        public ToGamePage()
        {
            LLLplayer = new MediaPlayer();
            LLLplaying = false;
        }

    }
}





//other attempts, plus libraries left in to try stuff later.


// public bool Autoplay; //Tried making own autoplay
// public ToGamePage( bool autoplay, Windows.Storage.StorageFile file)
// LLLplayer.AutoPlay = autoplay;
//  LLLplaying = autoplay;
// LLLplayer = new MediaPlayer();
// LLLplayer.Source = MediaSource.CreateFromStorageFile(file);

// public ToGamePage(MediaPlayer lLLplayer)
// {
//     LLLplayer = lLLplayer;
// }
//
// //start play
// public void Play()
// {
//     LLLplayer.Play();
//     LLLplaying = true;
// }
//
// //return true or false if playing or not
// public bool IsPlaying()
// {
//     return LLLplaying;
// }
//
// //set source to null
// public void SetSourceNull()
// {
//     LLLplayer.Source = null;
//     LLLplaying = false;
// }


