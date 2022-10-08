using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace I1P622_GianlucaPetronio
{
    class Signalisation
    {
        //variable 
        private string _Signalisation1001;
        private string _Signalisation007;

        //constructeur
        public Signalisation (string _Signalisation1001, string _Signalisation007)
        {
            this._Signalisation1001 = _Signalisation1001;
            this._Signalisation007 = _Signalisation007;
        }

        //methode
        public int changeColor(string _Signalisation1001, string _Signalisation007)
        {
            int color = 0;
            for(int i = 0; i < 3; i++)
            {
                
                if(i == 0)
                {
                    return color = 1;
                }
                else if (i == 1)
                {
                    return color = 2;
                }
                else
                {
                    return color = 3;
                }
            }

            return color;
        }

        public int clignoter(string _Signalisation1001, string _Signalisation007)
        {
            return ...;
        }

        public string afficheColorAndType(int color, string _Signalisation1001, string _Signalisation007)
        {
            _Signalisation007 = "feu de clignotement 007";
            _Signalisation1001 = "feu de clignotement 1001";
            
            string phrase = _Signalisation007 + color;
            string phrase2 = _Signalisation1001 + color;

            return phrase;
        }
    }
}
