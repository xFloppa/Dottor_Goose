using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dottor_Goose_Game
{
    public partial class Form1 : Form
    {
        
       
           
             Point(81, 93),   // 1
             Point(81, 166),  // 2
            new Point(81, 237),  // 3
            new Point(81, 308),  // 4
            new Point(81, 377),  // 5
            new Point(81, 449),  // 6
            new Point(196, 449), // 7
            new Point(308, 449), // 8
            new Point(313, 378), // 9
            new Point(313, 308), // 10
            new Point(313, 238), // 11
            new Point(313, 166), // 12
            new Point(313, 93),  // 13
            new Point(440, 93),  // 14
            new Point(563, 93),  // 15
            new Point(699, 93),  // 16
            new Point(818, 93), // 17

        


        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private int playerPosition = 0;

        private Point[] boardPositions = new Point[28];
        private void Form1_Load(object sender, EventArgs e)
        {
            boardPositions[0] = new Point(81, 23);
            boardPositions[1] = new Point();
            boardPositions[2] = new Point();
            boardPositions[3] = new Point();
            boardPositions[4] = new Point();
            boardPositions[5] = new Point();
            boardPositions[6] = new Point();
            boardPositions[7] = new Point();
            boardPositions[8] = new Point();
            playerPosition = 0;
            pictureBoxPlayer.Location = boardPositions[0];

            btnLancioDado.Text = "Tira i dadi";
            btnLancioDado.Click += new EventHandler(btnLancioDado_Click);

            labelResult.Text = "Risultato dei dadi: ";
        }

        private void btnLancioDado_Click(object sender, EventArgs e)
        {
            
            int diceResult = random.Next(1, 7);
            textBox1.Text =  diceResult.ToString();

            MovePlayer(diceResult);

            
        }

        private void MovePlayer(int diceResult)
        {
            playerPosition += diceResult;


            /* if (playerPosition >= boardPositions.Length)
            {
                playerPosition = boardPositions.Length - 1;
            }*/

            pictureBoxPlayer.Location = boardPositions[playerPosition];
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            playerPosition = 0;
            pictureBoxPlayer.Location = boardPositions[0];
        }
    }
}
