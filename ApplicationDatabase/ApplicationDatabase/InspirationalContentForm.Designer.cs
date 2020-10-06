namespace application_database
{
    partial class InspirationalContentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspirationalContentForm));
            this.inspirational_image_label = new System.Windows.Forms.Label();
            this.prev_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inspirational_image_label
            // 
            this.inspirational_image_label.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspirational_image_label.ForeColor = System.Drawing.Color.IndianRed;
            this.inspirational_image_label.Location = new System.Drawing.Point(12, 9);
            this.inspirational_image_label.Name = "inspirational_image_label";
            this.inspirational_image_label.Size = new System.Drawing.Size(1200, 726);
            this.inspirational_image_label.TabIndex = 1;
            this.inspirational_image_label.Text = "There will be some photos";
            this.inspirational_image_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.inspirational_image_label.UseCompatibleTextRendering = true;
            // 
            // prev_button
            // 
            this.prev_button.BackColor = System.Drawing.SystemColors.Control;
            this.prev_button.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_button.ForeColor = System.Drawing.Color.IndianRed;
            this.prev_button.Location = new System.Drawing.Point(12, 738);
            this.prev_button.Name = "prev_button";
            this.prev_button.Size = new System.Drawing.Size(216, 77);
            this.prev_button.TabIndex = 17;
            this.prev_button.Text = "<--prev";
            this.prev_button.UseVisualStyleBackColor = false;
            this.prev_button.Click += new System.EventHandler(this.prev_button_Click);
            this.prev_button.MouseEnter += new System.EventHandler(this.prev_button_MouseEnter);
            this.prev_button.MouseLeave += new System.EventHandler(this.prev_button_MouseLeave);
            // 
            // next_button
            // 
            this.next_button.BackColor = System.Drawing.SystemColors.Control;
            this.next_button.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.ForeColor = System.Drawing.Color.IndianRed;
            this.next_button.Location = new System.Drawing.Point(996, 738);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(216, 77);
            this.next_button.TabIndex = 18;
            this.next_button.Text = "next-->";
            this.next_button.UseVisualStyleBackColor = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            this.next_button.MouseEnter += new System.EventHandler(this.next_button_MouseEnter);
            this.next_button.MouseLeave += new System.EventHandler(this.next_button_MouseLeave);
            // 
            // InspirationalContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1224, 827);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.prev_button);
            this.Controls.Add(this.inspirational_image_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InspirationalContentForm";
            this.Text = "<Inspirational Content>";
            this.Load += new System.EventHandler(this.InspirationalTextForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label inspirational_image_label;
        private System.Windows.Forms.Button prev_button;
        private System.Windows.Forms.Button next_button;
    }
}