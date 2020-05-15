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
    public partial class InputDiary : Form
    {
        Diary diary;
        public enum Mode { Insert, Edit }
        Mode mode;
        public InputDiary()
        {
            InitializeComponent();
            mode = Mode.Insert;
            btnAksi.Text = "Tambah";
        }
        public InputDiary(string judul, string tanggal, string catatan)
        {
            InitializeComponent();
            mode = Mode.Edit;
            diary = new Diary
            {
                Judul = judul,
                Tanggal = tanggal,
                Catatan = catatan,
                
            };
            tbJudul.Text = judul;
            tbTanggal.Text = tanggal;
            tbCatatan.Text = catatan;
   
            btnAksi.Text = "Perbaharui";
        }



        private void TambahData()
        {
            if (tbJudul.Text != "" && tbTanggal.Text != "" && tbCatatan.Text != "")
            {
                using (var db = new DiaryModel())
                {
                    diary = new Diary
                    {
                        Judul = tbJudul.Text,
                        Tanggal = tbTanggal.Text,
                        Catatan = tbCatatan.Text,
                      
                    };
                    db.Diaries.Add(diary);
                    db.SaveChanges();
                    MessageBox.Show("Catatan Ditambahkan");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Nama, Alamat, dan Nomor HP harus diisi");
            }
        }
        private void EditData()
        {
            using (var db = new DiaryModel())
            {
                var result = db.Diaries.SingleOrDefault(k => k.Judul == diary.Judul);
                if (result != null)
                {
                    if (tbJudul.Text != "" && tbTanggal.Text != "" && tbCatatan.Text != "")
                    {
                        result.Judul = tbJudul.Text;
                        result.Tanggal = tbTanggal.Text;
                        result.Catatan = tbCatatan.Text;
                      
                        db.SaveChanges();
                        MessageBox.Show("Catatan berhasil diperbaharui");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Nama, Alamat, dan Nomor HP harus diisi");
                    }
                }
            }
        }

        private void btnAksi_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                TambahData();
            else if (mode == Mode.Edit)
                EditData();
        }

        private void InputDiary_Load(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

