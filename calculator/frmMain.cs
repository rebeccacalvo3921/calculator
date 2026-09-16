using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class frmMain : Form
    {
        private char[,] buttons =
        {
            { '%', '\u0152', 'C', '\u232B' },
            { '\u215F', '\u00B2', '\u221a', '\u00F7' },
            { '7', '8', '9', 'x' },
            { '4', '5', '6', '-' },
            { '1', '2', '3', '+' },
            { '\u00B1', '0', ',', '=' }

        };

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MakeButtons();
        }

        private void MakeButtons()
        {
            int btnWidth = 80, btnHeight = 60;
            int posY = 118;
            for(int i = 0; i < buttons.GetLength(0); i++) //righe
            {
                int posX = 0;
                for(int j = 0; j <  buttons.GetLength(1); j++) //colonne
                {
                    Button btn = new Button();
                    btn.Width = btnWidth;
                    btn.Height = btnHeight;
                    btn.Top = posY;
                    btn.Left = posX;
                    btn.Font = new Font("Segoe UI", 16);
                    btn.Text = buttons[i, j].ToString();
                    Controls.Add(btn);
                    posX += btnWidth;

                }
                posY += btnHeight;
            }
        }
    }
}
