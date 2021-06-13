using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVA_Projekt
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Btn_CreateChar_Click(object sender, EventArgs e)
        {
            FormCharacterCreator charcreator = new FormCharacterCreator();
            charcreator.Show();
        }
    }
}
