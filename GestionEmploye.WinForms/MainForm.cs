using GestionEmploye.DataAccess;
using GestionEmploye.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmploye.WinForms
{
    public partial class MainForm : Form
    {
        private MainViewModel _viewModel;

        private void Charger()
        {
            _viewModel.Charger();
            bsEmploye.DataSource = _viewModel.Employes;
            listBox_employes.DataSource = bsEmploye;
            listBox_employes.DisplayMember = "Nom";
        }

        public MainForm()
        {
            InitializeComponent();
            _viewModel = new MainViewModel(new EmployeDataProvider());
      

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label_titre_Click(object sender, EventArgs e)
        {

        }

        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView_employe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_employes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            Charger();
            bsEmploye.ResetBindings(false);

        }

       
        private void MainForm_Load(object sender, EventArgs e)
        {
            Charger();

            textBox_nom.DataBindings.Add("Text",bsEmploye, "Nom",false, DataSourceUpdateMode.OnPropertyChanged);

            textBox_prenom.DataBindings.Add("Text", bsEmploye, "Prenom", false, DataSourceUpdateMode.OnPropertyChanged);

            dateTimePicker1.DataBindings.Add("Value", bsEmploye, "DateEmbaucheWpf");

            comboBox_role.DataSource = _viewModel.Roles;
            comboBox_role.DisplayMember = "Nom";
            comboBox_role.ValueMember = "IdRole";
            comboBox_role.DataBindings.Add("SelectedValue", bsEmploye, "RoleId");

            checkBox_pilote.DataBindings.Add("Checked", bsEmploye, "EstPiloteDeLigne");
            
        }
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_pilote_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            var vmCourant = bsEmploye.Current as EmployeViewModel;
            vmCourant.Sauvegarder();
        }
    }
}
