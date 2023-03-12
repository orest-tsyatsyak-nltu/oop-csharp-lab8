using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class DisplayOratorsByFactor : Form
    {

        public DisplayOratorsByFactor(List<Orator> oratorsList)
        {
            InitializeComponent();
            orators.DataSource = oratorsList;
        }

        private void orators_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = e.ListItem.ToString();
        }
    }
}
