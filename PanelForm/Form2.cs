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
        //private static
        private static rightClickMenu AddEvents = new rightClickMenu();
        private static bool rcmTimerFinished;
        private static Timer rcmTimer = new Timer();
        //private
        bool mouseInControl;
        public rightClickMenu()
        {
            InitializeComponent();
        }
        private void OverPanel_Paint(object sender, PaintEventArgs e)
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
                CustomForm.rightclickmenuform.Location = new Point(Cursor.Position.X + 1, Cursor.Position.Y + 1);
                CustomForm.rightclickmenuform.BringToFront();
                CustomForm.MouseRightClickOverForm = false;
                rcmTimer.Interval = 1500;
                rcmTimer.Start();
                rcmTimer.Tick += rcmTimer_Tick;
            }
        }
        public static void HideRightClickMenu()
        {
            if (rcmTimerFinished)
            {
                CustomForm.rightclickmenuform.Hide();
            }
        }
        private bool MouseInControl(Control ctrl)
        {
            mouseInControl = ctrl.ClientRectangle.Contains(PointToClient(Control.MousePosition));
            if(mouseInControl)
            {
                rcmTimer.Stop();
                rcmTimer.Interval = 1500;
            }
            else
            {
                CustomForm.rightclickmenuform.Hide();
            }
            //Console.WriteLine(mouseInControl);
            return mouseInControl;
        }
        private static void rcmTimer_Tick(object sender, EventArgs e)
        {
            rcmTimerFinished = true;
            rcmTimer.Stop();
            rcmTimer.Interval = 1500;
            HideRightClickMenu();
        }
        private void OverPanel_MouseEnter(object sender, EventArgs e)
        {
            rcmTimer.Stop();
            rcmTimer.Interval = 1500;
        }
        private void OverPanel_MouseLeave(object sender, EventArgs e)
        {
            CustomForm.rightclickmenuform.Hide();
        }
    }
}
