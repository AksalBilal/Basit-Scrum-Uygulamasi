namespace Yazılım_Yapımı_Proje_2
{
    partial class FrmScrum
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.txtGorevli = new System.Windows.Forms.TextBox();
            this.grpInProgress = new System.Windows.Forms.GroupBox();
            this.grpNotStarted = new System.Windows.Forms.GroupBox();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.btnStory = new System.Windows.Forms.Button();
            this.grpDone = new System.Windows.Forms.GroupBox();
            this.grpStories = new System.Windows.Forms.GroupBox();
            this.btnBitir = new System.Windows.Forms.Button();
            this.lblGörevli = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.btnYeniTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(984, 541);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(104, 53);
            this.btnKaydet.TabIndex = 33;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(725, 560);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Visible = false;
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(402, 558);
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(100, 22);
            this.txtIcerik.TabIndex = 31;
            this.txtIcerik.Visible = false;
            // 
            // txtGorevli
            // 
            this.txtGorevli.Location = new System.Drawing.Point(157, 558);
            this.txtGorevli.Name = "txtGorevli";
            this.txtGorevli.Size = new System.Drawing.Size(100, 22);
            this.txtGorevli.TabIndex = 30;
            this.txtGorevli.Visible = false;
            // 
            // grpInProgress
            // 
            this.grpInProgress.ForeColor = System.Drawing.Color.Blue;
            this.grpInProgress.Location = new System.Drawing.Point(554, 35);
            this.grpInProgress.Margin = new System.Windows.Forms.Padding(4);
            this.grpInProgress.Name = "grpInProgress";
            this.grpInProgress.Padding = new System.Windows.Forms.Padding(4);
            this.grpInProgress.Size = new System.Drawing.Size(281, 422);
            this.grpInProgress.TabIndex = 27;
            this.grpInProgress.TabStop = false;
            this.grpInProgress.Text = "In Progress";
            // 
            // grpNotStarted
            // 
            this.grpNotStarted.ForeColor = System.Drawing.Color.Blue;
            this.grpNotStarted.Location = new System.Drawing.Point(250, 35);
            this.grpNotStarted.Margin = new System.Windows.Forms.Padding(4);
            this.grpNotStarted.Name = "grpNotStarted";
            this.grpNotStarted.Padding = new System.Windows.Forms.Padding(4);
            this.grpNotStarted.Size = new System.Drawing.Size(281, 422);
            this.grpNotStarted.TabIndex = 26;
            this.grpNotStarted.TabStop = false;
            this.grpNotStarted.Text = "Not Started";
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTaskEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnTaskEkle.Location = new System.Drawing.Point(855, 468);
            this.btnTaskEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(281, 55);
            this.btnTaskEkle.TabIndex = 29;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.UseVisualStyleBackColor = false;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // btnStory
            // 
            this.btnStory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStory.Location = new System.Drawing.Point(29, 468);
            this.btnStory.Margin = new System.Windows.Forms.Padding(4);
            this.btnStory.Name = "btnStory";
            this.btnStory.Size = new System.Drawing.Size(193, 55);
            this.btnStory.TabIndex = 28;
            this.btnStory.Text = "Story Ekle";
            this.btnStory.UseVisualStyleBackColor = true;
            this.btnStory.Click += new System.EventHandler(this.btnStory_Click);
            // 
            // grpDone
            // 
            this.grpDone.ForeColor = System.Drawing.Color.Blue;
            this.grpDone.Location = new System.Drawing.Point(855, 35);
            this.grpDone.Margin = new System.Windows.Forms.Padding(4);
            this.grpDone.Name = "grpDone";
            this.grpDone.Padding = new System.Windows.Forms.Padding(4);
            this.grpDone.Size = new System.Drawing.Size(281, 422);
            this.grpDone.TabIndex = 25;
            this.grpDone.TabStop = false;
            this.grpDone.Text = "Done";
            // 
            // grpStories
            // 
            this.grpStories.ForeColor = System.Drawing.Color.Blue;
            this.grpStories.Location = new System.Drawing.Point(29, 32);
            this.grpStories.Margin = new System.Windows.Forms.Padding(4);
            this.grpStories.Name = "grpStories";
            this.grpStories.Padding = new System.Windows.Forms.Padding(4);
            this.grpStories.Size = new System.Drawing.Size(193, 425);
            this.grpStories.TabIndex = 34;
            this.grpStories.TabStop = false;
            this.grpStories.Text = "Stories";
            // 
            // btnBitir
            // 
            this.btnBitir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBitir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBitir.Location = new System.Drawing.Point(250, 468);
            this.btnBitir.Margin = new System.Windows.Forms.Padding(4);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(281, 55);
            this.btnBitir.TabIndex = 39;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = false;
            this.btnBitir.Visible = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // lblGörevli
            // 
            this.lblGörevli.AutoSize = true;
            this.lblGörevli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGörevli.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGörevli.Location = new System.Drawing.Point(57, 560);
            this.lblGörevli.Name = "lblGörevli";
            this.lblGörevli.Size = new System.Drawing.Size(81, 20);
            this.lblGörevli.TabIndex = 35;
            this.lblGörevli.Text = "Görevli :";
            this.lblGörevli.Visible = false;
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIcerik.ForeColor = System.Drawing.Color.DarkRed;
            this.lblIcerik.Location = new System.Drawing.Point(320, 560);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(67, 20);
            this.lblIcerik.TabIndex = 36;
            this.lblIcerik.Text = "İçerik :";
            this.lblIcerik.Visible = false;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTarih.Location = new System.Drawing.Point(550, 562);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(158, 20);
            this.lblTarih.TabIndex = 37;
            this.lblTarih.Text = "Başlangıç Tarihi :";
            this.lblTarih.Visible = false;
            // 
            // btnYeniTask
            // 
            this.btnYeniTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYeniTask.BackColor = System.Drawing.SystemColors.Control;
            this.btnYeniTask.Location = new System.Drawing.Point(554, 468);
            this.btnYeniTask.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeniTask.Name = "btnYeniTask";
            this.btnYeniTask.Size = new System.Drawing.Size(281, 55);
            this.btnYeniTask.TabIndex = 38;
            this.btnYeniTask.Text = "Yeni Task";
            this.btnYeniTask.UseVisualStyleBackColor = false;
            this.btnYeniTask.Click += new System.EventHandler(this.btnYeniTask_Click);
            // 
            // FrmScrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1155, 617);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnYeniTask);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblIcerik);
            this.Controls.Add(this.lblGörevli);
            this.Controls.Add(this.grpStories);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.txtGorevli);
            this.Controls.Add(this.grpInProgress);
            this.Controls.Add(this.grpNotStarted);
            this.Controls.Add(this.btnTaskEkle);
            this.Controls.Add(this.btnStory);
            this.Controls.Add(this.grpDone);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "FrmScrum";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.TextBox txtGorevli;
        private System.Windows.Forms.GroupBox grpInProgress;
        private System.Windows.Forms.GroupBox grpNotStarted;
        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.Button btnStory;
        private System.Windows.Forms.GroupBox grpDone;
        private System.Windows.Forms.GroupBox grpStories;
        private System.Windows.Forms.Label lblGörevli;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button btnYeniTask;
        private System.Windows.Forms.Button btnBitir;
    }
}

