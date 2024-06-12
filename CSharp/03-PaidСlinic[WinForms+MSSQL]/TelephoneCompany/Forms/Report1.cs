using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneCompany.Forms
{
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephoneCompanyDataSet.ScalarQuery". При необходимости она может быть перемещена или удалена.
            this.scalarQueryTableAdapter.Fill(this.telephoneCompanyDataSet.ScalarQuery);

        }
    }
}
