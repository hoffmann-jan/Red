namespace JanHoffmann.Red.UI.RedWinForms
{
    public static class Messages
    {
        private static string[] _excercises;

        public static string[] Excercises
        {
            get
            {
                if (_excercises == null)
                {
                    _excercises = new string[]
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

                return _excercises;                
            }
        }

        public static int MessageCount => Excercises.Length;
    }
}
