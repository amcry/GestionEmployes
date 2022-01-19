
namespace GestionEmploye.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_titre = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label_titre = new System.Windows.Forms.Label();
            this.panel_list_button = new System.Windows.Forms.Panel();
            this.listBox_employes = new System.Windows.Forms.ListBox();
            this.panel_button_refresh = new System.Windows.Forms.Panel();
            this.button_refresh = new System.Windows.Forms.Button();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_dateEmbauche = new System.Windows.Forms.Label();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.checkBox_pilote = new System.Windows.Forms.CheckBox();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.label_role = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bsEmploye = new System.Windows.Forms.BindingSource(this.components);
            this.panel_titre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel_list_button.SuspendLayout();
            this.panel_button_refresh.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titre
            // 
            this.panel_titre.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_titre.Controls.Add(this.pictureBox);
            this.panel_titre.Controls.Add(this.label_titre);
            this.panel_titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titre.Location = new System.Drawing.Point(0, 0);
            this.panel_titre.Name = "panel_titre";
            this.panel_titre.Size = new System.Drawing.Size(1068, 139);
            this.panel_titre.TabIndex = 1;
            this.panel_titre.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(266, 137);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label_titre
            // 
            this.label_titre.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_titre.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_titre.Location = new System.Drawing.Point(263, 0);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(803, 137);
            this.label_titre.TabIndex = 0;
            this.label_titre.Text = "Gestion Des Employés";
            this.label_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_titre.Click += new System.EventHandler(this.label_titre_Click);
            // 
            // panel_list_button
            // 
            this.panel_list_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_list_button.Controls.Add(this.listBox_employes);
            this.panel_list_button.Controls.Add(this.panel_button_refresh);
            this.panel_list_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_list_button.Location = new System.Drawing.Point(0, 139);
            this.panel_list_button.Name = "panel_list_button";
            this.panel_list_button.Size = new System.Drawing.Size(267, 457);
            this.panel_list_button.TabIndex = 2;
            // 
            // listBox_employes
            // 
            this.listBox_employes.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox_employes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_employes.FormattingEnabled = true;
            this.listBox_employes.ItemHeight = 15;
            this.listBox_employes.Location = new System.Drawing.Point(0, 94);
            this.listBox_employes.Name = "listBox_employes";
            this.listBox_employes.Size = new System.Drawing.Size(265, 361);
            this.listBox_employes.TabIndex = 2;
            this.listBox_employes.SelectedIndexChanged += new System.EventHandler(this.listBox_employes_SelectedIndexChanged);
            // 
            // panel_button_refresh
            // 
            this.panel_button_refresh.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_button_refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_button_refresh.Controls.Add(this.button_refresh);
            this.panel_button_refresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_button_refresh.Location = new System.Drawing.Point(0, 0);
            this.panel_button_refresh.Name = "panel_button_refresh";
            this.panel_button_refresh.Size = new System.Drawing.Size(265, 94);
            this.panel_button_refresh.TabIndex = 1;
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_refresh.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_refresh.Location = new System.Drawing.Point(65, 27);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(114, 45);
            this.button_refresh.TabIndex = 0;
            this.button_refresh.Text = "Rafraichir";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(40, 69);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(597, 23);
            this.textBox_nom.TabIndex = 3;
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox_nom_TextChanged);
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(40, 137);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(597, 23);
            this.textBox_prenom.TabIndex = 4;
            // 
            // label_nom
            // 
            this.label_nom.Location = new System.Drawing.Point(40, 48);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(100, 18);
            this.label_nom.TabIndex = 5;
            this.label_nom.Text = "NOM";
            // 
            // label_prenom
            // 
            this.label_prenom.Location = new System.Drawing.Point(40, 116);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(100, 18);
            this.label_prenom.TabIndex = 6;
            this.label_prenom.Text = "PRENOM";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label_dateEmbauche
            // 
            this.label_dateEmbauche.AutoSize = true;
            this.label_dateEmbauche.Location = new System.Drawing.Point(40, 189);
            this.label_dateEmbauche.Name = "label_dateEmbauche";
            this.label_dateEmbauche.Size = new System.Drawing.Size(111, 15);
            this.label_dateEmbauche.TabIndex = 8;
            this.label_dateEmbauche.Text = "DATE D EMBAUCHE";
            // 
            // comboBox_role
            // 
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Location = new System.Drawing.Point(40, 287);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(121, 23);
            this.comboBox_role.TabIndex = 9;
            this.comboBox_role.SelectedIndexChanged += new System.EventHandler(this.comboBox_role_SelectedIndexChanged);
            // 
            // checkBox_pilote
            // 
            this.checkBox_pilote.AutoSize = true;
            this.checkBox_pilote.Location = new System.Drawing.Point(40, 348);
            this.checkBox_pilote.Name = "checkBox_pilote";
            this.checkBox_pilote.Size = new System.Drawing.Size(101, 19);
            this.checkBox_pilote.TabIndex = 10;
            this.checkBox_pilote.Text = "Pilote de ligne";
            this.checkBox_pilote.UseVisualStyleBackColor = true;
            this.checkBox_pilote.CheckedChanged += new System.EventHandler(this.checkBox_pilote_CheckedChanged);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_enregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enregistrer.Location = new System.Drawing.Point(40, 402);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.button_enregistrer.TabIndex = 11;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = false;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // label_role
            // 
            this.label_role.Location = new System.Drawing.Point(40, 266);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(100, 18);
            this.label_role.TabIndex = 12;
            this.label_role.Text = "ROLES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button_enregistrer);
            this.panel1.Controls.Add(this.checkBox_pilote);
            this.panel1.Controls.Add(this.label_role);
            this.panel1.Controls.Add(this.comboBox_role);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox_nom);
            this.panel1.Controls.Add(this.label_dateEmbauche);
            this.panel1.Controls.Add(this.textBox_prenom);
            this.panel1.Controls.Add(this.label_prenom);
            this.panel1.Controls.Add(this.label_nom);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(267, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 457);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_list_button);
            this.Controls.Add(this.panel_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_titre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel_list_button.ResumeLayout(false);
            this.panel_button_refresh.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmploye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_titre;
        private System.Windows.Forms.Panel panel_list_button;
        private System.Windows.Forms.Panel panel_button_refresh;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_dateEmbauche;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.CheckBox checkBox_pilote;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox listBox_employes;
        private System.Windows.Forms.BindingSource bsEmploye;
    }
}

