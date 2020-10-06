namespace application_database
{
    partial class TicTacToeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeForm));
            this.tictactoe_console_button = new System.Windows.Forms.Button();
            this.opening_apps_label = new System.Windows.Forms.Label();
            this.tictactoe_gui_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tictactoe_console_button
            // 
            this.tictactoe_console_button.BackColor = System.Drawing.Color.Black;
            this.tictactoe_console_button.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tictactoe_console_button.ForeColor = System.Drawing.Color.YellowGreen;
            this.tictactoe_console_button.Location = new System.Drawing.Point(12, 84);
            this.tictactoe_console_button.Name = "tictactoe_console_button";
            this.tictactoe_console_button.Size = new System.Drawing.Size(190, 217);
            this.tictactoe_console_button.TabIndex = 17;
            this.tictactoe_console_button.Text = "Console";
            this.tictactoe_console_button.UseVisualStyleBackColor = false;
            this.tictactoe_console_button.Click += new System.EventHandler(this.tictactoe_console_button_Click);
            this.tictactoe_console_button.MouseEnter += new System.EventHandler(this.tictactoe_console_button_MouseEnter);
            this.tictactoe_console_button.MouseLeave += new System.EventHandler(this.tictactoe_console_button_MouseLeave);
            // 
            // opening_apps_label
            // 
            this.opening_apps_label.AutoSize = true;
            this.opening_apps_label.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opening_apps_label.ForeColor = System.Drawing.Color.Yellow;
            this.opening_apps_label.Location = new System.Drawing.Point(129, 19);
            this.opening_apps_label.Name = "opening_apps_label";
            this.opening_apps_label.Size = new System.Drawing.Size(230, 49);
            this.opening_apps_label.TabIndex = 38;
            this.opening_apps_label.Text = "CHOOSE GAME";
            this.opening_apps_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.opening_apps_label.UseCompatibleTextRendering = true;
            // 
            // tictactoe_gui_button
            // 
            this.tictactoe_gui_button.BackColor = System.Drawing.Color.Black;
            this.tictactoe_gui_button.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tictactoe_gui_button.ForeColor = System.Drawing.Color.YellowGreen;
            this.tictactoe_gui_button.Location = new System.Drawing.Point(298, 84);
            this.tictactoe_gui_button.Name = "tictactoe_gui_button";
            this.tictactoe_gui_button.Size = new System.Drawing.Size(190, 217);
            this.tictactoe_gui_button.TabIndex = 39;
            this.tictactoe_gui_button.Text = "GUI";
            this.tictactoe_gui_button.UseVisualStyleBackColor = false;
            this.tictactoe_gui_button.Click += new System.EventHandler(this.tictactoe_gui_button_Click);
            this.tictactoe_gui_button.MouseEnter += new System.EventHandler(this.tictactoe_gui_button_MouseEnter);
            this.tictactoe_gui_button.MouseLeave += new System.EventHandler(this.tictactoe_gui_button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(231, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 213);
            this.label1.TabIndex = 40;
            this.label1.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(500, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tictactoe_gui_button);
            this.Controls.Add(this.opening_apps_label);
            this.Controls.Add(this.tictactoe_console_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToeForm";
            this.Text = "<Choose game>";
            this.Load += new System.EventHandler(this.TicTacToeFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tictactoe_console_button;
        private System.Windows.Forms.Label opening_apps_label;
        private System.Windows.Forms.Button tictactoe_gui_button;
        private System.Windows.Forms.Label label1;
    }
}