namespace Ksu.Cis300.TextEditor
{
    partial class UserInterface
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
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxSaveFD = new System.Windows.Forms.SaveFileDialog();
            this.uxOpenFD = new System.Windows.Forms.OpenFileDialog();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(372, 24);
            this.uxMenuStrip.TabIndex = 0;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenTSMI,
            this.uxSaveTSMI});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uxOpenTSMI
            // 
            this.uxOpenTSMI.Name = "uxOpenTSMI";
            this.uxOpenTSMI.Size = new System.Drawing.Size(180, 22);
            this.uxOpenTSMI.Text = "Open";
            this.uxOpenTSMI.Click += new System.EventHandler(this.uxOpenTSMI_Click);
            // 
            // uxSaveTSMI
            // 
            this.uxSaveTSMI.Name = "uxSaveTSMI";
            this.uxSaveTSMI.Size = new System.Drawing.Size(180, 22);
            this.uxSaveTSMI.Text = "Save As";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 141);
            this.textBox1.TabIndex = 1;
            // 
            // uxSaveFD
            // 
            this.uxSaveFD.FileOk += new System.ComponentModel.CancelEventHandler(this.uxSaveFD_FileOk);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 181);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxOpenTSMI;
        private System.Windows.Forms.ToolStripMenuItem uxSaveTSMI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog uxSaveFD;
        private System.Windows.Forms.OpenFileDialog uxOpenFD;
    }
}

