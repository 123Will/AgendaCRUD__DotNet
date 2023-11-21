using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conyact List 1.0.\nwritten by: William Junio", "About");
        }

        private void pessoasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contactDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contactDBDataSet.Pessoas'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoasTableAdapter.Fill(this.contactDBDataSet.Pessoas);

        }

        private void contactIDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
