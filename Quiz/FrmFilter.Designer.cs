
namespace Quiz
{
   partial class FrmFilter
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.lblBanyakRecordData = new System.Windows.Forms.Label();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboJenisKelamin = new System.Windows.Forms.ComboBox();
            this.cboProgramStudi = new System.Windows.Forms.ComboBox();
            this.cboWaktuKuliah = new System.Windows.Forms.ComboBox();
            this.cboKelas = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBanyakRecordData
            // 
            this.lblBanyakRecordData.Location = new System.Drawing.Point(16, 18);
            this.lblBanyakRecordData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanyakRecordData.Name = "lblBanyakRecordData";
            this.lblBanyakRecordData.Size = new System.Drawing.Size(131, 25);
            this.lblBanyakRecordData.TabIndex = 3;
            this.lblBanyakRecordData.Text = "Nim";
            this.lblBanyakRecordData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNim
            // 
            this.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNim.Location = new System.Drawing.Point(155, 18);
            this.txtNim.Margin = new System.Windows.Forms.Padding(4);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(207, 22);
            this.txtNim.TabIndex = 0;
            this.txtNim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNim_KeyDown);
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Location = new System.Drawing.Point(155, 50);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(207, 22);
            this.txtNama.TabIndex = 1;
            this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNama_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jenis Kelamin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Program Studi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Waktu Kuliah";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kelas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboJenisKelamin
            // 
            this.cboJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJenisKelamin.FormattingEnabled = true;
            this.cboJenisKelamin.Items.AddRange(new object[] {
            "",
            "Pria",
            "Wanita"});
            this.cboJenisKelamin.Location = new System.Drawing.Point(155, 82);
            this.cboJenisKelamin.Margin = new System.Windows.Forms.Padding(4);
            this.cboJenisKelamin.Name = "cboJenisKelamin";
            this.cboJenisKelamin.Size = new System.Drawing.Size(207, 24);
            this.cboJenisKelamin.TabIndex = 2;
            this.cboJenisKelamin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboJenisKelamin_KeyDown);
            // 
            // cboProgramStudi
            // 
            this.cboProgramStudi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgramStudi.FormattingEnabled = true;
            this.cboProgramStudi.Items.AddRange(new object[] {
            "",
            "TI",
            "SI"});
            this.cboProgramStudi.Location = new System.Drawing.Point(155, 114);
            this.cboProgramStudi.Margin = new System.Windows.Forms.Padding(4);
            this.cboProgramStudi.Name = "cboProgramStudi";
            this.cboProgramStudi.Size = new System.Drawing.Size(207, 24);
            this.cboProgramStudi.TabIndex = 3;
            this.cboProgramStudi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboProgramStudi_KeyDown);
            // 
            // cboWaktuKuliah
            // 
            this.cboWaktuKuliah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWaktuKuliah.FormattingEnabled = true;
            this.cboWaktuKuliah.Items.AddRange(new object[] {
            "",
            "Pagi",
            "Sore"});
            this.cboWaktuKuliah.Location = new System.Drawing.Point(155, 146);
            this.cboWaktuKuliah.Margin = new System.Windows.Forms.Padding(4);
            this.cboWaktuKuliah.Name = "cboWaktuKuliah";
            this.cboWaktuKuliah.Size = new System.Drawing.Size(207, 24);
            this.cboWaktuKuliah.TabIndex = 4;
            this.cboWaktuKuliah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboWaktuKuliah_KeyDown);
            // 
            // cboKelas
            // 
            this.cboKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKelas.FormattingEnabled = true;
            this.cboKelas.Items.AddRange(new object[] {
            "",
            "A",
            "B"});
            this.cboKelas.Location = new System.Drawing.Point(155, 178);
            this.cboKelas.Margin = new System.Windows.Forms.Padding(4);
            this.cboKelas.Name = "cboKelas";
            this.cboKelas.Size = new System.Drawing.Size(207, 24);
            this.cboKelas.TabIndex = 5;
            this.cboKelas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboKelas_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(155, 224);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(263, 224);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 265);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboKelas);
            this.Controls.Add(this.cboWaktuKuliah);
            this.Controls.Add(this.cboProgramStudi);
            this.Controls.Add(this.cboJenisKelamin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.lblBanyakRecordData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kriteria Filter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFilter_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblBanyakRecordData;
      private System.Windows.Forms.TextBox txtNim;
      private System.Windows.Forms.TextBox txtNama;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox cboJenisKelamin;
      private System.Windows.Forms.ComboBox cboProgramStudi;
      private System.Windows.Forms.ComboBox cboWaktuKuliah;
      private System.Windows.Forms.ComboBox cboKelas;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Button btnClear;
   }
}