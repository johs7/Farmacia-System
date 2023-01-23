using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1.Formularios
{
    public partial class FormAlert : Form
    {
        public FormAlert()
        {
            InitializeComponent();
        }
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private FormAlert.enmAction action;
        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case FormAlert.enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = FormAlert.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        this.Close();
                    }
                    break;
            }
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "Bienvenido" + i.ToString();
                FormAlert frm = (FormAlert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 7;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 3;

            switch (type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Resources._checked;
                    this.BackColor = Color.FromArgb(181, 228, 140);
                    break;
                case enmType.Info:
                    this.pictureBox1.Image = Resources.information_sign;
                    this.BackColor = Color.FromArgb(74, 78, 105);
                    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Resources.trash;
                    this.BackColor = Color.FromArgb(102, 7, 8);
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.exclamation_mark;
                    this.BackColor = Color.FromArgb(102, 7, 8);
                    break;


            }


            this.lblMsg.Text = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
    }
}
