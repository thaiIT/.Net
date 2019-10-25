﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        private List<Player> player;

        internal List<Player> Player
        {
            get { return player; }
            set { player = value; }
        }

        private int currentPlayer;

        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }

        private TextBox playerName;
        public TextBox PlayerName { get => playerName; set => playerName = value; }

        private PictureBox playerMark;
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox playerMark)
        {
            this.chessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = playerMark;
            this.Player = new List<Player>()
            {
                new Player("PlayerA", Image.FromFile(Application.StartupPath + "\\Resources\\Game-clubs-icon.png")),
                new Player("PlayerB", Image.FromFile(Application.StartupPath + "\\Resources\\Game-spades-icon.png"))

            };
            CurrentPlayer = 0;
            ChangePlayer();
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.CHESS_BOARD_HEIGHT; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += btn_Click;

                    chessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            Mark(btn);
            ChangePlayer();
            if (isEndGame(btn))
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            MessageBox.Show("Ket thuc game");
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(vertical, horizontal);
            return point;
        }
        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for(int i = point.X; i > 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == 5;
        }

        private bool isEndVertical(Button btn)
        {
            return false;
        }

        private bool isEndPrimary(Button btn)
        {
            return false;
        }

        private bool isEndSub(Button btn)
        {
            return false;
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }
        private void ChangePlayer()
        {
            playerName.Text = Player[CurrentPlayer].Name;
            playerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion


    }
}
