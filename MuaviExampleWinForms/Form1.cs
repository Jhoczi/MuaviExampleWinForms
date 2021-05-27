using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuaviExampleWinForms
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
             
            if (panelPlaylistSubMenu.Visible == true)
                panelPlaylistSubMenu.Visible = false;
            
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;        
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #region MediaSubMenu 
        private void btnMedia_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMediaSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
            
            // Code
            HideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Code
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Code
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Code
            HideSubMenu();
        }
        #endregion
        #region PlaylistMenagementSubMenu
        private void btnPlaylistMenagement_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPlaylistSubMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Code
            HideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Code
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Code
            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Code
            HideSubMenu();
        }
        #endregion
        #region ToolsSubmenu
        private void btnTools_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelToolsSubMenu);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Code
            HideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Code
            HideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Code
            HideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Code
            HideSubMenu();
        }
        #endregion
        private Form activeForm = null;
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonEqualizer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());;
            HideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

       
    }
}
