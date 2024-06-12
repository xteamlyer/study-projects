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
    public partial class Report2 : Form
    {
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "telephoneCompanyDataSet1.ScalarQuery5". При необходимости она может быть перемещена или удалена.
            this.scalarQuery5TableAdapter.Fill(this.telephoneCompanyDataSet1.ScalarQuery5);

        }
    }
}
