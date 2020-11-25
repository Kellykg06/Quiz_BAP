using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
   public partial class FrmEnqueryData : Form
   {

        private TMahasiswa set = new TMahasiswa("", "", "", "", "", "");
        private TMahasiswa _objMhs = null;
        public FrmEnqueryData()
         {
            InitializeComponent();
            this.dgvData.AutoGenerateColumns = false;
         }
        private void LoadData(string query)
        {
            this.dgvData.Rows.Clear();
            try
            {
                using (var conn = new Parameter().CreateAndOpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        if (query == null)
                        {
                            cmd.CommandText = @"Select * from TMahasiswa";
                        }
                        else
                        {
                            cmd.CommandText = query;
                        }
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    this.dgvData.Rows.Add(new string[] {
                                    reader["Nim"].ToString(),
                                    reader["Nama"].ToString(),
                                    reader["JenisKelamin"].ToString(),
                                    reader["ProgramStudi"].ToString(),
                                    reader["WaktuKuliah"].ToString(),
                                    reader["Kelas"].ToString(),
                                });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            var form = new FrmFilter(set);
            var returnvalue = form.RunAndReturnObjectTMahasiswa(form);
            if (returnvalue != null)
            {
                string nim = returnvalue.Nim;
                string nama = returnvalue.Nama;
                string jeniskelamin = returnvalue.JenisKelamin;
                string programstudi = returnvalue.ProgramStudi;
                string waktukuliah = returnvalue.WaktuKuliah;
                string kelas = returnvalue.Kelas;
                string query = @"Select* from TMahasiswa where[Nim] like '" + nim + "%' and [Nama] like '" + nama + "%' and [JenisKelamin] like '"
                            + jeniskelamin + "%'  and [ProgramStudi] like '" + programstudi + "%'  and [WaktuKuliah] like '" + waktukuliah + "%' and [Kelas] like '" + kelas + "%'";
                LoadData(query);
                lblFilter.Text = $"Filter By : Nim  : {nim}.  Nama : {nama}. Jenis Kelamin : {jeniskelamin}. Program Studi : {programstudi}. Waktu Kuliah : {waktukuliah}. Kelas : {kelas}";

                set.Nim = nim;
                set.Nama = nama;
                set.JenisKelamin = jeniskelamin;
                set.ProgramStudi = programstudi;
                set.WaktuKuliah = waktukuliah;
                set.Kelas = kelas;
            }
        }

        private void dgvData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int record = dgvData.Rows.Count;
            lblBanyakRecordData.Text = record + " Record";
        }

        private void FrmEnqueryData_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvData.CurrentRow != null)
            {
                var row = this.dgvData.CurrentRow;
                string nim = row.Cells[0].Value.ToString().Trim();
                string nama = row.Cells[1].Value.ToString().Trim();
                string jeniskelamin = row.Cells[2].Value.ToString().Trim(); ;
                string programstudi = row.Cells[3].Value.ToString().Trim();
                string waktukuliah = row.Cells[4].Value.ToString().Trim();
                string kelas = row.Cells[5].Value.ToString().Trim();
                FrmFilter form = new FrmFilter(set); 
                var returnValue = form.RunAndReturnObjectTMahasiswa(form);
                if (returnValue != null)
                {
                    row.Cells[0].Value = returnValue.Nim;
                    row.Cells[1].Value = returnValue.Nama;
                    row.Cells[2].Value = returnValue.JenisKelamin;
                    row.Cells[3].Value = returnValue.ProgramStudi;
                    row.Cells[4].Value = returnValue.WaktuKuliah;
                    row.Cells[5].Value = returnValue.Kelas;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if(this.dgvData.Rows.Count > 0)
            {
                List<TMahasiswa> listData = new List<TMahasiswa>();
                foreach(DataGridViewRow row in this.dgvData.Rows)
                {
                    string nim = row.Cells[0].Value.ToString().Trim();
                    string nama = row.Cells[1].Value.ToString().Trim();
                    string jeniskelamin = row.Cells[2].Value.ToString().Trim();
                    string programstudi = row.Cells[3].Value.ToString().Trim();
                    string waktukuliah = row.Cells[4].Value.ToString().Trim();
                    string kelas = row.Cells[5].Value.ToString().Trim();
                    listData.Add(new TMahasiswa(nim, nama, jeniskelamin, programstudi, waktukuliah, kelas)
                    {
                        Nim = nim,
                        Nama = nama,
                        Kelas = kelas,
                        ProgramStudi = programstudi,
                        WaktuKuliah = waktukuliah,
                    });
                }
                FrmReportMahasiswa form = new FrmReportMahasiswa(listData);
                form.ShowDialog();
            }
        }
    }
}
