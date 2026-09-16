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
        static private Color OPERATION_BG = Color.LightGray;
        static private Color NUMBER_BG = Color.WhiteSmoke;
        static private Color EQUAL_BG = Color.MediumBlue;


        public struct BtnStruct
        {
            public char Content;
            public Color BgColor;
            public BtnStruct(char content, Color bgColor)
            {
                this.Content = content;
                this.BgColor = bgColor;
            }

            public override string ToString()
            {
                return Content.ToString();
            }
           
        }
        private BtnStruct[,] buttons =
        {
            { new BtnStruct('%', OPERATION_BG), new BtnStruct('\u0152', OPERATION_BG), new BtnStruct('C', OPERATION_BG), new BtnStruct('\u232B', OPERATION_BG) },
            { new BtnStruct('\u215F', OPERATION_BG), new BtnStruct('\u00B2', OPERATION_BG), new BtnStruct('\u221a', OPERATION_BG), new BtnStruct('\u00F7', OPERATION_BG) },
            { new BtnStruct('7', NUMBER_BG), new BtnStruct('8', NUMBER_BG), new BtnStruct('9', NUMBER_BG), new BtnStruct('x', OPERATION_BG) },
            {new BtnStruct('4', NUMBER_BG), new BtnStruct('5', NUMBER_BG), new BtnStruct('6', NUMBER_BG), new BtnStruct('-', OPERATION_BG)},
            {new BtnStruct('1', NUMBER_BG), new BtnStruct('2', NUMBER_BG), new BtnStruct('3', NUMBER_BG), new BtnStruct('+', OPERATION_BG)},
            {new BtnStruct('\u00B1', NUMBER_BG), new BtnStruct('0', NUMBER_BG), new BtnStruct(',', NUMBER_BG), new BtnStruct('=', EQUAL_BG)}

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
                    btn.BackColor = buttons[i, j].BgColor;
                    Controls.Add(btn);
                    posX += btnWidth;
                    
                }
                posY += btnHeight;
            }
        }
    }
}
