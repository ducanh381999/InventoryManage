using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProJectSession4
{
    public partial class frmView : Form
    {
        sql sql = new sql();
        List<View> list = new List<View>();
        public frmView()
        {
            InitializeComponent();
        }

        private String Partname;

        public String partname 
        {
            get { return Partname; }
            set { Partname = value; }
        }
      

        public void hienthi()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["batchnumber"].Value = list[i].batchnumber;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow) continue;
                string tmp = dataGridView1.Rows[i].Cells["batchnumber"].Value.ToString();
                for (int j = dataGridView1.Rows.Count - 1; j > i; j--)
                {
                    if (dataGridView1.Rows[j].IsNewRow) continue;
                    if (tmp == dataGridView1.Rows[j].Cells["batchnumber"].Value.ToString())
                    {
                        dataGridView1.Rows.RemoveAt(j);
                    }
                }
            }
        }
        private void frmView_Load(object sender, EventArgs e)
        {
            //DataTable dt = sql.getBatchNumberByPartName(partname);
            //dataGridView1.DataSource = dt;
            list = sql.getBatchNumber(partname);
            hienthi();

        }

        private void txtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
