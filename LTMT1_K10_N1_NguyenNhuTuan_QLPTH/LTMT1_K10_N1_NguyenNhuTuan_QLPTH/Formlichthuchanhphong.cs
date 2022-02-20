using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTMT1_K10_N1_NguyenNhuTuan_QLPTH
{
    public partial class Formlichthuchanhphong : Form
    {
        public Formlichthuchanhphong()
        {
            InitializeComponent();
        }

        public string sophong;

        private void Formlichthuchanhphong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet.thuchanh' table. You can move, or remove it, as needed.
            this.thuchanhTableAdapter.Fill(this.LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet.thuchanh,sophong);

            this.reportViewer1.RefreshReport();
        }
    }
}
