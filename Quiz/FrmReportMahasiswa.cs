using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class FrmReportMahasiswa : Form
    {
        private List<TMahasiswa> _lisData = null;
        public FrmReportMahasiswa(List<TMahasiswa> listData)
        {
            InitializeComponent();
            _lisData = listData;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                if(_lisData != null && _lisData.Any())
                {
                    ReportDataMahasiswa ds = new ReportDataMahasiswa();
                    foreach (var item in _lisData)
                    {
                        var newRow = ds.TMahasiswa.NewTMahasiswaRow();
                        newRow.Nim = item.Nim;
                        newRow.Nama = item.Nama;
                        newRow.ProgramStudi = item.ProgramStudi;
                        newRow.WaktuKuliah = item.WaktuKuliah;
                        newRow.Kelas = item.Kelas;
                        ds.TMahasiswa.AddTMahasiswaRow(newRow);
                    }
                    RptMahasiswa rpt = new RptMahasiswa();
                    rpt.SetDataSource(ds);
                    this.crystalReportViewer1.ReportSource = rpt;
                }
                else
                {
                    MessageBox.Show("Sorry, Minimal Harus Ada Satu Kriteria..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
