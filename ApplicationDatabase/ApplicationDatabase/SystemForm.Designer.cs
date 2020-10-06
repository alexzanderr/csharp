namespace application_database
{
    partial class SystemForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemForm));
            this.information_label = new System.Windows.Forms.Label();
            this.processesloading_label = new System.Windows.Forms.Label();
            this.background_label = new System.Windows.Forms.Label();
            this.loading_timer = new System.Windows.Forms.Timer(this.components);
            this.timer_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // information_label
            // 
            this.information_label.AutoSize = true;
            this.information_label.BackColor = System.Drawing.Color.Black;
            this.information_label.Font = new System.Drawing.Font("Consolas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.information_label.Location = new System.Drawing.Point(207, 278);
            this.information_label.Name = "information_label";
            this.information_label.Size = new System.Drawing.Size(802, 75);
            this.information_label.TabIndex = 0;
            this.information_label.Text = "System initializing...";
            // 
            // processesloading_label
            // 
            this.processesloading_label.AutoSize = true;
            this.processesloading_label.BackColor = System.Drawing.Color.Black;
            this.processesloading_label.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processesloading_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.processesloading_label.Location = new System.Drawing.Point(862, 586);
            this.processesloading_label.Name = "processesloading_label";
            this.processesloading_label.Size = new System.Drawing.Size(298, 24);
            this.processesloading_label.TabIndex = 1;
            this.processesloading_label.Text = "processes are loading...";
            // 
            // background_label
            // 
            this.background_label.AutoSize = true;
            this.background_label.BackColor = System.Drawing.Color.Black;
            this.background_label.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.background_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.background_label.Location = new System.Drawing.Point(862, 619);
            this.background_label.Name = "background_label";
            this.background_label.Size = new System.Drawing.Size(214, 24);
            this.background_label.TabIndex = 2;
            this.background_label.Text = "in the background";
            // 
            // loading_timer
            // 
            this.loading_timer.Interval = 1000;
            this.loading_timer.Tick += new System.EventHandler(this.loading_timer_Tick);
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.BackColor = System.Drawing.Color.Black;
            this.timer_label.Font = new System.Drawing.Font("Consolas", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.ForeColor = System.Drawing.Color.OrangeRed;
            this.timer_label.Location = new System.Drawing.Point(383, 388);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(569, 41);
            this.timer_label.TabIndex = 3;
            this.timer_label.Text = "calculating remaining time...";
            // 
            // SystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::application_database.Properties.Resources.loading_wallpaper;
            this.ClientSize = new System.Drawing.Size(1172, 652);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.background_label);
            this.Controls.Add(this.processesloading_label);
            this.Controls.Add(this.information_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "SystemForm";
            this.Text = "<system>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label information_label;
        private System.Windows.Forms.Label processesloading_label;
        private System.Windows.Forms.Label background_label;
        private System.Windows.Forms.Timer loading_timer;
        private System.Windows.Forms.Label timer_label;
    }
}