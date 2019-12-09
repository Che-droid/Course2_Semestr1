using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestsSeviceLib;

namespace TestsApplication
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        public StatisticsForm(Service _service) : this()
        {
            service = _service;

            var l = service.GetStatistics();
            l.ForEach(x => x.TimeToShow = TimeSpan.FromSeconds(x.TimeInMinutes).ToString());

            dataGridView1.DataSource = l;
        }

        Service service { get; set; }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            service.ClearStatistics();
            dataGridView1.DataSource = null;
        }
    }
}
