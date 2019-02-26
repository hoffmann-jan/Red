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
                        "Kauen",
                        "Augentraining Bewegung",
                        "Schulterkreisen",
                        "Sonnenübung",
                        "Kopf auf dem Atlas gleiten",
                        "Blickfang",
                        "Arme ausschütteln",
                        "Flanieren",
                        "Augentraining in die Ferne sehen",
                        "Kopf Bewegen",
                        "Meditation",
                        "Kleine Muskeln trainieren",
                        "Grimassen schneiden",
                        "Diagonal Dehnung",
                        "Beine strecken",
                        "Augen schließen"
                    };
                }

                return _Excercises;                
            }
        }

        public static int MessageCount => Excercises.Length;
    }
}
