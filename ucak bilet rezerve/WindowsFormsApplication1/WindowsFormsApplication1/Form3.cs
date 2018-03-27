using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form1 frm1;
        public Form3()
        {
            InitializeComponent();
        }
        void texteyaz()
        {
            textBox14.Text = (this.BindingContext[frm1.dtst, "musbil"].Position + 1) + " / " + this.BindingContext[frm1.dtst, "musbil"].Count;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            frm1.combo2();
            frm1.listelesene();
            textBox1.DataBindings.Add("Text", frm1.dtst, "musbil.Cinsiyet");
            textBox2.DataBindings.Add("Text", frm1.dtst, "musbil.İsim");
            textBox3.DataBindings.Add("Text", frm1.dtst, "musbil.Soyisim");
            textBox4.DataBindings.Add("Text", frm1.dtst, "musbil.Dogum_Tarihi");
            textBox5.DataBindings.Add("Text", frm1.dtst, "musbil.Tc_Kimlik");
            textBox6.DataBindings.Add("Text", frm1.dtst, "musbil.Telefon");
            textBox7.DataBindings.Add("Text", frm1.dtst, "musbil.E_Posta");
            textBox8.DataBindings.Add("Text", frm1.dtst, "musbil.Kalkis_Yeri");
            textBox9.DataBindings.Add("Text", frm1.dtst, "musbil.Kalkis_Saati");
            textBox10.DataBindings.Add("Text", frm1.dtst, "musbil.Varis_Yeri");
            textBox11.DataBindings.Add("Text", frm1.dtst, "musbil.Varis_Saati");
            textBox12.DataBindings.Add("Text", frm1.dtst, "musbil.Gidis_Tar");
            textBox13.DataBindings.Add("Text", frm1.dtst, "musbil.Donus_Tar");
            comboBox1.DataBindings.Add("Text", frm1.dtst, "musbil.Koltuk_Num");
            texteyaz();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    frm1.rezervasyonsil();
                    frm1.bag.Open();
                    frm1.kmt.Connection = frm1.bag;
                    frm1.kmt.CommandText = "DELETE from musbil WHERE Tc_Kimlik = '" + textBox5.Text + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.CommandText = "INSERT INTO bos(bosyerler) VALUES ('" + comboBox1.Text + "') ";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.CommandText = "DELETE from dolu WHERE doluyerler='" + comboBox1.Text + "'";
                    frm1.kmt.ExecuteNonQuery();
                    frm1.kmt.Dispose();
                    frm1.bag.Close();
                    comboBox1.Items.Clear();
                    frm1.comboBox1.Items.Clear();
                    comboBox1.Text = "";
                    frm1.combo();
                    frm1.combo2();
                    frm1.dtst.Clear();
                    frm1.listelesene();
                }
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz !!!");
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position = 0;
            texteyaz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position -= 1;
            texteyaz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position += 1;
            texteyaz();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BindingContext[frm1.dtst, "musbil"].Position = this.BindingContext[frm1.dtst, "musbil"].Count;
            texteyaz();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }
    }
}
