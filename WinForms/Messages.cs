using System.Collections.Generic;

namespace RedBlinkWinForms
{
    public static class Messages
    {
        private static string[] _Excercises;

        public static string[] Excercises
        {
            get
            {
                if (_Excercises == null)
                {
                    _Excercises = new string[]
                    {
                        "Wiederkauen",
                        "Augentraining",
                        "Schulterkreisen",
                        "Wirbelsäule entblocken",
                        "Weitsehen",
                        "Atlas gleiten",
                        "Blickfang",
                        "Hände ausschütteln",
                        "Spaziergang"
                    };
                }

                return _Excercises;                
            }
        }

        public static int MessageCount => Excercises.Length;
    }
}
