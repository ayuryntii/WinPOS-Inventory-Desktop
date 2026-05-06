using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PV07_Kasir
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        
        // Variabel untuk menyimpan Kode Barang lama sebelum diedit
        private string originalID = "";

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
                // Menambahkan ORDER BY agar data selalu urut berdasarkan Kode Barang
                cmd = new SqlCommand("SELECT * FROM TBL_BARANG ORDER BY KodeBarang ASC", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_BARANG");
                dataGridView.DataSource = ds;
                dataGridView.DataMember = "TBL_BARANG";
                
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                
                // Set Header names
                dataGridView.Columns[0].HeaderText = "Kode";
                dataGridView.Columns[1].HeaderText = "Nama Barang";
                dataGridView.Columns[2].HeaderText = "Harga Jual";
                dataGridView.Columns[3].HeaderText = "Harga Beli";
                dataGridView.Columns[4].HeaderText = "Stok";
                dataGridView.Columns[5].HeaderText = "Satuan";
                dataGridView.Columns[6].HeaderText = "Distributor";

                // Ensure the last column fills the remaining space if any
                dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            originalID = "";
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
                    cmd = new SqlCommand("INSERT INTO TBL_BARANG (KodeBarang, NamaBarang, HargaJual, HargaBeli, JumlahBarang, SatuanBarang, Distributor) VALUES ('" + textBoxKodeBarang.Text + "','" + textBoxNamaBarang.Text + "','" + textBoxHargaJual.Text + "','" + textBoxHargaBeli.Text + "','" + textBoxJumlah.Text + "','" + textBoxSatuan.Text + "','" + textBoxDistributor.Text + "')", conn);
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
            if (textBoxKodeBarang.Text.Trim() == "" || originalID == "")
            {
                MessageBox.Show("Pilih data dari tabel terlebih dahulu!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    // Update menggunakan originalID sebagai kunci agar KodeBarang bisa dirubah
                    cmd = new SqlCommand("UPDATE TBL_BARANG SET KodeBarang='" + textBoxKodeBarang.Text + "', NamaBarang='" + textBoxNamaBarang.Text + "', HargaJual='" + textBoxHargaJual.Text + "', HargaBeli='" + textBoxHargaBeli.Text + "', JumlahBarang='" + textBoxJumlah.Text + "', SatuanBarang='" + textBoxSatuan.Text + "', Distributor='" + textBoxDistributor.Text + "' WHERE KodeBarang='" + originalID + "'", conn);
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
                if (MessageBox.Show("Yakin ingin menghapus data " + textBoxKodeBarang.Text + "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conn = Konn.GetConn();
                    try
                    {
                        conn.Open();
                        
                        // 1. Hapus data yang dipilih
                        cmd = new SqlCommand("DELETE FROM TBL_BARANG WHERE KodeBarang = '" + textBoxKodeBarang.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        
                        // 2. Re-indexing: Ambil semua data yang tersisa dan urutkan
                        cmd = new SqlCommand("SELECT * FROM TBL_BARANG ORDER BY KodeBarang ASC", conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        
                        // 3. Update semua KodeBarang agar urut kembali (B001, B002, dst)
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string newID = "B" + (i + 1).ToString("D3"); // Menghasilkan B001, B002, dst
                            string currentID = dt.Rows[i]["KodeBarang"].ToString();
                            
                            if (currentID != newID)
                            {
                                SqlCommand updateCmd = new SqlCommand("UPDATE TBL_BARANG SET KodeBarang = '" + newID + "' WHERE KodeBarang = '" + currentID + "'", conn);
                                updateCmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Data berhasil dihapus dan urutan diperbarui!");
                        TampilBarang();
                        Bersihkan();
                    }
                    catch (Exception G)
                    {
                        MessageBox.Show(G.ToString());
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
                textBoxHargaJual.Text = row.Cells["HargaJual"].Value.ToString();
                textBoxHargaBeli.Text = row.Cells["HargaBeli"].Value.ToString();
                textBoxJumlah.Text = row.Cells["JumlahBarang"].Value.ToString();
                textBoxSatuan.Text = row.Cells["SatuanBarang"].Value.ToString();
                textBoxDistributor.Text = row.Cells["Distributor"].Value.ToString();
                
                // Simpan ID asli untuk keperluan Edit Kode Barang
                originalID = textBoxKodeBarang.Text;
            }
            catch { }
        }
    }
}
