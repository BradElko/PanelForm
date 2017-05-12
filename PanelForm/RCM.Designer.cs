namespace CustomForm_Practice_1
{
    partial class rcm
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

        #region Component Designer generated code

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
            this.rcmMenuPanel.SuspendLayout();
            this.rcmSetupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rcmMenuPanel
            // 
            this.rcmMenuPanel.BackColor = System.Drawing.Color.DimGray;
            this.rcmMenuPanel.Controls.Add(this.rcmMenuLabel);
            this.rcmMenuPanel.Location = new System.Drawing.Point(1, 60);
            this.rcmMenuPanel.Name = "rcmMenuPanel";
            this.rcmMenuPanel.Size = new System.Drawing.Size(150, 30);
            this.rcmMenuPanel.TabIndex = 0;
            // 
            // rcmMenuLabel
            // 
            this.rcmMenuLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcmMenuLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rcmMenuLabel.Location = new System.Drawing.Point(21, 0);
            this.rcmMenuLabel.Name = "rcmMenuLabel";
            this.rcmMenuLabel.Size = new System.Drawing.Size(109, 30);
            this.rcmMenuLabel.TabIndex = 0;
            this.rcmMenuLabel.Text = "Menu";
            this.rcmMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rcmSetupPanel
            // 
            this.rcmSetupPanel.BackColor = System.Drawing.Color.Silver;
            this.rcmSetupPanel.Controls.Add(this.rcmSetupLabel);
            this.rcmSetupPanel.Location = new System.Drawing.Point(1, 157);
            this.rcmSetupPanel.Name = "rcmSetupPanel";
            this.rcmSetupPanel.Size = new System.Drawing.Size(150, 30);
            this.rcmSetupPanel.TabIndex = 1;
            // 
            // rcmSetupLabel
            // 
            this.rcmSetupLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcmSetupLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rcmSetupLabel.Location = new System.Drawing.Point(21, 0);
            this.rcmSetupLabel.Name = "rcmSetupLabel";
            this.rcmSetupLabel.Size = new System.Drawing.Size(109, 30);
            this.rcmSetupLabel.TabIndex = 0;
            this.rcmSetupLabel.Text = "Setup";
            this.rcmSetupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rcmSetupPanel);
            this.Controls.Add(this.rcmMenuPanel);
            this.Name = "rcm";
            this.Size = new System.Drawing.Size(152, 300);
            this.Load += new System.EventHandler(this.rcm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.rcm_Paint);
            this.rcmMenuPanel.ResumeLayout(false);
            this.rcmSetupPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rcmMenuPanel;
        private System.Windows.Forms.Label rcmMenuLabel;
        private System.Windows.Forms.Panel rcmSetupPanel;
        private System.Windows.Forms.Label rcmSetupLabel;
    }
}
