namespace PV07_Kasir
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelKodeBarang = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelHargaBeli = new System.Windows.Forms.Label();
            this.labelHargaJual = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelSatuan = new System.Windows.Forms.Label();
            this.labelDistributor = new System.Windows.Forms.Label();
            this.textBoxKodeBarang = new System.Windows.Forms.TextBox();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.textBoxHargaBeli = new System.Windows.Forms.TextBox();
            this.textBoxHargaJual = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxSatuan = new System.Windows.Forms.TextBox();
            this.textBoxDistributor = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pnlDist = new System.Windows.Forms.Panel();
            this.pnlSatuan = new System.Windows.Forms.Panel();
            this.pnlJumlah = new System.Windows.Forms.Panel();
            this.pnlJual = new System.Windows.Forms.Panel();
            this.pnlBeli = new System.Windows.Forms.Panel();
            this.pnlNama = new System.Windows.Forms.Panel();
            this.pnlKode = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelMain.SuspendLayout();
            this.pnlDist.SuspendLayout();
            this.pnlSatuan.SuspendLayout();
            this.pnlJumlah.SuspendLayout();
            this.pnlJual.SuspendLayout();
            this.pnlBeli.SuspendLayout();
            this.pnlNama.SuspendLayout();
            this.pnlKode.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKodeBarang
            // 
            this.labelKodeBarang.AutoSize = true;
            this.labelKodeBarang.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelKodeBarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.labelKodeBarang.Location = new System.Drawing.Point(30, 48);
            this.labelKodeBarang.Name = "labelKodeBarang";
            this.labelKodeBarang.Size = new System.Drawing.Size(120, 23);
            this.labelKodeBarang.TabIndex = 0;
            this.labelKodeBarang.Text = "Kode Barang";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelNamaBarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.labelNamaBarang.Location = new System.Drawing.Point(30, 81);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(126, 23);
            this.labelNamaBarang.TabIndex = 1;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // labelHargaBeli
            // 
            this.labelHargaBeli.AutoSize = true;
            this.labelHargaBeli.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelHargaBeli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.labelHargaBeli.Location = new System.Drawing.Point(30, 114);
            this.labelHargaBeli.Name = "labelHargaBeli";
            this.labelHargaBeli.Size = new System.Drawing.Size(99, 23);
            this.labelHargaBeli.TabIndex = 2;
            this.labelHargaBeli.Text = "Harga Beli";
            // 
            // labelHargaJual
            // 
            this.labelHargaJual.AutoSize = true;
            this.labelHargaJual.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelHargaJual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.labelHargaJual.Location = new System.Drawing.Point(30, 147);
            this.labelHargaJual.Name = "labelHargaJual";
            this.labelHargaJual.Size = new System.Drawing.Size(98, 23);
            this.labelHargaJual.TabIndex = 3;
            this.labelHargaJual.Text = "Harga Jual";
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelJumlah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.labelJumlah.Location = new System.Drawing.Point(335, 48);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(70, 23);
            this.labelJumlah.TabIndex = 4;
            this.labelJumlah.Text = "Jumlah";
            // 
            // labelSatuan
            // 
            this.labelSatuan.AutoSize = true;
            this.labelSatuan.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelSatuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.labelSatuan.Location = new System.Drawing.Point(335, 81);
            this.labelSatuan.Name = "labelSatuan";
            this.labelSatuan.Size = new System.Drawing.Size(69, 23);
            this.labelSatuan.TabIndex = 5;
            this.labelSatuan.Text = "Satuan";
            // 
            // labelDistributor
            // 
            this.labelDistributor.AutoSize = true;
            this.labelDistributor.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelDistributor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.labelDistributor.Location = new System.Drawing.Point(335, 114);
            this.labelDistributor.Name = "labelDistributor";
            this.labelDistributor.Size = new System.Drawing.Size(107, 23);
            this.labelDistributor.TabIndex = 6;
            this.labelDistributor.Text = "Distributor";
            // 
            // textBoxKodeBarang
            // 
            this.textBoxKodeBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.textBoxKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKodeBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxKodeBarang.Font = new System.Drawing.Font("Cambria", 10F);
            this.textBoxKodeBarang.Location = new System.Drawing.Point(1, 1);
            this.textBoxKodeBarang.Name = "textBoxKodeBarang";
            this.textBoxKodeBarang.Size = new System.Drawing.Size(178, 24);
            this.textBoxKodeBarang.TabIndex = 7;
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.textBoxNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNamaBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNamaBarang.Font = new System.Drawing.Font("Cambria", 10F);
            this.textBoxNamaBarang.Location = new System.Drawing.Point(1, 1);
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(178, 24);
            this.textBoxNamaBarang.TabIndex = 8;
            // 
            // textBoxHargaBeli
            // 
            this.textBoxHargaBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.textBoxHargaBeli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHargaBeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHargaBeli.Font = new System.Drawing.Font("Cambria", 10F);
            this.textBoxHargaBeli.Location = new System.Drawing.Point(1, 1);
            this.textBoxHargaBeli.Name = "textBoxHargaBeli";
            this.textBoxHargaBeli.Size = new System.Drawing.Size(178, 24);
            this.textBoxHargaBeli.TabIndex = 9;
            // 
            // textBoxHargaJual
            // 
            this.textBoxHargaJual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.textBoxHargaJual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHargaJual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHargaJual.Font = new System.Drawing.Font("Cambria", 10F);
            this.textBoxHargaJual.Location = new System.Drawing.Point(1, 1);
            this.textBoxHargaJual.Name = "textBoxHargaJual";
            this.textBoxHargaJual.Size = new System.Drawing.Size(178, 24);
            this.textBoxHargaJual.TabIndex = 10;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.textBoxJumlah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxJumlah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxJumlah.Font = new System.Drawing.Font("Cambria", 10F);
            this.textBoxJumlah.Location = new System.Drawing.Point(1, 1);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(178, 24);
            this.textBoxJumlah.TabIndex = 11;
            // 
            // textBoxSatuan
            // 
            this.textBoxSatuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.textBoxSatuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSatuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSatuan.Font = new System.Drawing.Font("Cambria", 10F);
            this.textBoxSatuan.Location = new System.Drawing.Point(1, 1);
            this.textBoxSatuan.Name = "textBoxSatuan";
            this.textBoxSatuan.Size = new System.Drawing.Size(178, 24);
            this.textBoxSatuan.TabIndex = 12;
            // 
            // textBoxDistributor
            // 
            this.textBoxDistributor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.textBoxDistributor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDistributor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDistributor.Font = new System.Drawing.Font("Cambria", 10F);
            this.textBoxDistributor.Location = new System.Drawing.Point(1, 1);
            this.textBoxDistributor.Name = "textBoxDistributor";
            this.textBoxDistributor.Size = new System.Drawing.Size(178, 24);
            this.textBoxDistributor.TabIndex = 13;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(220)))), ((int)(((byte)(160)))));
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.btnSimpan.Location = new System.Drawing.Point(340, 140);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(90, 32);
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(235)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
            this.btnEdit.Location = new System.Drawing.Point(436, 140);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 32);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.Location = new System.Drawing.Point(527, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 32);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Font = new System.Drawing.Font("Cambria", 9F);
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.dataGridView.Location = new System.Drawing.Point(15, 215);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(620, 185);
            this.dataGridView.TabIndex = 17;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.pnlDist);
            this.panelMain.Controls.Add(this.pnlSatuan);
            this.panelMain.Controls.Add(this.pnlJumlah);
            this.panelMain.Controls.Add(this.pnlJual);
            this.panelMain.Controls.Add(this.pnlBeli);
            this.panelMain.Controls.Add(this.pnlNama);
            this.panelMain.Controls.Add(this.pnlKode);
            this.panelMain.Controls.Add(this.labelKodeBarang);
            this.panelMain.Controls.Add(this.labelNamaBarang);
            this.panelMain.Controls.Add(this.btnDelete);
            this.panelMain.Controls.Add(this.labelHargaBeli);
            this.panelMain.Controls.Add(this.btnEdit);
            this.panelMain.Controls.Add(this.labelHargaJual);
            this.panelMain.Controls.Add(this.btnSimpan);
            this.panelMain.Controls.Add(this.labelJumlah);
            this.panelMain.Controls.Add(this.labelSatuan);
            this.panelMain.Controls.Add(this.labelDistributor);
            this.panelMain.Location = new System.Drawing.Point(15, 17);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(620, 185);
            this.panelMain.TabIndex = 18;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // pnlDist
            // 
            this.pnlDist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.pnlDist.Controls.Add(this.textBoxDistributor);
            this.pnlDist.Location = new System.Drawing.Point(425, 111);
            this.pnlDist.Name = "pnlDist";
            this.pnlDist.Padding = new System.Windows.Forms.Padding(1);
            this.pnlDist.Size = new System.Drawing.Size(180, 18);
            this.pnlDist.TabIndex = 24;
            // 
            // pnlSatuan
            // 
            this.pnlSatuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.pnlSatuan.Controls.Add(this.textBoxSatuan);
            this.pnlSatuan.Location = new System.Drawing.Point(425, 78);
            this.pnlSatuan.Name = "pnlSatuan";
            this.pnlSatuan.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSatuan.Size = new System.Drawing.Size(180, 18);
            this.pnlSatuan.TabIndex = 23;
            // 
            // pnlJumlah
            // 
            this.pnlJumlah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.pnlJumlah.Controls.Add(this.textBoxJumlah);
            this.pnlJumlah.Location = new System.Drawing.Point(425, 45);
            this.pnlJumlah.Name = "pnlJumlah";
            this.pnlJumlah.Padding = new System.Windows.Forms.Padding(1);
            this.pnlJumlah.Size = new System.Drawing.Size(180, 18);
            this.pnlJumlah.TabIndex = 22;
            // 
            // pnlJual
            // 
            this.pnlJual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.pnlJual.Controls.Add(this.textBoxHargaJual);
            this.pnlJual.Location = new System.Drawing.Point(130, 144);
            this.pnlJual.Name = "pnlJual";
            this.pnlJual.Padding = new System.Windows.Forms.Padding(1);
            this.pnlJual.Size = new System.Drawing.Size(180, 18);
            this.pnlJual.TabIndex = 21;
            // 
            // pnlBeli
            // 
            this.pnlBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.pnlBeli.Controls.Add(this.textBoxHargaBeli);
            this.pnlBeli.Location = new System.Drawing.Point(130, 111);
            this.pnlBeli.Name = "pnlBeli";
            this.pnlBeli.Padding = new System.Windows.Forms.Padding(1);
            this.pnlBeli.Size = new System.Drawing.Size(180, 18);
            this.pnlBeli.TabIndex = 20;
            // 
            // pnlNama
            // 
            this.pnlNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.pnlNama.Controls.Add(this.textBoxNamaBarang);
            this.pnlNama.Location = new System.Drawing.Point(130, 78);
            this.pnlNama.Name = "pnlNama";
            this.pnlNama.Padding = new System.Windows.Forms.Padding(1);
            this.pnlNama.Size = new System.Drawing.Size(180, 18);
            this.pnlNama.TabIndex = 19;
            // 
            // pnlKode
            // 
            this.pnlKode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.pnlKode.Controls.Add(this.textBoxKodeBarang);
            this.pnlKode.Location = new System.Drawing.Point(130, 45);
            this.pnlKode.Name = "pnlKode";
            this.pnlKode.Padding = new System.Windows.Forms.Padding(1);
            this.pnlKode.Size = new System.Drawing.Size(180, 18);
            this.pnlKode.TabIndex = 18;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.labelTitle.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.labelTitle.Location = new System.Drawing.Point(25, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(284, 26);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = " Management Data Barang ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(650, 412);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Cambria", 10F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasir";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.pnlDist.ResumeLayout(false);
            this.pnlDist.PerformLayout();
            this.pnlSatuan.ResumeLayout(false);
            this.pnlSatuan.PerformLayout();
            this.pnlJumlah.ResumeLayout(false);
            this.pnlJumlah.PerformLayout();
            this.pnlJual.ResumeLayout(false);
            this.pnlJual.PerformLayout();
            this.pnlBeli.ResumeLayout(false);
            this.pnlBeli.PerformLayout();
            this.pnlNama.ResumeLayout(false);
            this.pnlNama.PerformLayout();
            this.pnlKode.ResumeLayout(false);
            this.pnlKode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKodeBarang;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label labelHargaBeli;
        private System.Windows.Forms.Label labelHargaJual;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelSatuan;
        private System.Windows.Forms.Label labelDistributor;
        private System.Windows.Forms.TextBox textBoxKodeBarang;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.TextBox textBoxHargaBeli;
        private System.Windows.Forms.TextBox textBoxHargaJual;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxSatuan;
        private System.Windows.Forms.TextBox textBoxDistributor;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel pnlKode;
        private System.Windows.Forms.Panel pnlNama;
        private System.Windows.Forms.Panel pnlBeli;
        private System.Windows.Forms.Panel pnlJual;
        private System.Windows.Forms.Panel pnlJumlah;
        private System.Windows.Forms.Panel pnlSatuan;
        private System.Windows.Forms.Panel pnlDist;
        
        private void panelMain_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, this.panelMain.ClientRectangle, System.Drawing.Color.FromArgb(140, 180, 220), System.Windows.Forms.ButtonBorderStyle.Solid);
        }
    }
}
