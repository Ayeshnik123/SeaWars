using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SeaWars
{
    class Bot
    {
        public static void Pole(DataGridView dataGridView2, int abv)
        {

            Random rand = new Random();
            for (int i = 0; i < 1; i++)
            {
                abv = rand.Next(0, 5);
                switch (abv)
                {
                    case (1):
                        dataGridView2[1, 1].Style.BackColor = Color.Black;//1
                        dataGridView2[5, 5].Style.BackColor = Color.Black;//1
                        dataGridView2[7, 7].Style.BackColor = Color.Black;//1
                        dataGridView2[3, 4].Style.BackColor = Color.Black;//1
                        dataGridView2[9, 0].Style.BackColor = Color.Black;//2
                        dataGridView2[9, 1].Style.BackColor = Color.Black;//2
                        dataGridView2[0, 9].Style.BackColor = Color.Black;//2
                        dataGridView2[1, 9].Style.BackColor = Color.Black;//2
                        dataGridView2[2, 7].Style.BackColor = Color.Black;//2
                        dataGridView2[2, 6].Style.BackColor = Color.Black;//2
                        dataGridView2[3, 1].Style.BackColor = Color.Black;//3
                        dataGridView2[4, 1].Style.BackColor = Color.Black;//3
                        dataGridView2[5, 1].Style.BackColor = Color.Black;//3
                        dataGridView2[7, 3].Style.BackColor = Color.Black;//3
                        dataGridView2[8, 3].Style.BackColor = Color.Black;//3
                        dataGridView2[9, 3].Style.BackColor = Color.Black;//3
                        dataGridView2[0, 3].Style.BackColor = Color.Black;//4
                        dataGridView2[0, 4].Style.BackColor = Color.Black;//4
                        dataGridView2[0, 5].Style.BackColor = Color.Black;//4
                        dataGridView2[0, 6].Style.BackColor = Color.Black;//4
                        break;

                    case (2):
                        dataGridView2[0, 0].Style.BackColor = Color.Black;//1
                        dataGridView2[1, 4].Style.BackColor = Color.Black;//1
                        dataGridView2[7, 4].Style.BackColor = Color.Black;//1
                        dataGridView2[3, 9].Style.BackColor = Color.Black;//1
                        dataGridView2[9, 4].Style.BackColor = Color.Black;//2
                        dataGridView2[9, 5].Style.BackColor = Color.Black;//2
                        dataGridView2[0, 7].Style.BackColor = Color.Black;//2
                        dataGridView2[0, 8].Style.BackColor = Color.Black;//2
                        dataGridView2[3, 5].Style.BackColor = Color.Black;//2
                        dataGridView2[4, 5].Style.BackColor = Color.Black;//2
                        dataGridView2[0, 2].Style.BackColor = Color.Black;//3
                        dataGridView2[1, 2].Style.BackColor = Color.Black;//3
                        dataGridView2[2, 2].Style.BackColor = Color.Black;//3
                        dataGridView2[3, 7].Style.BackColor = Color.Black;//3
                        dataGridView2[4, 7].Style.BackColor = Color.Black;//3
                        dataGridView2[5, 7].Style.BackColor = Color.Black;//3
                        dataGridView2[5, 1].Style.BackColor = Color.Black;//4
                        dataGridView2[6, 1].Style.BackColor = Color.Black;//4
                        dataGridView2[7, 1].Style.BackColor = Color.Black;//4
                        dataGridView2[8, 1].Style.BackColor = Color.Black;//4
                        break;

                    case (3):
                        dataGridView2[7, 1].Style.BackColor = Color.Black;//1
                        dataGridView2[9, 1].Style.BackColor = Color.Black;//1
                        dataGridView2[7, 4].Style.BackColor = Color.Black;//1
                        dataGridView2[4, 9].Style.BackColor = Color.Black;//1
                        dataGridView2[1, 0].Style.BackColor = Color.Black;//2
                        dataGridView2[2, 0].Style.BackColor = Color.Black;//2
                        dataGridView2[5, 3].Style.BackColor = Color.Black;//2
                        dataGridView2[5, 4].Style.BackColor = Color.Black;//2
                        dataGridView2[7, 6].Style.BackColor = Color.Black;//2
                        dataGridView2[7, 7].Style.BackColor = Color.Black;//2
                        dataGridView2[9, 4].Style.BackColor = Color.Black;//3
                        dataGridView2[9, 5].Style.BackColor = Color.Black;//3
                        dataGridView2[9, 6].Style.BackColor = Color.Black;//3
                        dataGridView2[6, 9].Style.BackColor = Color.Black;//3
                        dataGridView2[7, 9].Style.BackColor = Color.Black;//3
                        dataGridView2[8, 9].Style.BackColor = Color.Black;//3
                        dataGridView2[0, 2].Style.BackColor = Color.Black;//4
                        dataGridView2[1, 2].Style.BackColor = Color.Black;//4
                        dataGridView2[2, 2].Style.BackColor = Color.Black;//4
                        dataGridView2[3, 2].Style.BackColor = Color.Black;//4
                        break;

                    case (4):
                        dataGridView2[1, 2].Style.BackColor = Color.Black;//1
                        dataGridView2[3, 4].Style.BackColor = Color.Black;//1
                        dataGridView2[7, 5].Style.BackColor = Color.Black;//1
                        dataGridView2[3, 7].Style.BackColor = Color.Black;//1
                        dataGridView2[0, 4].Style.BackColor = Color.Black;//2
                        dataGridView2[0, 5].Style.BackColor = Color.Black;//2
                        dataGridView2[1, 7].Style.BackColor = Color.Black;//2
                        dataGridView2[1, 8].Style.BackColor = Color.Black;//2
                        dataGridView2[8, 3].Style.BackColor = Color.Black;//2
                        dataGridView2[9, 3].Style.BackColor = Color.Black;//2
                        dataGridView2[9, 5].Style.BackColor = Color.Black;//3
                        dataGridView2[9, 6].Style.BackColor = Color.Black;//3
                        dataGridView2[9, 7].Style.BackColor = Color.Black;//3
                        dataGridView2[5, 9].Style.BackColor = Color.Black;//3
                        dataGridView2[6, 9].Style.BackColor = Color.Black;//3
                        dataGridView2[7, 9].Style.BackColor = Color.Black;//3
                        dataGridView2[5, 2].Style.BackColor = Color.Black;//4
                        dataGridView2[5, 3].Style.BackColor = Color.Black;//4
                        dataGridView2[5, 4].Style.BackColor = Color.Black;//4
                        dataGridView2[5, 5].Style.BackColor = Color.Black;//4
                        break;

                    case (5):
                        dataGridView2[4, 0].Style.BackColor = Color.Black;//1
                        dataGridView2[1, 1].Style.BackColor = Color.Black;//1
                        dataGridView2[4, 5].Style.BackColor = Color.Black;//1
                        dataGridView2[3, 8].Style.BackColor = Color.Black;//1
                        dataGridView2[6, 1].Style.BackColor = Color.Black;//2
                        dataGridView2[7, 1].Style.BackColor = Color.Black;//2
                        dataGridView2[6, 8].Style.BackColor = Color.Black;//2
                        dataGridView2[7, 8].Style.BackColor = Color.Black;//2
                        dataGridView2[2, 3].Style.BackColor = Color.Black;//2
                        dataGridView2[2, 4].Style.BackColor = Color.Black;//2
                        dataGridView2[7, 4].Style.BackColor = Color.Black;//3
                        dataGridView2[8, 4].Style.BackColor = Color.Black;//3
                        dataGridView2[9, 4].Style.BackColor = Color.Black;//3
                        dataGridView2[7, 6].Style.BackColor = Color.Black;//3
                        dataGridView2[8, 6].Style.BackColor = Color.Black;//3
                        dataGridView2[9, 6].Style.BackColor = Color.Black;//3
                        dataGridView2[0, 5].Style.BackColor = Color.Black;//4
                        dataGridView2[0, 6].Style.BackColor = Color.Black;//4
                        dataGridView2[0, 7].Style.BackColor = Color.Black;//4
                        dataGridView2[0, 8].Style.BackColor = Color.Black;//4
                        break;
                }
            }
        }
    }
}
