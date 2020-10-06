namespace application_database
{
    partial class AppsInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppsInformation));
            this.information_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // information_label
            // 
            resources.ApplyResources(this.information_label, "information_label");
            this.information_label.ForeColor = System.Drawing.Color.IndianRed;
            this.information_label.Name = "information_label";
            this.information_label.UseCompatibleTextRendering = true;
            // 
            // AppsInformation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.information_label);
            this.Name = "AppsInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label information_label;
    }
}