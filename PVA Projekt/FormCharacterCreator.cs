using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PVA_Projekt.CharacterClasses;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PVA_Projekt
{
    public partial class FormCharacterCreator : Form
    {
        public FormCharacterCreator()
        {
            InitializeComponent();
        }

        private void FormCharacterCreator_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_CharacterClass_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_CharacterClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_SaveCharacter_Click(object sender, EventArgs e)
        {     
            //Make sure name is not blank or a space
            string name;
            if (String.IsNullOrEmpty(Txt_CharacterName.Text) || Txt_CharacterName.Text[0] == ' ')
            {
                MessageBox.Show("You must name your character");
                return;
            }

            name = this.Txt_CharacterName.Text;

            //Check gender
            EntityGender eGender = new EntityGender();
            if (this.Rdo_GenderMale.Checked)
                eGender = EntityGender.Male;
            else if (this.Rdo_GenderFemale.Checked)
                eGender = EntityGender.Female;
            else 
            {
                MessageBox.Show("You must select a gender!");
                return;
            }

            //Check the class
            EntityClass eClass = new EntityClass();
            if (this.Cbo_CharacterClass.Text == "Mage")
                eClass = EntityClass.Mage;
            else if (this.Cbo_CharacterClass.Text == "Cleric")
                eClass = EntityClass.Cleric;
            else if (this.Cbo_CharacterClass.Text == "Warrior")
                eClass = EntityClass.Warrior;
            else if (this.Cbo_CharacterClass.Text == "Rogue")
                eClass = EntityClass.Rogue;
            else if (this.Cbo_CharacterClass.Text == "Cleric")
                eClass = EntityClass.Paladin;
            else
            {
                MessageBox.Show("You must select a Class for your character!");
                return;
            }

            //Create object\
            Player player1 = new Player(name, eGender, eClass);

            string output;
            output = string.Format("You created a character. \n" +
                "Your name is: {0} \nYour gender is: {1} \n"
                "Your class is: {2}.", player1.Name, player1.Gender.ToString(), player1.CharacterClass.ToString());

            MessageBox.Show(output, "Success");

            this.Close();
        }
    }
}
