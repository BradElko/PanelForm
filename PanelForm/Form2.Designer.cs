namespace CustomForm_Practice_1
{
    partial class rightClickMenu
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
            this.rcmMenuPanel = new System.Windows.Forms.Panel();
            this.rcmMenuLabel = new System.Windows.Forms.Label();
            this.rcmSetupPanel = new System.Windows.Forms.Panel();
            this.rcmSetupLabel = new System.Windows.Forms.Label();
            this.OverPanel = new CustomForm_Practice_1.ExtendedPanel();
            this.rcmMenuPanel.SuspendLayout();
            this.rcmSetupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rcmMenuPanel
            // 
            this.rcmMenuPanel.BackColor = System.Drawing.Color.DimGray;
            this.rcmMenuPanel.Controls.Add(this.rcmMenuLabel);
            this.rcmMenuPanel.Location = new System.Drawing.Point(1, 1);
            this.rcmMenuPanel.Name = "rcmMenuPanel";
            this.rcmMenuPanel.Size = new System.Drawing.Size(150, 30);
            this.rcmMenuPanel.TabIndex = 0;
            // 
            // rcmMenuLabel
            // 
            this.rcmMenuLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcmMenuLabel.Location = new System.Drawing.Point(11, 0);
            this.rcmMenuLabel.Name = "rcmMenuLabel";
            this.rcmMenuLabel.Size = new System.Drawing.Size(128, 30);
            this.rcmMenuLabel.TabIndex = 1;
            this.rcmMenuLabel.Text = "Menu";
            this.rcmMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rcmSetupPanel
            // 
            this.rcmSetupPanel.BackColor = System.Drawing.Color.Silver;
            this.rcmSetupPanel.Controls.Add(this.rcmSetupLabel);
            this.rcmSetupPanel.Location = new System.Drawing.Point(1, 31);
            this.rcmSetupPanel.Name = "rcmSetupPanel";
            this.rcmSetupPanel.Size = new System.Drawing.Size(150, 30);
            this.rcmSetupPanel.TabIndex = 1;
            // 
            // rcmSetupLabel
            // 
            this.rcmSetupLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcmSetupLabel.Location = new System.Drawing.Point(11, 0);
            this.rcmSetupLabel.Name = "rcmSetupLabel";
            this.rcmSetupLabel.Size = new System.Drawing.Size(128, 30);
            this.rcmSetupLabel.TabIndex = 0;
            this.rcmSetupLabel.Text = "Setup";
            this.rcmSetupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverPanel
            // 
            this.OverPanel.BackColor = System.Drawing.Color.Transparent;
            this.OverPanel.Location = new System.Drawing.Point(1, 1);
            this.OverPanel.Name = "OverPanel";
            this.OverPanel.Opacity = 0;
            this.OverPanel.Size = new System.Drawing.Size(152, 62);
            this.OverPanel.TabIndex = 3;
            this.OverPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OverPanel_MouseDown);
            this.OverPanel.MouseLeave += new System.EventHandler(this.OverPanel_MouseLeave);
            this.OverPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OverPanel_MouseMove);
            this.OverPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OverPanel_MouseUp);
            // 
            // rightClickMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 62);
            this.Controls.Add(this.OverPanel);
            this.Controls.Add(this.rcmMenuPanel);
            this.Controls.Add(this.rcmSetupPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rightClickMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.rightClickMenu_Paint);
            this.rcmMenuPanel.ResumeLayout(false);
            this.rcmSetupPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rcmMenuPanel;
        private System.Windows.Forms.Panel rcmSetupPanel;
        private System.Windows.Forms.Label rcmMenuLabel;
        private System.Windows.Forms.Label rcmSetupLabel;
        private ExtendedPanel OverPanel;
    }
}