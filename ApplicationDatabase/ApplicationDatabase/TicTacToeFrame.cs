using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application_database {
    public partial class TicTacToeForm : Form {
        public TicTacToeForm() {
            InitializeComponent();
        }

        private ApplicationDatabaseForm application_database = null;
        public TicTacToeForm(Form parent)
        {
            application_database = parent as ApplicationDatabaseForm;
            InitializeComponent();
        }

        public String tictactoe_console_path;
        public String tictactoe_gui_path;
        public String suffix = ".py - Shortcut";

        void InitPaths()
        {
            tictactoe_console_path = application_database.origin + "tictactoe_console" + suffix;
            tictactoe_gui_path = application_database.origin + "tictactoe_gui" + suffix;
        }

        private void TicTacToeFrame_Load(object sender, EventArgs e)
        {
            InitPaths();
        }

        private void tictactoe_console_button_Click(object sender, EventArgs e)
        {
            application_database.CreateAddItem("tictactoe console");
            System.Diagnostics.Process.Start(tictactoe_console_path);
        }

        private void tictactoe_gui_button_Click(object sender, EventArgs e)
        {
            application_database.CreateAddItem("tictactoe gui");
            System.Diagnostics.Process.Start(tictactoe_gui_path);
        }

        private void tictactoe_console_button_MouseEnter(object sender, EventArgs e)
        {
            tictactoe_console_button.BackColor = Color.YellowGreen;
            tictactoe_console_button.ForeColor = Color.DodgerBlue;
        }

        private void tictactoe_console_button_MouseLeave(object sender, EventArgs e)
        {
            tictactoe_console_button.BackColor = Color.Black;
            tictactoe_console_button.ForeColor = Color.YellowGreen;
        }

        private void tictactoe_gui_button_MouseEnter(object sender, EventArgs e)
        {
            tictactoe_gui_button.BackColor = Color.YellowGreen;
            tictactoe_gui_button.ForeColor = Color.DodgerBlue;
        }

        private void tictactoe_gui_button_MouseLeave(object sender, EventArgs e)
        {
            tictactoe_gui_button.BackColor = Color.Black;
            tictactoe_gui_button.ForeColor = Color.YellowGreen;
        }
    }
}
