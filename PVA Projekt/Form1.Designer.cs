
namespace PVA_Projekt
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Lbl_Tittle = new System.Windows.Forms.Label();
            this.Btn_CreateChar = new System.Windows.Forms.Button();
            this.Btn_LoadGame = new System.Windows.Forms.Button();
            this.Btn_Options = new System.Windows.Forms.Button();
            this.Btn_HighScores = new System.Windows.Forms.Button();
            this.Btn_Credits = new System.Windows.Forms.Button();
            this.Btn_GetStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Tittle
            // 
            this.Lbl_Tittle.AutoSize = true;
            this.Lbl_Tittle.Location = new System.Drawing.Point(278, 9);
            this.Lbl_Tittle.Name = "Lbl_Tittle";
            this.Lbl_Tittle.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Tittle.TabIndex = 0;
            this.Lbl_Tittle.Text = "Name";
            // 
            // Btn_CreateChar
            // 
            this.Btn_CreateChar.Location = new System.Drawing.Point(71, 237);
            this.Btn_CreateChar.Name = "Btn_CreateChar";
            this.Btn_CreateChar.Size = new System.Drawing.Size(103, 58);
            this.Btn_CreateChar.TabIndex = 1;
            this.Btn_CreateChar.Text = "Create Character";
            this.Btn_CreateChar.UseVisualStyleBackColor = true;
            this.Btn_CreateChar.Click += new System.EventHandler(this.Btn_CreateChar_Click);
            // 
            // Btn_LoadGame
            // 
            this.Btn_LoadGame.Location = new System.Drawing.Point(247, 237);
            this.Btn_LoadGame.Name = "Btn_LoadGame";
            this.Btn_LoadGame.Size = new System.Drawing.Size(103, 58);
            this.Btn_LoadGame.TabIndex = 2;
            this.Btn_LoadGame.Text = "Load Game";
            this.Btn_LoadGame.UseVisualStyleBackColor = true;
            // 
            // Btn_Options
            // 
            this.Btn_Options.Location = new System.Drawing.Point(426, 237);
            this.Btn_Options.Name = "Btn_Options";
            this.Btn_Options.Size = new System.Drawing.Size(103, 58);
            this.Btn_Options.TabIndex = 3;
            this.Btn_Options.Text = "Options";
            this.Btn_Options.UseVisualStyleBackColor = true;
            // 
            // Btn_HighScores
            // 
            this.Btn_HighScores.Location = new System.Drawing.Point(247, 345);
            this.Btn_HighScores.Name = "Btn_HighScores";
            this.Btn_HighScores.Size = new System.Drawing.Size(103, 58);
            this.Btn_HighScores.TabIndex = 4;
            this.Btn_HighScores.Text = "High Scores";
            this.Btn_HighScores.UseVisualStyleBackColor = true;
            // 
            // Btn_Credits
            // 
            this.Btn_Credits.Location = new System.Drawing.Point(426, 345);
            this.Btn_Credits.Name = "Btn_Credits";
            this.Btn_Credits.Size = new System.Drawing.Size(103, 58);
            this.Btn_Credits.TabIndex = 5;
            this.Btn_Credits.Text = "Credits";
            this.Btn_Credits.UseVisualStyleBackColor = true;
            // 
            // Btn_GetStats
            // 
            this.Btn_GetStats.Location = new System.Drawing.Point(71, 345);
            this.Btn_GetStats.Name = "Btn_GetStats";
            this.Btn_GetStats.Size = new System.Drawing.Size(103, 58);
            this.Btn_GetStats.TabIndex = 6;
            this.Btn_GetStats.Text = "Get Stats";
            this.Btn_GetStats.UseVisualStyleBackColor = true;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 443);
            this.Controls.Add(this.Btn_GetStats);
            this.Controls.Add(this.Btn_Credits);
            this.Controls.Add(this.Btn_HighScores);
            this.Controls.Add(this.Btn_Options);
            this.Controls.Add(this.Btn_LoadGame);
            this.Controls.Add(this.Btn_CreateChar);
            this.Controls.Add(this.Lbl_Tittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(615, 482);
            this.MinimumSize = new System.Drawing.Size(615, 482);
            this.Name = "Frm_Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Tittle;
        private System.Windows.Forms.Button Btn_CreateChar;
        private System.Windows.Forms.Button Btn_LoadGame;
        private System.Windows.Forms.Button Btn_Options;
        private System.Windows.Forms.Button Btn_HighScores;
        private System.Windows.Forms.Button Btn_Credits;
        private System.Windows.Forms.Button Btn_GetStats;
    }
}

