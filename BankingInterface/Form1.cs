using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace BankingInterface
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nToprect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );


        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PNLNav.Height = BtnProfile.Height;
            PNLNav.Top = BtnProfile.Top;
            PNLNav.Left = BtnProfile.Left;
            BtnProfile.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            PNLNav.Height = BtnProfile.Height;
            PNLNav.Top = BtnProfile.Top;
            PNLNav.Left = BtnProfile.Left;
            BtnProfile.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnAccountBalance_Click(object sender, EventArgs e)
        {
            PNLNav.Height = BtnAccountBalance.Height;
            PNLNav.Top = BtnAccountBalance.Top;
            PNLNav.Left = BtnAccountBalance.Left;
            BtnAccountBalance.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnStatements_Click(object sender, EventArgs e)
        {
            PNLNav.Height = BtnStatements.Height;
            PNLNav.Top = BtnStatements.Top;
            PNLNav.Left = BtnStatements.Left;
            BtnStatements.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnSatistics_Click(object sender, EventArgs e)
        {
            PNLNav.Height = BtnSatistics.Height;
            PNLNav.Top = BtnSatistics.Top;
            PNLNav.Left = BtnSatistics.Left;
            BtnSatistics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            PNLNav.Height = BtnLogout.Height;
            PNLNav.Top = BtnLogout.Top;
            PNLNav.Left = BtnLogout.Left;
            BtnLogout.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void BtnProfile_Leave(object sender, EventArgs e)
        {
            BtnProfile.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void BtnAccountBalance_Leave(object sender, EventArgs e)
        {
            BtnAccountBalance.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void BtnStatements_Leave(object sender, EventArgs e)
        {
            BtnStatements.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void BtnSatistics_Leave(object sender, EventArgs e)
        {
            BtnSatistics.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void BtnLogout_Leave(object sender, EventArgs e)
        {
            BtnLogout.BackColor = Color.FromArgb(24, 30, 54);
        }

        
    }
}
