
namespace Kitaplık_Veri_Tabanı_Access
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdkul = new System.Windows.Forms.RadioButton();
            this.rdsıf = new System.Windows.Forms.RadioButton();
            this.txtyaz = new System.Windows.Forms.TextBox();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnbul = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbtür = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(944, 134);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Türü :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Durumu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kitap Sayfası : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kitap Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kitap Yazarı : ";
            // 
            // rdkul
            // 
            this.rdkul.AutoSize = true;
            this.rdkul.Location = new System.Drawing.Point(254, 284);
            this.rdkul.Name = "rdkul";
            this.rdkul.Size = new System.Drawing.Size(159, 31);
            this.rdkul.TabIndex = 7;
            this.rdkul.TabStop = true;
            this.rdkul.Text = "İkinci El";
            this.rdkul.UseVisualStyleBackColor = true;
            this.rdkul.CheckedChanged += new System.EventHandler(this.rdkul_CheckedChanged);
            // 
            // rdsıf
            // 
            this.rdsıf.AutoSize = true;
            this.rdsıf.Location = new System.Drawing.Point(447, 284);
            this.rdsıf.Name = "rdsıf";
            this.rdsıf.Size = new System.Drawing.Size(103, 31);
            this.rdsıf.TabIndex = 8;
            this.rdsıf.TabStop = true;
            this.rdsıf.Text = "Sıfır";
            this.rdsıf.UseVisualStyleBackColor = true;
            this.rdsıf.CheckedChanged += new System.EventHandler(this.rdsıf_CheckedChanged);
            // 
            // txtyaz
            // 
            this.txtyaz.Location = new System.Drawing.Point(254, 126);
            this.txtyaz.Name = "txtyaz";
            this.txtyaz.Size = new System.Drawing.Size(244, 34);
            this.txtyaz.TabIndex = 9;
            // 
            // txtsayfa
            // 
            this.txtsayfa.Location = new System.Drawing.Point(254, 170);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(244, 34);
            this.txtsayfa.TabIndex = 10;
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(254, 31);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(244, 34);
            this.txtıd.TabIndex = 11;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(254, 79);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(244, 34);
            this.txtad.TabIndex = 12;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(574, 59);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(170, 42);
            this.btnlist.TabIndex = 14;
            this.btnlist.Text = "Listele";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(574, 203);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(170, 42);
            this.btngüncelle.TabIndex = 15;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(574, 155);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(170, 42);
            this.btnsil.TabIndex = 16;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(574, 107);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(170, 42);
            this.btnkaydet.TabIndex = 17;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(762, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(811, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(574, 254);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(170, 47);
            this.btnbul.TabIndex = 20;
            this.btnbul.Text = "Bul ";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 34);
            this.textBox1.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 27);
            this.label9.TabIndex = 23;
            this.label9.Text = "Kitap Adı :";
            // 
            // cmbtür
            // 
            this.cmbtür.FormattingEnabled = true;
            this.cmbtür.Location = new System.Drawing.Point(254, 225);
            this.cmbtür.Name = "cmbtür";
            this.cmbtür.Size = new System.Drawing.Size(244, 33);
            this.cmbtür.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(972, 541);
            this.Controls.Add(this.cmbtür);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.txtsayfa);
            this.Controls.Add(this.txtyaz);
            this.Controls.Add(this.rdsıf);
            this.Controls.Add(this.rdkul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdkul;
        private System.Windows.Forms.RadioButton rdsıf;
        private System.Windows.Forms.TextBox txtyaz;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbtür;
    }
}

