using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace CustomForm_Practice_1
{
    public partial class rightClickMenu : Form
    {
        private bool OverRCMSP;
        public rightClickMenu()
        {
            InitializeComponent();
        }
        private void rightClickMenu_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                Color.Red, 1, ButtonBorderStyle.Solid,
                Color.Red, 1, ButtonBorderStyle.Solid,
                Color.Red, 1, ButtonBorderStyle.Solid,
                Color.Red, 1, ButtonBorderStyle.Solid);
        }
        private void OverPanel_MouseLeave(object sender, EventArgs e)
        {
            CustomForm.rightclickmenuform.Hide();
        }
        private void OverPanel_MouseMove(object sender, MouseEventArgs e)
        {
            var rcmSPCP = rcmSetupPanel.PointToClient(Cursor.Position);
            if (ClientRectangle.Contains(rcmSPCP)){
                rcmSetupPanel.BackColor = Color.DimGray;
                OverRCMSP = true;
            }
            else
            {
                rcmSetupPanel.BackColor = Color.Silver;
                OverRCMSP = false;
            }
        }
        private void OverPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (OverRCMSP)
            {
                rcmSetupLabel.ForeColor = Color.White;
                OverRCMSP = true;
            }
            else
            {
                rcmSetupLabel.ForeColor = Color.Black;
                OverRCMSP = false;
            }
        }
        private void OverPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (OverRCMSP)
            {
                OverRCMSP = false;
                rcmSetupLabel.ForeColor = Color.Black;
                CustomForm.rightclickmenuform.Hide();
            }
        }
    }
}
