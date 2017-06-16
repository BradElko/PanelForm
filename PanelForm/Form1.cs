using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomForm_Practice_1
{
    public partial class CustomForm : Form
    {
        public static bool MouseRightClickOverForm;
        public static rightClickMenu rightclickmenuform;
        public bool  mouseEnteredTopPanel, mouseEnteredBotPanel, mouseEnteredForm;
        bool minimizeB1MouseDown, maximizeB1MouseDown, exitB1MouseDown;
        bool maximizeB1WasPressed;
        bool FormNormalSize;
        bool AdjustingTheForm, MovingFormMinimized, MovingFormMaximized;
        bool mouseHuggingWall;
        Point LastLocation, NewLocation;
        Rectangle scr;
        public CustomForm()
        {
            InitializeComponent();
            rightclickmenuform = new rightClickMenu();
            FormNormalSize = true;
        }
        public void RightClickMenuSetup(MouseEventArgs e)
        {
            if (MouseRightClickOverForm)
            {
                //Left
                if((e.X > 8 && e.Y > 9) &&
                   (e.X <= BottomPanel.Width / 2 && e.Y <= BottomPanel.Height / 2))
                { 
                    rightclickmenuform.Show();
                    rightclickmenuform.Location = new Point(Cursor.Position.X - 3, Cursor.Position.Y - 3);
                    rightclickmenuform.BringToFront();
                }
                //Right
                else if((BottomPanel.Width - e.X > 8 && e.Y > 9) &&
                        (e.X > BottomPanel.Width / 2 && e.Y <= BottomPanel.Height / 2))
                {
                    rightclickmenuform.Show();
                    rightclickmenuform.Location = new Point(Cursor.Position.X - rightclickmenuform.Width + 3, Cursor.Position.Y - 3);
                    rightclickmenuform.BringToFront();
                }
                //Bottom Left
                else if((e.X > 8 && BottomPanel.Width - e.Y > 9) &&
                        (e.X <= BottomPanel.Width / 2 && e.Y > BottomPanel.Height / 2))
                {
                    rightclickmenuform.Show();
                    rightclickmenuform.Location = new Point(Cursor.Position.X - 3, Cursor.Position.Y - rightclickmenuform.Height + 3);
                    rightclickmenuform.BringToFront();
                }
                //Bottom Right
                else if((BottomPanel.Width - e.X > 8 && BottomPanel.Width - e.Y > 9) &&
                        (e.X > BottomPanel.Width / 2 && e.Y > BottomPanel.Height / 2))
                {
                    rightclickmenuform.Show();
                    rightclickmenuform.Location = new Point(Cursor.Position.X - rightclickmenuform.Width + 3, Cursor.Position.Y - rightclickmenuform.Height + 3);
                    rightclickmenuform.BringToFront();
                }
                MouseRightClickOverForm = false;
            }
        }
        private void CustomForm_Resize(object sender, EventArgs e)
        {
            scr = Screen.FromControl(this).WorkingArea;
            if (FormNormalSize == false)
            //Maximized Window
            {
                this.Location = new Point(scr.X, scr.Y);
                this.Size = new Size(scr.Width, scr.Height);
                this.Update();
                //Panel Heights
                TopPanel.Height = 30;
                BottomPanel.Height = scr.Height - 32;
                //Panel Widths
                TopPanel.Width = scr.Width - 2;
                BottomPanel.Width = scr.Width - 2;
            }
            else if (FormNormalSize)
            //Normal Window
            {
                this.Size = new Size(800, 600);
                if (this.Location == new Point(scr.X, scr.Y) && maximizeB1WasPressed)
                {
                    this.Location = new Point(scr.X + scr.Width/2 - 400, scr.Y + scr.Height/2 - 300);
                    maximizeB1WasPressed = false;
                }
                this.Update();
                //Panel Heights
                TopPanel.Height = 30;
                BottomPanel.Height = this.Height - 32;
                //Panel Widths
                TopPanel.Width = this.Width - 2;
                BottomPanel.Width = this.Width - 2;
            }
            //Panel Locations
            TopPanel.Location = new Point(1, 1);
            BottomPanel.Location = new Point(1, TopPanel.Height + 1);
        }
        private void CustomForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                Color.Red, 1, ButtonBorderStyle.Solid,
                Color.Red, 1, ButtonBorderStyle.Solid,
                Color.Red, 1, ButtonBorderStyle.Solid,
                Color.Red, 1, ButtonBorderStyle.Solid);
        }
        private void CustomForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClickOverForm = true;
            }
        }
        private void TopPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AdjustingTheForm = false;
        }
        private void TopPanel_Click(object sender, EventArgs e)
        {
            AdjustingTheForm = false;
        }
        private void TopPanel_MouseClick(object sender, MouseEventArgs e)
        {
            AdjustingTheForm = false;
        }
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                AdjustingTheForm = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                AdjustingTheForm = false;
            }
            LastLocation = e.Location;
        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            scr = Screen.FromControl(this).WorkingArea;
            if (AdjustingTheForm)
            {
                if (FormNormalSize == false)
                {
                    FormNormalSize = true;
                    CustomForm_Resize(sender, e);
                    this.Location = new Point(Cursor.Position.X - 400, Cursor.Position.Y - 15);
                    this.Update();
                    NewLocation = new Point(scr.X + e.X, scr.Y + e.Y);
                    LastLocation = PointToClient(NewLocation);
                    MovingFormMaximized = true;
                }
                else
                {
                    MovingFormMinimized = true;
                }
                AdjustingTheForm = false;
            }
            if ((MovingFormMinimized && this.Location.Y > 0) || (MovingFormMinimized && this.Location.Y <= 0 && e.Y > 32))
            {
                mouseHuggingWall = false;
                this.Location = new Point(this.Location.X - LastLocation.X + e.X,
                    this.Location.Y - LastLocation.Y + e.Y);
                this.Update();
            }
            else if (MovingFormMinimized && this.Location.Y <= 0)
            {
                mouseHuggingWall = true;
                this.Location = new Point(this.Location.X - LastLocation.X + e.X, 0);
                this.Update();
            }
            if ((MovingFormMaximized && this.Location.Y > 0) || (MovingFormMaximized && this.Location.Y <= 0 && e.Y > 32))
            {
                mouseHuggingWall = false;
                this.Location = new Point(this.Location.X -LastLocation.X + e.X,
                    this.Location.Y - LastLocation.Y + e.Y);
                this.Update();
            }
            else if (MovingFormMaximized && this.Location.Y <= 0)
            {
                mouseHuggingWall = true;
                this.Location = new Point(this.Location.X - LastLocation.X + e.X, 0);
                this.Update();
            }
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            scr = Screen.FromControl(this).WorkingArea;
            if(mouseHuggingWall == true)
            {
                FormNormalSize = false;
                CustomForm_Resize(sender, e);
            }
            MovingFormMinimized = false;
            MovingFormMaximized = false;
            mouseHuggingWall = false;
        }
        private void BottomPanel_MouseClick(object sender, MouseEventArgs e)
        {
            AdjustingTheForm = false;
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClickOverForm = true;
                RightClickMenuSetup(e);
            }
        }
        private void minimizeB1_Paint(object sender, PaintEventArgs e)
        {
            if(minimizeB1MouseDown == false)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 10, 15, 30, 15);
            }
            else
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.DrawLine(new Pen(Color.White, 2), 10, 15, 30, 15);
            }
        }
        private void minimizeB1_MouseDown(object sender, MouseEventArgs e)
        {
            minimizeB1MouseDown = true;
            AdjustingTheForm = false;
        }

        private void minimizeB1_MouseUp(object sender, MouseEventArgs e)
        {
            minimizeB1MouseDown = false;
            WindowState = FormWindowState.Minimized;
        }
        private void maximizeB1_Paint(object sender, PaintEventArgs e)
        {
            if(maximizeB1MouseDown == false)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), 10, 5, 19, 19);
            }
            else
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.DrawRectangle(new Pen(Color.DarkGray, 2), 10, 5, 19, 19);
            }
        }
        private void maximizeB1_MouseDown(object sender, MouseEventArgs e)
        {
            maximizeB1MouseDown = true;
            AdjustingTheForm = false;
        }
        private void maximizeB1_MouseUp(object sender, MouseEventArgs e)
        {
            maximizeB1MouseDown = false;
            if (FormNormalSize == false)
            {
                maximizeB1WasPressed = true;
                FormNormalSize = true;
            }
            else if (FormNormalSize == true)
            {
                FormNormalSize = false;
            }
            CustomForm_Resize(sender, e);
        }
        private void exitB1_Paint(object sender, PaintEventArgs e)
        {
            if(exitB1MouseDown == false)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 10, 5, 30, 25);
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 30, 5, 10, 25);
            }
            else
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.DrawLine(new Pen(Color.Red, 2), 10, 5, 30, 25);
                e.Graphics.DrawLine(new Pen(Color.Red, 2), 30, 5, 10, 25);
            }
        }
        private void exitB1_MouseDown(object sender, MouseEventArgs e)
        {
            exitB1MouseDown = true;
            AdjustingTheForm = false;
        }
        private void exitB1_MouseUp(object sender, MouseEventArgs e)
        {
            exitB1MouseDown = false;
            this.Close();
        }
    }
}
