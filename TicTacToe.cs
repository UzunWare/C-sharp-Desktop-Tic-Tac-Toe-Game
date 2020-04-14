using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class form1 : Form
    {
        int dim = 4;
        string name;

        TURN Player=TURN.RED;
        Cell[][] CellMap;
        Cell CellClicked;
        public form1()
        {
            InitializeComponent();
        }

        void TurnChange()
        {
            if(Player==TURN.BLUE)
            {
                Player = TURN.RED;
            }
            else
            {
                Player = TURN.BLUE;
            }
        }

        void IsDraw()
        {
            for (int ri = 0; ri < dim; ri++)
            {
                for (int ci = 0; ci < dim; ci++)
                {
                    if(CellMap[ri][ci].value==TURN.EMPTY)
                    {
                        return;
                    }
                }
            }
            string message = "Do you want to continue the game?";
            string caption = "Tic-Tac-Toe";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            MessageBox.Show("The Game is Draw !!!");
            result = MessageBox.Show(message,caption,buttons);
            if(result==System.Windows.Forms.DialogResult.Yes)
            {
                Map.Controls.Clear();
            }
            else
            {
                this.Close();
            }
        }
        
        bool CheckHorizontal(int ri,TURN C)
        {
            for (int c = 0; c < dim; c++)
            {
                if(CellMap[ri][c].value!=C)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckVertical(int ci, TURN C)
        {
            for (int r = 0; r < dim; r++)
            {
                if (CellMap[r][ci].value != C)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckDiagonally(TURN C)
        {
            for (int ri = 0; ri < dim; ri++)
            {
                if(CellMap[ri][ri].value!=C)
                {
                    return false;
                }
            }
            return true;
        }

        bool CheckDiagonally2(TURN C)
        {
            for (int ri = 0; ri < dim; ri++)
            {
                if (CellMap[dim-1-ri][ri].value != C)
                {
                    return false;
                }
            }
            return true;
        }

        void CheckWin(TURN C)
        {
            for (int ri = 0; ri < dim; ri++)
            {
                for (int ci = 0; ci < dim; ci++)
                {
                    if(CellMap[ri][ci].value==C)
                    {
                        if(CheckHorizontal(ri,C))
                        {
                            string message = "Do you want to continue the game?";
                            string caption = "Tic-Tac-Toe";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;
                            if(C==TURN.BLUE)
                            {
                                MessageBox.Show("Player-2 Wins...!!!");
                            }
                            else
                            {
                                MessageBox.Show("Player-1 Wins...!!!");
                            }
                            
                            result = MessageBox.Show(message, caption, buttons);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                Map.Controls.Clear();
                                PlayerOne.BackColor = Color.Gray;
                                PlayerTwo.BackColor = Color.Gray;
                                
                                return;
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else if(CheckVertical(ci,C))
                        {
                            string message = "Do you want to continue the game?";
                            string caption = "Tic-Tac-Toe";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;
                            if (C == TURN.BLUE)
                            {
                                MessageBox.Show("Player-2 Wins...!!!");
                            }
                            else
                            {
                                MessageBox.Show("Player-1 Wins...!!!");
                            }

                            result = MessageBox.Show(message, caption, buttons);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                Map.Controls.Clear();
                                PlayerOne.BackColor = Color.Gray;
                                PlayerTwo.BackColor = Color.Gray;
                                return;
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else if(CheckDiagonally(C))
                        {
                            string message = "Do you want to continue the game?";
                            string caption = "Tic-Tac-Toe";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;
                            if (C == TURN.BLUE)
                            {
                                MessageBox.Show("Player-2 Wins...!!!");
                            }
                            else
                            {
                                MessageBox.Show("Player-1 Wins...!!!");
                            }

                            result = MessageBox.Show(message, caption, buttons);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                Map.Controls.Clear();
                                PlayerOne.BackColor = Color.Gray;
                                PlayerTwo.BackColor = Color.Gray;
                                
                                return;
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else if (CheckDiagonally2(C))
                        {
                            string message = "Do you want to continue the game?";
                            string caption = "Tic-Tac-Toe";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;
                            if (C == TURN.BLUE)
                            {
                                MessageBox.Show("Player-2 Wins...!!!");
                            }
                            else
                            {
                                MessageBox.Show("Player-1 Wins...!!!");

                            }

                            result = MessageBox.Show(message, caption, buttons);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                Map.Controls.Clear();
                                PlayerOne.BackColor = Color.Gray;
                                PlayerTwo.BackColor = Color.Gray;
                                return;
                            }
                            else
                            {
                                this.Close();
                            }
                        }

                    }
                }
            }
        }


        void ChangeColorandValue()
        {
            if(Player==TURN.BLUE)
            {
                name = "O.png";
                CellClicked.Draw(name);
                CellClicked.value = TURN.BLUE;
                PlayerOne.BackColor = Color.Red;
                PlayerTwo.BackColor = Color.Gray;
            }
            else
            {
                PlayerOne.BackColor = Color.Gray;
                PlayerTwo.BackColor = Color.Blue;
                name = "X.png";
                CellClicked.Draw(name);
                CellClicked.value = TURN.RED;
            }
            TurnChange();
            IsDraw();
            CheckWin(TURN.BLUE);
            CheckWin(TURN.RED);
            
            
        }

        private void Clicked(object sender,EventArgs e)
        {
            CellClicked = (Cell)sender;
            if(CellClicked.value!=TURN.EMPTY)
            {
                MessageBox.Show("You are trying to open a box which is already open!!!");
                return;
            }
            ChangeColorandValue();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Map.Controls.Clear();
            PlayerOne.BackColor = Color.Red;
            CellMap = new Cell[dim][];
            for (int a = 0; a < dim; a++)
            {
                CellMap[a] = new Cell[dim];
            }
                
            
            for (int ri = 0; ri < dim; ri++)   
            {      
                for (int ci = 0; ci < dim; ci++)
                {
                    CellMap[ri][ci] = new Cell(ri,ci,Map.Width,Map.Height,dim,null);
                    Map.Controls.Add(CellMap[ri][ci]);
                    this.CellMap[ri][ci].Click += new System.EventHandler(this.Clicked);
                }
            }
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}
