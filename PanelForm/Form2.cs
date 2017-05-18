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
        //private
        bool mouseInControl;
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
        public static void RightClickMenuSetup()
        {
            if (CustomForm.MouseRightClickOverForm)
            {
                CustomForm.rightclickmenuform.Show();
                CustomForm.rightclickmenuform.Location = new Point(Cursor.Position.X - 3, Cursor.Position.Y - 3);
                CustomForm.rightclickmenuform.BringToFront();
                CustomForm.MouseRightClickOverForm = false;
            }
        }
        private void OverPanel_MouseLeave(object sender, EventArgs e)
        {
            CustomForm.rightclickmenuform.Hide();
        }
    }
}
