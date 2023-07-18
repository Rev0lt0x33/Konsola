namespace App
{
    partial class ConfigWindow
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
            this.configMenu2 = new App.Controlls.ConfigMenu();
            this.SuspendLayout();

            // 
            // configMenu2
            // 
            this.configMenu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configMenu2.Location = new System.Drawing.Point(0, 0);
            this.configMenu2.Name = "configMenu2";
            this.configMenu2.Size = new System.Drawing.Size(800, 450);
            this.configMenu2.TabIndex = 0;
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.configMenu2);
            this.Name = "ConfigWindow";
            this.Text = "ConfigWindow";
            this.ResumeLayout(false);

        }

        #endregion
        private Controlls.ConfigMenu configMenu2;
    }
}