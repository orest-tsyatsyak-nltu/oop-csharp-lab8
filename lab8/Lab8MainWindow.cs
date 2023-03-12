using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab8
{
    public partial class Lab8MainWindow : Form
    {

        private static readonly string PATH_TO_ORATORS_FILE = "orators.bin";

        private OratorList basis;

        private BindingList<Orator> oratorsList;

        private BinaryFormatter binaryFormatter;

        public Lab8MainWindow()
        {
            binaryFormatter = new BinaryFormatter();
            basis = new OratorList();
            oratorsList = new BindingList<Orator>(basis);
            InitializeComponent();
            orators.DataSource = oratorsList;
        }

        private void standartorators_Click(object sender, EventArgs e)
        {
            basis.FillOrators();
            oratorsList.ResetBindings();
        }

        private void orators_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = e.ListItem.ToString();
        }

        private void sortByCountry_Click(object sender, EventArgs e)
        {
            basis.Sort((o1, o2) => o1.Country.CompareTo(o2.Country));
            oratorsList.ResetBindings();
        }

        private void lowerForUkraine_Click(object sender, EventArgs e)
        {
            basis.ReduceMembershipFee(o1 => o1.Country.ToUpper().Equals("UKRAINE"), oldValue => oldValue/2);
            oratorsList.ResetBindings();
        }

        private void getBySection_Click(object sender, EventArgs e)
        {
            new DisplayOratorsByFactor(basis.GetBy(o => o.Section.Equals(sectionField.Text))).Show();
        }

        private void writeToFile_Click(object sender, EventArgs e)
        {
            basis.WriteToFile(binaryFormatter, PATH_TO_ORATORS_FILE);
        }

        private void readFromFile_Click(object sender, EventArgs e)
        {
            basis.ReadFromFile(binaryFormatter, PATH_TO_ORATORS_FILE);
            oratorsList.ResetBindings();
        }
    }
}
