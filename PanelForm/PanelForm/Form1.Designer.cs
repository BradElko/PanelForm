namespace CustomForm_Practice_1
{
    partial class CustomForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.minimizeB1 = new CustomForm_Practice_1.FlatButton();
            this.maximizeB1 = new CustomForm_Practice_1.FlatButton();
            this.exitB1 = new CustomForm_Practice_1.FlatButton();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DimGray;
            this.TopPanel.Controls.Add(this.minimizeB1);
            this.TopPanel.Controls.Add(this.maximizeB1);
            this.TopPanel.Controls.Add(this.exitB1);
            this.TopPanel.Location = new System.Drawing.Point(69, 32);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(663, 60);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Click += new System.EventHandler(this.TopPanel_Click);
            this.TopPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseClick);
            this.TopPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDoubleClick);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // minimizeB1
            // 
            this.minimizeB1.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeB1.FlatAppearance.BorderSize = 0;
            this.minimizeB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeB1.ForeColor = System.Drawing.Color.Black;
            this.minimizeB1.Location = new System.Drawing.Point(543, 0);
            this.minimizeB1.Name = "minimizeB1";
            this.minimizeB1.Size = new System.Drawing.Size(40, 60);
            this.minimizeB1.TabIndex = 2;
            this.minimizeB1.UseVisualStyleBackColor = true;
            this.minimizeB1.Paint += new System.Windows.Forms.PaintEventHandler(this.minimizeB1_Paint);
            this.minimizeB1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minimizeB1_MouseDown);
            this.minimizeB1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minimizeB1_MouseUp);
            // 
            // maximizeB1
            // 
            this.maximizeB1.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizeB1.FlatAppearance.BorderSize = 0;
            this.maximizeB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeB1.ForeColor = System.Drawing.Color.Black;
            this.maximizeB1.Location = new System.Drawing.Point(583, 0);
            this.maximizeB1.Name = "maximizeB1";
            this.maximizeB1.Size = new System.Drawing.Size(40, 60);
            this.maximizeB1.TabIndex = 1;
            this.maximizeB1.UseVisualStyleBackColor = true;
            this.maximizeB1.Paint += new System.Windows.Forms.PaintEventHandler(this.maximizeB1_Paint);
            this.maximizeB1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.maximizeB1_MouseDown);
            this.maximizeB1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.maximizeB1_MouseUp);
            // 
            // exitB1
            // 
            this.exitB1.BackColor = System.Drawing.Color.DimGray;
            this.exitB1.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitB1.FlatAppearance.BorderSize = 0;
            this.exitB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitB1.ForeColor = System.Drawing.Color.Black;
            this.exitB1.Location = new System.Drawing.Point(623, 0);
            this.exitB1.Name = "exitB1";
            this.exitB1.Size = new System.Drawing.Size(40, 60);
            this.exitB1.TabIndex = 0;
            this.exitB1.UseVisualStyleBackColor = false;
            this.exitB1.Paint += new System.Windows.Forms.PaintEventHandler(this.exitB1_Paint);
            this.exitB1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitB1_MouseDown);
            this.exitB1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitB1_MouseUp);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.Silver;
            this.BottomPanel.Location = new System.Drawing.Point(140, 140);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(520, 275);
            this.BottomPanel.TabIndex = 1;
            this.BottomPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseClick);
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CustomForm_MouseClick);
            this.Resize += new System.EventHandler(this.CustomForm_Resize);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private FlatButton exitB1;
        private FlatButton minimizeB1;
        private FlatButton maximizeB1;
    }
}

