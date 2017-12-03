using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    class end
    {
        private static Form1 mainform = new Form1();
        public static List<int> endlist = new List<int>() { };
        public static void End_game()
        {
            endlist.Add(1);
            int count = endlist.Count(x => x < 6);
            if (count == 6)
            {
                MessageBox.Show("einden spel");
                endlist.Clear();
            }
        }
    }
}
