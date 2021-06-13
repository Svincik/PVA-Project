
namespace PVA_Projekt
{
    partial class FormCharacterCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCharacterCreator));
            this.Lbl_CharacterName = new System.Windows.Forms.Label();
            this.Txt_CharacterName = new System.Windows.Forms.TextBox();
            this.Gbox_Gender = new System.Windows.Forms.GroupBox();
            this.Rdo_GenderFemale = new System.Windows.Forms.RadioButton();
            this.Rdo_GenderMale = new System.Windows.Forms.RadioButton();
            this.Cbo_CharacterClass = new System.Windows.Forms.ComboBox();
            this.Lbl_CharacterClass = new System.Windows.Forms.Label();
            this.Btn_SaveCharacter = new System.Windows.Forms.Button();
            this.Gbox_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_CharacterName
            // 
            this.Lbl_CharacterName.AutoSize = true;
            this.Lbl_CharacterName.Location = new System.Drawing.Point(86, 9);
            this.Lbl_CharacterName.Name = "Lbl_CharacterName";
            this.Lbl_CharacterName.Size = new System.Drawing.Size(84, 13);
            this.Lbl_CharacterName.TabIndex = 0;
            this.Lbl_CharacterName.Text = "Character Name";
            this.Lbl_CharacterName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_CharacterName
            // 
            this.Txt_CharacterName.Location = new System.Drawing.Point(61, 25);
            this.Txt_CharacterName.Name = "Txt_CharacterName";
            this.Txt_CharacterName.Size = new System.Drawing.Size(133, 20);
            this.Txt_CharacterName.TabIndex = 1;
            // 
            // Gbox_Gender
            // 
            this.Gbox_Gender.Controls.Add(this.Rdo_GenderFemale);
            this.Gbox_Gender.Controls.Add(this.Rdo_GenderMale);
            this.Gbox_Gender.Location = new System.Drawing.Point(61, 72);
            this.Gbox_Gender.Name = "Gbox_Gender";
            this.Gbox_Gender.Size = new System.Drawing.Size(133, 44);
            this.Gbox_Gender.TabIndex = 2;
            this.Gbox_Gender.TabStop = false;
            this.Gbox_Gender.Text = "Gender";
            // 
            // Rdo_GenderFemale
            // 
            this.Rdo_GenderFemale.AutoSize = true;
            this.Rdo_GenderFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Rdo_GenderFemale.Location = new System.Drawing.Point(74, 19);
            this.Rdo_GenderFemale.Name = "Rdo_GenderFemale";
            this.Rdo_GenderFemale.Size = new System.Drawing.Size(59, 17);
            this.Rdo_GenderFemale.TabIndex = 1;
            this.Rdo_GenderFemale.TabStop = true;
            this.Rdo_GenderFemale.Text = "Female";
            this.Rdo_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // Rdo_GenderMale
            // 
            this.Rdo_GenderMale.AutoSize = true;
            this.Rdo_GenderMale.Location = new System.Drawing.Point(6, 19);
            this.Rdo_GenderMale.Name = "Rdo_GenderMale";
            this.Rdo_GenderMale.Size = new System.Drawing.Size(48, 17);
            this.Rdo_GenderMale.TabIndex = 0;
            this.Rdo_GenderMale.TabStop = true;
            this.Rdo_GenderMale.Text = "Male";
            this.Rdo_GenderMale.UseVisualStyleBackColor = true;
            // 
            // Cbo_CharacterClass
            // 
            this.Cbo_CharacterClass.FormattingEnabled = true;
            this.Cbo_CharacterClass.Items.AddRange(new object[] {
            "Mage",
            "Cleric",
            "Paladin",
            "Rogue",
            "Warrior"});
            this.Cbo_CharacterClass.Location = new System.Drawing.Point(61, 160);
            this.Cbo_CharacterClass.Name = "Cbo_CharacterClass";
            this.Cbo_CharacterClass.Size = new System.Drawing.Size(133, 21);
            this.Cbo_CharacterClass.TabIndex = 3;
            this.Cbo_CharacterClass.SelectedIndexChanged += new System.EventHandler(this.Cbo_CharacterClass_SelectedIndexChanged);
            // 
            // Lbl_CharacterClass
            // 
            this.Lbl_CharacterClass.AutoSize = true;
            this.Lbl_CharacterClass.Location = new System.Drawing.Point(86, 144);
            this.Lbl_CharacterClass.Name = "Lbl_CharacterClass";
            this.Lbl_CharacterClass.Size = new System.Drawing.Size(81, 13);
            this.Lbl_CharacterClass.TabIndex = 4;
            this.Lbl_CharacterClass.Text = "Character Class";
            // 
            // Btn_SaveCharacter
            // 
            this.Btn_SaveCharacter.Location = new System.Drawing.Point(76, 218);
            this.Btn_SaveCharacter.Name = "Btn_SaveCharacter";
            this.Btn_SaveCharacter.Size = new System.Drawing.Size(105, 46);
            this.Btn_SaveCharacter.TabIndex = 5;
            this.Btn_SaveCharacter.Text = "Save Character";
            this.Btn_SaveCharacter.UseVisualStyleBackColor = true;
            this.Btn_SaveCharacter.Click += new System.EventHandler(this.Btn_SaveCharacter_Click);
            // 
            // FormCharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 299);
            this.Controls.Add(this.Btn_SaveCharacter);
            this.Controls.Add(this.Lbl_CharacterClass);
            this.Controls.Add(this.Cbo_CharacterClass);
            this.Controls.Add(this.Gbox_Gender);
            this.Controls.Add(this.Txt_CharacterName);
            this.Controls.Add(this.Lbl_CharacterName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCharacterCreator";
            this.Text = "Create Your Character";
            this.Load += new System.EventHandler(this.FormCharacterCreator_Load);
            this.Gbox_Gender.ResumeLayout(false);
            this.Gbox_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CharacterName;
        private System.Windows.Forms.TextBox Txt_CharacterName;
        private System.Windows.Forms.GroupBox Gbox_Gender;
        private System.Windows.Forms.RadioButton Rdo_GenderFemale;
        private System.Windows.Forms.RadioButton Rdo_GenderMale;
        private System.Windows.Forms.ComboBox Cbo_CharacterClass;
        private System.Windows.Forms.Label Lbl_CharacterClass;
        private System.Windows.Forms.Button Btn_SaveCharacter;
    }
}