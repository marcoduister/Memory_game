using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    class Image
    {
        private static Form1 mainform = new Form1();
        private static end lol = new end();


        internal static void Imagecheck(PictureBox main)
        {
            
            if (Form1.open1 == null)
            {
                Form1.open1 = main;
                Form1.check.Add(Form1.open1);
            }
            else if (Form1.open1 != null && Form1.open2 == null)
            {
                Form1.open2 = main;
                Form1.check.Add(Form1.open2);
            }
            if (Form1.open1 != null && Form1.open2 != null)
            {
                if (Form1.open1.Tag == Form1.open2.Tag)
                {
                    Form1.open1.Enabled = false;
                    Form1.open2.Enabled = false;
                    Openclear();
                    end.End_game();
                }
                else
                {
                    mainform.Timeset();
                }
            }
        }
        public static void Openclear()
        {
            Form1.check.Clear();
            Form1.open1 = null;
            Form1.open2 = null;
        }

    }
}
