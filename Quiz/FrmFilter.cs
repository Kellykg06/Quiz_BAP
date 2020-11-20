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
   public partial class FrmFilter : Form
   {

        private TMahasiswa _objMhs = null;

        public TMahasiswa RunAndReturnObjectTMahasiswa(FrmFilter form)
        {
            form.ShowDialog();
            return _objMhs;
        }
        public FrmFilter(TMahasiswa set)
        {
            InitializeComponent();
            this.txtNim.Text = set.Nim;
            this.txtNama.Text = set.Nim;
            this.cboJenisKelamin.SelectedItem = set.JenisKelamin;
            this.cboProgramStudi.SelectedItem = set.ProgramStudi;
            this.cboWaktuKuliah.SelectedItem = set.WaktuKuliah;
            this.cboKelas.SelectedItem = set.Kelas;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _objMhs = new TMahasiswa
            (
                this.txtNim.Text.Trim(),
                this.txtNama.Text.Trim(),
                this.cboJenisKelamin.Text.ToString().Trim(),
                this.cboProgramStudi.Text.ToString().Trim(),
                this.cboWaktuKuliah.Text.ToString().Trim(),
                this.cboKelas.Text.ToString().Trim()
            );
            this.Close();
            
        }

        private void txtNim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }
        private void txtNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void cboJenisKelamin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void cboProgramStudi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void cboWaktuKuliah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void FrmFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void cboKelas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtNim.Clear();
            this.txtNama.Clear();
            this.cboJenisKelamin.SelectedIndex = -1;
            this.cboProgramStudi.SelectedIndex = -1;
            this.cboWaktuKuliah.SelectedIndex = -1;
            this.cboKelas.SelectedIndex = -1;
        }
    }
}
