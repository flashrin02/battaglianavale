using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battaglianavale
{
    internal class CNave
    {
        static int count = 1;

        int id,
            grandezza, 
            rotazione, // 0 ^   1 >     2 _     3 <  
            posX, 
            posY, 
            vita;

        public int Id 
        {
            get { return id; }
        }

        public event EventHandler<NaviEventArgs> OnNaveDistrutta;

        public CNave(int grandezza, int rotazione, int posX, int posY)
        {
            this.grandezza = grandezza;
            this.rotazione = rotazione;
            this.posX = posX;
            this.posY = posY;
            this.vita = grandezza;

            id = count;
            count++;
        }

        public void ReplyAttacco(object? sender, NaviEventArgs args) 
        {
            if (args.Id == id)
                vita--;
            CheckVivo();
        }

        private void CheckVivo() 
        {
            if (vita == 0)
            {
                NaviEventArgs args = new NaviEventArgs();
                args.Id = id;
                NaveDistrutta(args);
            }
        }

        private void NaveDistrutta(NaviEventArgs args) 
        {
            EventHandler<NaviEventArgs> handler = OnNaveDistrutta;
            handler?.Invoke(this, args);
        }
    }
}
