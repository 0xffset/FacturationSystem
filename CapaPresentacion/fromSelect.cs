using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmSelect : Form
    {

        


        public frmSelect(string[] tables)
        {
            InitializeComponent();
            this.listBox1.DataSource = tables;
        }

        public string Selection
        {
            get { return this.listBox1.SelectedItem as string; }
        }

      

        private void frmSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
