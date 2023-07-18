namespace App.Controlls
{
    partial class ConfigMenu
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fileConfigurationBox = new System.Windows.Forms.TextBox();
            this.autominConfigurationBox = new System.Windows.Forms.CheckBox();
            this.autorunConfigurationBox = new System.Windows.Forms.CheckBox();
            this.pathInfo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.configSaveButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.fileConfigurationBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.autominConfigurationBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.autorunConfigurationBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pathInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.configSaveButton, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // fileConfigurationBox
            // 
            this.fileConfigurationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileConfigurationBox.Location = new System.Drawing.Point(163, 33);
            this.fileConfigurationBox.Name = "fileConfigurationBox";
            this.fileConfigurationBox.Size = new System.Drawing.Size(265, 20);
            this.fileConfigurationBox.TabIndex = 1;
            this.fileConfigurationBox.Click += new System.EventHandler(this.fileConfigurationBox_Click);
            // 
            // autominConfigurationBox
            // 
            this.autominConfigurationBox.AutoSize = true;
            this.autominConfigurationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autominConfigurationBox.Location = new System.Drawing.Point(163, 63);
            this.autominConfigurationBox.Name = "autominConfigurationBox";
            this.autominConfigurationBox.Size = new System.Drawing.Size(265, 24);
            this.autominConfigurationBox.TabIndex = 0;
            this.autominConfigurationBox.UseVisualStyleBackColor = true;
            this.autominConfigurationBox.CheckedChanged += new System.EventHandler(this.autominConfigurationBox_CheckedChanged);
            // 
            // autorunConfigurationBox
            // 
            this.autorunConfigurationBox.AutoSize = true;
            this.autorunConfigurationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autorunConfigurationBox.Location = new System.Drawing.Point(163, 93);
            this.autorunConfigurationBox.Name = "autorunConfigurationBox";
            this.autorunConfigurationBox.Size = new System.Drawing.Size(265, 24);
            this.autorunConfigurationBox.TabIndex = 2;
            this.autorunConfigurationBox.UseVisualStyleBackColor = true;
            this.autorunConfigurationBox.CheckedChanged += new System.EventHandler(this.autorunConfigurationBox_CheckedChanged);
            // 
            // pathInfo
            // 
            this.pathInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathInfo.Location = new System.Drawing.Point(3, 33);
            this.pathInfo.Name = "pathInfo";
            this.pathInfo.ReadOnly = true;
            this.pathInfo.Size = new System.Drawing.Size(154, 20);
            this.pathInfo.TabIndex = 3;
            this.pathInfo.Text = "Scieżka";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Automatyczna minimalizacja";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(3, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(154, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Automatyczne uruchamianie";
            // 
            // configSaveButton
            // 
            this.configSaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configSaveButton.Location = new System.Drawing.Point(3, 503);
            this.configSaveButton.Name = "configSaveButton";
            this.configSaveButton.Size = new System.Drawing.Size(154, 24);
            this.configSaveButton.TabIndex = 6;
            this.configSaveButton.Text = "Zapisz";
            this.configSaveButton.UseVisualStyleBackColor = true;
            this.configSaveButton.Click += new System.EventHandler(this.configSaveButton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // ConfigMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConfigMenu";
            this.Size = new System.Drawing.Size(431, 530);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox autominConfigurationBox;
        private System.Windows.Forms.TextBox fileConfigurationBox;
        private System.Windows.Forms.CheckBox autorunConfigurationBox;
        private System.Windows.Forms.TextBox pathInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button configSaveButton;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}
