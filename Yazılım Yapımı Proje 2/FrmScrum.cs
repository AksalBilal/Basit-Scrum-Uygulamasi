using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Yazılım_Yapımı_Proje_2
{
    public partial class FrmScrum : Form
    {
        public FrmScrum()
        {
            InitializeComponent();
        }
        public static StreamWriter streamWriter;
        public static FileStream fileStream;
        private void Form1_Load(object sender, EventArgs e)
        {
            //D:\ÖDEVLER\Yazılım Yapımı ödevleri\Yazılım Yapımı Proje 2
            string dosya_yolu = @"D:\ÖDEVLER\Yazılım Yapımı ödevleri\Yazılım Yapımı Proje 2\Yeni Metin Belgesi.txt";
            fileStream = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            streamWriter = new StreamWriter(fileStream);
            
        }
        public Control activeControl;
        public Point previousLocation;
       
        public static int txtLocationX;
        public static int txtLocationY;
        TextBox txt;
        TextBox txt2;
        Panel pnlStory;
        
        int j = 0;
        
        public void txt_MouseDown(object sender, MouseEventArgs e)
        {
            activeControl = sender as Control;
            previousLocation = e.Location;
            Cursor = Cursors.Hand;

        }  
        public void txt_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeControl == null || activeControl != sender)
                return;

            var location = activeControl.Location;
            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
            activeControl.Location = location;

        }
        public void txt_MouseUp(object sender, MouseEventArgs e)
        {
            activeControl = null;
            Cursor = Cursors.Default;
            if (txt.Location.X >= 190 && txt.Location.X < 300)
            {
                txt.BackColor = Color.Lime;
            }
            else if (txt.Location.X > 415 && txt.Location.X < 528)
            {
                txt.BackColor = Color.Yellow;
            }
            else if (txt.Location.X > 640 && txt.Location.X < 752)
            {
                txt.BackColor = Color.Turquoise;
            }
            else
            {
                txt.BackColor = Color.Black;
            }
            txtLocationX = txt.Location.X;
            txtLocationY = txt.Location.Y;
        }
        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            pnlStory = new Panel();
            Point pnlyer = new Point(16, 20 + j);
            pnlStory.Location = pnlyer;
            pnlStory.Name = "pnl";
            pnlStory.Size = new Size(119, 52);
            grpStories.Controls.Add(pnlStory);
            txt = new TextBox();
            txt.Location = new Point(7,22);
            txt.Name = "txt";
            txt.Text = this.txtIcerik.Text;
            txt.Multiline = true;
            txt.BackColor = Color.Turquoise;
            this.Controls.Add(txt);
            txt.BringToFront();
            txt.MouseDown += new MouseEventHandler(txt_MouseDown);
            txt.MouseMove += new MouseEventHandler(txt_MouseMove);
            txt.MouseUp += new MouseEventHandler(txt_MouseUp);
        }

        private void btnStory_Click(object sender, EventArgs e)
        {
            btnStory.Visible = false;
            btnBitir.Visible = true;
            pnlStory = new Panel();
            Point pnlyer = new Point(16, 20 + j);
            pnlStory.Location = pnlyer;
            pnlStory.Name = "pnl";
            pnlStory.Size = new Size(119, 52);
            grpStories.Controls.Add(pnlStory);
            txt2 = new TextBox();
            Point txtyer = new Point(0, 0);
            txt2.Location = txtyer;
            txt2.Name = "txt";
            txt2.BackColor = Color.AliceBlue;
            txt2.Multiline = true;            
            txt2.Size = new Size(110, 50);
            pnlStory.Controls.Add(txt2);
            j += 58;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {            
            streamWriter.WriteLine("-" + txt2.Text);
            streamWriter.WriteLine(txtGorevli.Text);
            streamWriter.WriteLine(txtIcerik.Text);
            streamWriter.WriteLine(dateTimePicker1.Value);
            streamWriter.WriteLine(txtLocationX);
            streamWriter.WriteLine(txtLocationY);
            streamWriter.Flush();
            MessageBox.Show("Veritabanına Başarıyla kaydedildi");
            lblGörevli.Visible = false;
            lblIcerik.Visible = false;
            lblTarih.Visible = false;
            txtGorevli.Visible = false;
            btnKaydet.Visible = false;
            txtIcerik.Visible = false;
            dateTimePicker1.Visible = false;
        }
        private void btnYeniTask_Click(object sender, EventArgs e)
        {
            lblGörevli.Visible = true;
            lblIcerik.Visible = true;
            lblTarih.Visible = true;
            txtGorevli.Visible = true;
            btnKaydet.Visible = true;
            txtIcerik.Visible = true;
            dateTimePicker1.Visible = true;
        }
        private void btnBitir_Click(object sender, EventArgs e)
        {
            btnStory.Visible = true;
        } 
    }
}
