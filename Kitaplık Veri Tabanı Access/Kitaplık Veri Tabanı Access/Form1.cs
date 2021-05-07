using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplık_Veri_Tabanı_Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Kitaplar", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\profe\Desktop\Access Verileri\Kitaplık.mdb");
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
        string durum = "";
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAd,KitapYazar,KitapTur,KitapSayfa,KitapDurum)values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtyaz.Text);
            komut.Parameters.AddWithValue("@p3", cmbtür.Text);
            komut.Parameters.AddWithValue("@p4", txtsayfa.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitabınız Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdkul_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void rdsıf_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtyaz.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbtür.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();


            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                rdsıf.Checked = true;

            }
            else
            {
                rdkul.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Kitaplar where KitapID=@p6", baglanti);

            komut.Parameters.AddWithValue("@g6", txtıd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitabınız Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Kitaplar set KitapAd=@g1,KitapYazar=@g2,KitapTur=@g3,KitapSayfa=@g4,KitapDurum=@g5 where KitapID=@g6", baglanti);
            komut.Parameters.AddWithValue("@g1", txtad.Text);
            komut.Parameters.AddWithValue("@g2", txtyaz.Text);
            komut.Parameters.AddWithValue("@g3", cmbtür.Text);
            komut.Parameters.AddWithValue("@g4", txtsayfa.Text);
            if (rdkul.Checked == true)
            {
                komut.Parameters.AddWithValue("@g5", durum);
            }
            if (rdsıf.Checked == true)
            {
                komut.Parameters.AddWithValue("@g5",durum);
            }
               


            komut.Parameters.AddWithValue("@g6", txtıd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitabınız Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from Kitaplar where KitapAd=@f1",baglanti);
            komut.Parameters.AddWithValue("@f1",textBox1.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
        }

        private void btnbul2_Click(object sender, EventArgs e)
        {
           
         
           
        }
    }
}
