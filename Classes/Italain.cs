using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Iteration6.Classes;
using Windows.Security.Authentication.Web.Core;

namespace Iteration6.Classes
{
    
    public class Italain : Language
    {
        private string MyWordHere;
        private string myWordHere;

        public string TheWordIs
        {
            get { return MyWordHere; }
            set { MyWordHere = value; }

        }
        
        public Italain()
        {
            MyWordHere = myWordHere;
            
        }

        public override String ReturnData()
        {                                
            return $"{TheWordIs} which means {WordMeaning}.\n" +
                $"Try and guess what's under the buttons before playing the answers located in: The Game, \nthen after listening to the answers, try again to master all 5 words. " +
                $"You could count the letters to help learn, for example: {TheWordIs} length is {TheWordIs.Length}. {MyWordHere} (also means goodbye.) Enjoy.";

        }

    }
    
}
