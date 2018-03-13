using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_QAandT
{
    public partial class Form1 : Form
    {

        TicTacToeMethods tictactoe = new TicTacToeMethods();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tictactoe.CreateBoard();
           // MessageBox.Show(tictactoe.gameBoard[2,2].ToString()); 
        }
    }
}
