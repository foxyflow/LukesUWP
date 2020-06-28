using System;
namespace Iteration6.Classes
{
    public abstract class Language
    {
        private const string V = "Not Set";

        public string WordMeaning { get; set; }

        public Language() => WordMeaning = V;

        public abstract String ReturnData();
    }
}
