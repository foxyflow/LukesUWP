using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iteration6.Classes;
namespace Iteration6.Classes
{
    public class English : Language
    {
        private String __italianWordIs;
        public String GuessTheItalainBeforePressingButton
        {
            get { return __italianWordIs; }
            set { __italianWordIs = value; }
        }

        public English()
        {
            __italianWordIs = "Sono (say your name)";
        }

        public override String ReturnData()
        {       //I am
            return $"Find buttons with English words. For Example, the button could say: {WordMeaning}.The Italain word is under the button. For example: " + this.GuessTheItalainBeforePressingButton.ToString();
        }
    }
}
