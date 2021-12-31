using Final_Project_CNPM.MenuTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_CNPM
{
    public partial class HomePage : Form
    {
        private Form activeForm;

        public HomePage()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WareHouse());
        }
    }
}
