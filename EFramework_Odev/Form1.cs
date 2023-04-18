using EFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFramwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunDal _UrunDal = new UrunDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            load1();
        }

        private void load1()
        {
            dataGridView1.DataSource = _UrunDal.GetAll();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            _UrunDal.Add(new Urun
            {
                Ad = txtadekle.Text,
                Fiyat = Convert.ToDouble(txtfiyatekle.Text),
                Adet = Convert.ToInt32(txtadetekle.Text)

            });
            MessageBox.Show("Ürün Başarlı Bir Şekilde Eklendi..");
            load1();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadguncelle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtfiyatguncelle.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtadetguncelle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnguncelle_Click_1(object sender, EventArgs e)
        {
            _UrunDal.Update(new Urun
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Ad = txtadguncelle.Text,
                Fiyat = Convert.ToDouble(txtfiyatguncelle.Text),
                Adet = Convert.ToInt32(txtadetguncelle.Text)
            });
            MessageBox.Show("Update işlemleri Başarlı Bir Şekilde Gerçekleşti...");
            load1();
        }

        private void btnsil_Click_1(object sender, EventArgs e)
        {
            _UrunDal.Delete(new Urun
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Silme İşlemi başarlı Bir şekilde yapılmıştır...");
            load1();
        }


    }
}
