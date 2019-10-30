using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void btnYarisiStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

            //1) formun sağ tarafına bitiş çizgisi eklenecek ve 1. bitiren at mb iler kullanıcıya bildirecek. yarışma bittiğinde tüm atlar duracak.
            //2) Yarışı sıfırla butonu eklenecek ve tıklandığında sistem en başa dönecek.
            //3) sol üste köşeden label olacak ve o labelda anlık olarak hangi at önde bilgisi verilecek. örn( 1. Kulvardaki ŞahBatur önde götürüyor gibi)




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pc1.Left += rnd.Next(1, 20);
            pc2.Left += rnd.Next(1, 20);
            pc3.Left += rnd.Next(1, 20);


            if (pc1.Right > pc2.Right && pc1.Right > pc3.Right)
            {
                lblBilgilendirme.Text = "Yarışı 1. Kulvardaki Şahbatur önde götürüyor!";
            }
            else if (pc2.Right > pc1.Right && pc2.Right > pc3.Right)
            {
                lblBilgilendirme.Text = "Yarışı 2. Kulvardaki Gülbatur önde götürüyor!";
            }
            else if (pc3.Right > pc1.Right && pc3.Right > pc2.Right)
            {
                lblBilgilendirme.Text = "Yarışı 3. Kulvardaki Canbatur önde götürüyor!";
            }


            if (pc1.Right >= lblFinsh.Left)
            {
                timer1.Stop();
                lblBilgilendirme.Text = "Yarışı 1. Kulvardaki Şahbatur Kazandı";
                MessageBox.Show(lblBilgilendirme.Text);
            }
            else if (pc2.Right >= lblFinsh.Left)
            {
                timer1.Stop();
                lblBilgilendirme.Text = "Yarışı 2. Kulvardaki Gülbatur Kazandı";
                MessageBox.Show(lblBilgilendirme.Text);
            }
            else if (pc3.Right >= lblFinsh.Left)
            {
                timer1.Stop();
                lblBilgilendirme.Text = "Yarışı 3. Kulvardaki Canbatur Kazandı";
                MessageBox.Show(lblBilgilendirme.Text);
            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pc1.Left = pc2.Left = pc3.Left = 0;
            lblBilgilendirme.Text = "";
        }

        private void p1_MouseHover(object sender, EventArgs e)
        {
            pc1.Left += 15;
        }

        private void p2_MouseEnter(object sender, EventArgs e)
        {
            pc2.Left += 15;
        }

        private void p3_MouseEnter(object sender, EventArgs e)
        {
            pc3.Left += 15;
        }
    }
}
