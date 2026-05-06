using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PV_7_KasirInsert
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TampilBarang();
            Bersihkan();
        }

        void TampilBarang()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_BARANG", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_BARANG");
                dataGridView.DataSource = ds;
                dataGridView.DataMember = "TBL_BARANG";
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show("Gagal memuat data: " + G.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void Bersihkan()
        {
            textBoxKodeBarang.Text = "";
            textBoxNamaBarang.Text = "";
            textBoxHargaBeli.Text = "";
            textBoxHargaJual.Text = "";
            textBoxJumlah.Text = "";
            textBoxSatuan.Text = "";
            textBoxDistributor.Text = "";
            textBoxKodeBarang.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxKodeBarang.Text.Trim() == "" || textBoxNamaBarang.Text.Trim() == "" || textBoxDistributor.Text.Trim() == "")
            {
                MessageBox.Show("Mohon lengkapi semua data!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("INSERT INTO TBL_BARANG VALUES ('" + textBoxKodeBarang.Text + "','" + textBoxNamaBarang.Text + "','" + textBoxHargaBeli.Text + "','" + textBoxHargaJual.Text + "','" + textBoxJumlah.Text + "','" + textBoxSatuan.Text + "','" + textBoxDistributor.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan!");
                    TampilBarang();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan data: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textBoxKodeBarang.Text.Trim() == "")
            {
                MessageBox.Show("Pilih data yang akan diedit!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("UPDATE TBL_BARANG SET NamaBarang='" + textBoxNamaBarang.Text + "', HargaBeli='" + textBoxHargaBeli.Text + "', HargaJual='" + textBoxHargaJual.Text + "', JumlahBarang='" + textBoxJumlah.Text + "', SatuanBarang='" + textBoxSatuan.Text + "', Distributor='" + textBoxDistributor.Text + "' WHERE KodeBarang='" + textBoxKodeBarang.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diupdate!");
                    TampilBarang();
                    Bersihkan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengupdate data: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBoxKodeBarang.Text.Trim() == "")
            {
                MessageBox.Show("Pilih data yang akan dihapus!");
            }
            else
            {
                if (MessageBox.Show("Hapus data " + textBoxKodeBarang.Text + "?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlConnection conn = Konn.GetConn();
                    try
                    {
                        cmd = new SqlCommand("DELETE FROM TBL_BARANG WHERE KodeBarang='" + textBoxKodeBarang.Text + "'", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus!");
                        TampilBarang();
                        Bersihkan();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menghapus data: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                textBoxKodeBarang.Text = row.Cells["KodeBarang"].Value.ToString();
                textBoxNamaBarang.Text = row.Cells["NamaBarang"].Value.ToString();
                textBoxHargaBeli.Text = row.Cells["HargaBeli"].Value.ToString();
                textBoxHargaJual.Text = row.Cells["HargaJual"].Value.ToString();
                textBoxJumlah.Text = row.Cells["JumlahBarang"].Value.ToString();
                textBoxSatuan.Text = row.Cells["SatuanBarang"].Value.ToString();
                // Pastikan kolom Distributor ada di database, jika tidak hapus baris di bawah ini
                if(row.Cells["Distributor"] != null)
                    textBoxDistributor.Text = row.Cells["Distributor"].Value.ToString();
            }
            catch { }
        }
    }
}
