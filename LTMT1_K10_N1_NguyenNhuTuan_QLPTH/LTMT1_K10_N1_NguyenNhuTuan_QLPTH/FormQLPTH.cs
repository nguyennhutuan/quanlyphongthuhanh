using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LTMT1_K10_N1_NguyenNhuTuan_QLPTH
{
    public partial class FormQLPTH : Form
    {
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader doc;
        string nguon = @"Data Source=DESKTOP-TDQUIMU\SQLEXPRESS;Initial Catalog=LTMT1_K10_N1_NguyenNhuTuan_QLPTH;Integrated Security=True";
        string lenh;

        public FormQLPTH()
        {
            InitializeComponent();
        }

        void naplistview()
        {
            listViewPM.Items.Clear();
            lenh = @"SELECT thuchanh.sophong, monhoc.tenmh, thuchanh.ngayth, thuchanh.buoith, thuchanh.giaovienth
                     FROM   thuchanh INNER JOIN monhoc ON thuchanh.mamh = monhoc.mamh";
            ketnoi.Open();
            thuchien = new SqlCommand(lenh, ketnoi);
            doc = thuchien.ExecuteReader();
            int i = 0;
            while (doc.Read())
            {
                listViewPM.Items.Add(doc[0].ToString());
                listViewPM.Items[i].SubItems.Add(doc[1].ToString());
                listViewPM.Items[i].SubItems.Add(doc[2].ToString().Substring(0, 10));
                listViewPM.Items[i].SubItems.Add(doc[3].ToString());
                listViewPM.Items[i].SubItems.Add(doc[4].ToString());
                i++;
            }
            ketnoi.Close();
        }

        void napsophong()
        {
            cmbsophong.Items.Clear();
            lenh = @"SELECT sophong FROM phongmay";
            ketnoi.Open();
            thuchien = new SqlCommand(lenh, ketnoi);
            doc = thuchien.ExecuteReader();            
            while (doc.Read())
            {
                cmbsophong.Items.Add(doc[0].ToString());
            }
            ketnoi.Close();
        }

        void napmonhoc()
        {
            cmbmonhoc.Items.Clear();
            lenh = @"SELECT tenmh FROM monhoc";
            ketnoi.Open();
            thuchien = new SqlCommand(lenh, ketnoi);
            doc = thuchien.ExecuteReader();
            while (doc.Read())
            {
                cmbmonhoc.Items.Add(doc[0].ToString());
            }
            ketnoi.Close();
        }

        private void FormQLPTH_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(nguon);
            naplistview();
            napsophong();
            napmonhoc();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            lenh = @"INSERT INTO thuchanh
                     VALUES (@sophong,@mamh,@ngayth,@buoith,@giaovienth)";
            ketnoi.Open();
            thuchien = new SqlCommand(lenh, ketnoi);
            thuchien.Parameters.Add("@sophong", SqlDbType.NChar, 4);
            thuchien.Parameters.Add("@mamh", SqlDbType.Char, 4);
            thuchien.Parameters.Add("@ngayth", SqlDbType.DateTime);
            thuchien.Parameters.Add("@buoith", SqlDbType.NChar, 10);
            thuchien.Parameters.Add("@giaovienth", SqlDbType.NVarChar, 50);
            thuchien.Parameters["@sophong"].Value = cmbsophong.Text;
            thuchien.Parameters["@mamh"].Value = mamh;
            thuchien.Parameters["@ngayth"].Value = dateTimePicker1.Value;
            thuchien.Parameters["@buoith"].Value = cmbbuoi.Text;
            thuchien.Parameters["@giaovienth"].Value = txtgiaovien.Text;
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            naplistview();
        }

        string mamh;

        private void cmbmonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lenh = @"SELECT mamh FROM monhoc
                     WHERE  (tenmh = @tenmh)";
            ketnoi.Open();
            thuchien = new SqlCommand(lenh, ketnoi);
            thuchien.Parameters.Add("@tenmh", SqlDbType.NVarChar, 40);
            thuchien.Parameters["@tenmh"].Value = cmbmonhoc.Text;
            doc = thuchien.ExecuteReader();
            while (doc.Read())
            {
                mamh = doc[0].ToString();
            }
            ketnoi.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            lenh = @"UPDATE thuchanh
                     SET    sophong = @sophong, mamh = @mamh, ngayth = @ngayth, buoith = @buoith, giaovienth = @giaovienth
                     WHERE  (sophong = @sophong1) AND (ngayth = @ngayth1) AND (buoith = @buoith1)";
            ketnoi.Open();
            thuchien = new SqlCommand(lenh, ketnoi);
            thuchien.Parameters.Add("@sophong", SqlDbType.NChar, 4);
            thuchien.Parameters.Add("@mamh", SqlDbType.Char, 4);
            thuchien.Parameters.Add("@ngayth", SqlDbType.Date);
            thuchien.Parameters.Add("@buoith", SqlDbType.NChar, 10);
            thuchien.Parameters.Add("@giaovienth", SqlDbType.NVarChar, 50);
            thuchien.Parameters.Add("@sophong1", SqlDbType.NChar, 4);
            thuchien.Parameters.Add("@ngayth1", SqlDbType.DateTime);
            thuchien.Parameters.Add("@buoith1", SqlDbType.NChar, 10);
            thuchien.Parameters["@sophong"].Value = cmbsophong.Text;
            thuchien.Parameters["@mamh"].Value = mamh;
            thuchien.Parameters["@ngayth"].Value = dateTimePicker1.Value;
            thuchien.Parameters["@buoith"].Value = cmbbuoi.Text;
            thuchien.Parameters["@giaovienth"].Value = txtgiaovien.Text;
            thuchien.Parameters["@sophong1"].Value = listViewPM.SelectedItems[0].SubItems[0].Text;
            thuchien.Parameters["@ngayth1"].Value = Convert.ToDateTime(listViewPM.SelectedItems[0].SubItems[2].Text);
            thuchien.Parameters["@buoith1"].Value = listViewPM.SelectedItems[0].SubItems[3].Text;
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            naplistview();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lenh = @"DELETE FROM thuchanh
                     WHERE  (sophong = @sophong) AND (ngayth = @ngayth) AND (buoith = @buoith)";
            ketnoi.Open();
            thuchien = new SqlCommand(lenh, ketnoi);
            thuchien.Parameters.Add("@sophong", SqlDbType.NChar, 4);
            thuchien.Parameters.Add("@ngayth", SqlDbType.DateTime);
            thuchien.Parameters.Add("@buoith", SqlDbType.NChar, 10);
            thuchien.Parameters["@sophong"].Value = listViewPM.SelectedItems[0].SubItems[0].Text;
            thuchien.Parameters["@ngayth"].Value = Convert.ToDateTime(listViewPM.SelectedItems[0].SubItems[2].Text);
            thuchien.Parameters["@buoith"].Value = listViewPM.SelectedItems[0].SubItems[3].Text;
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            naplistview();
        }

        private void listViewPM_Click(object sender, EventArgs e)
        {
            cmbsophong.Text = listViewPM.SelectedItems[0].SubItems[0].Text;
            cmbmonhoc.Text = listViewPM.SelectedItems[0].SubItems[1].Text;
            dateTimePicker1.Text = listViewPM.SelectedItems[0].SubItems[2].Text;
            cmbbuoi.Text = listViewPM.SelectedItems[0].SubItems[3].Text;
            txtgiaovien.Text = listViewPM.SelectedItems[0].SubItems[4].Text;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Formlichthuchanhphong f = new Formlichthuchanhphong();
            f.sophong = cmbsophong.Text;
            f.Show();
        }

    }
}
