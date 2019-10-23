using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawChessBoard();
        }
        
        void DrawChessBoard()
        {
            /*
            Button btn = new Button();
            btn.Text = "Test";
            btn.Location = new Point(45, 45);

            Button btn2 = new Button();
            btn2.Text = "Test2";
            btn2.Location = new Point(btn.Location.X + btn.Width, btn.Location.Y);

            pnlCheckBoard.Controls.Add(btn);
            pnlCheckBoard.Controls.Add(btn2);
            */
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for(int  i = 0; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                for (int j = 0; j< Cons.CHESS_BOARD_HEIGHT; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y)
                    };

                    pnlCheckBoard.Controls.Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
    }
}
