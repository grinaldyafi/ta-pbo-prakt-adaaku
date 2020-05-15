using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdaAku
{
    public partial class CariDiary : Form
    {
        public CariDiary()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahCatatan_Click(object sender, EventArgs e)
        {
            InputDiary kontakForm = new InputDiary();
            kontakForm.ShowDialog();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lblJudul.Text = "-";
            lblTanggal.Text = "-";
            lblCatatan.Text = "-";
         
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            using (var db = new DiaryModel())
            {
                var query = from Diary in db.Diaries where Diary.Judul == tbCariJudul.Text select Diary;
                foreach (var item in query)
                {
                    lblJudul.Text = item.Judul;
                    lblTanggal.Text = item.Tanggal;
                    lblCatatan.Text = item.Catatan;
                    btnEdit.Enabled = true;
                    btnHapus.Enabled = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            InputDiary kontakForm = new InputDiary(lblJudul.Text, lblTanggal.Text, lblCatatan.Text);
            kontakForm.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

            using (var db = new DiaryModel())
            {
                db.Diaries.RemoveRange(db.Diaries.Where(item => item.Judul == lblJudul.Text));
                db.SaveChanges();
                lblJudul.Text = "-";
                lblCatatan.Text = "-";
                lblTanggal.Text = "-";
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
            }
        }

        private void CariDiary_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Form2 f3 = new Form2();
            f3.Show();
            this.Hide();
        }
    }
    
}
