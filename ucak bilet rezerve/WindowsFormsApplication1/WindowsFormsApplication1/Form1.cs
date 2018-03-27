using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm2.frm1 = this;
            frm3.frm1 = this;
        }
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=data.accdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet dtst = new DataSet();

        public void combo()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from bos";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            comboBox1.Sorted = true;
        }

        public void combo2()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from dolu";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                frm3.comboBox1.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            frm3.comboBox1.Sorted = true;
        }

        public void listelesene()
        {
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From musbil", bag);
            adtr.Fill(dtst, "musbil");
            frm3.dataView1.Table = dtst.Tables[0];
            frm3.dataGrid1.DataSource = frm3.dataView1;
            adtr.Dispose();
            bag.Close();
        }

        public void rezervasyonyaz()
        {


            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from musbil";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                switch (oku[13].ToString())
                {
                    case "1":
                        {
                            frm2.button1.Text = oku[4].ToString();
                            frm2.button1.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "2":
                        {
                            frm2.button2.Text = oku[4].ToString();
                            frm2.button2.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "3":
                        {
                            frm2.button3.Text = oku[4].ToString();
                            frm2.button3.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "4":
                        {
                            frm2.button4.Text = oku[4].ToString();
                            frm2.button4.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "5":
                        {
                            frm2.button5.Text = oku[4].ToString();
                            frm2.button5.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "6":
                        {
                            frm2.button6.Text = oku[4].ToString();
                            frm2.button6.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "7":
                        {
                            frm2.button7.Text = oku[4].ToString();
                            frm2.button7.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "8":
                        {
                            frm2.button8.Text = oku[4].ToString();
                            frm2.button8.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "9":
                        {
                            frm2.button9.Text = oku[4].ToString();
                            frm2.button9.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "10":
                        {
                            frm2.button10.Text = oku[4].ToString();
                            frm2.button10.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "11":
                        {

                            frm2.button11.Text = oku[4].ToString();
                            frm2.button11.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "12":
                        {
                            frm2.button12.Text = oku[4].ToString();
                            frm2.button12.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "13":
                        {
                            frm2.button13.Text = oku[4].ToString();
                            frm2.button13.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "14":
                        {
                            frm2.button14.Text = oku[4].ToString();
                            frm2.button14.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "15":
                        {
                            frm2.button15.Text = oku[4].ToString();
                            frm2.button15.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "16":
                        {
                            frm2.button16.Text = oku[4].ToString();
                            frm2.button16.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "17":
                        {
                            frm2.button17.Text = oku[4].ToString();
                            frm2.button17.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "18":
                        {
                            frm2.button18.Text = oku[4].ToString();
                            frm2.button18.BackColor = System.Drawing.Color.Red;
                            break;
                        }

                }
            }
                bag.Close();
                oku.Dispose();
            }
        

        public void rezervasyonsil()
        {
            switch (frm3.comboBox1.Text)
            {
                case "1":
                    {
                        frm2.button1.Text = "1";
                        frm2.button1.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "2":
                    {

                        frm2.button2.Text = "2";
                        frm2.button2.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "3":
                    {
                        frm2.button3.Text = "3";
                        frm2.button3.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "4":
                    {
                        frm2.button4.Text = "4";
                        frm2.button4.BackColor = System.Drawing.Color.Red;
                        break;
                    }
                case "5":
                    {
                        frm2.button5.Text = "5";
                        frm2.button5.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "6":
                    {
                        frm2.button6.Text = "6";
                        frm2.button6.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "7":
                    {
                        frm2.button7.Text = "7";
                        frm2.button7.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "8":
                    {
                        frm2.button8.Text = "8";
                        frm2.button8.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "9":
                    {
                        frm2.button9.Text = "9";
                        frm2.button9.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "10":
                    {
                        frm2.button10.Text = "10";
                        frm2.button10.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "11":
                    {
                        frm2.button11.Text = "11";
                        frm2.button11.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "12":
                    {
                        frm2.button12.Text = "12";
                        frm2.button12.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "13":
                    {
                        frm2.button13.Text = "13";
                        frm2.button13.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "14":
                    {
                        frm2.button14.Text = "14";
                        frm2.button14.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "15":
                    {
                        frm2.button15.Text = "15";
                        frm2.button15.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "16":
                    {
                        frm2.button16.Text = "16";
                        frm2.button16.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "17":
                    {
                        frm2.button17.Text = "17";
                        frm2.button17.BackColor = System.Drawing.Color.Green;
                        break;
                    }
                case "18":
                    {
                        frm2.button18.Text = "18";
                        frm2.button18.BackColor = System.Drawing.Color.Green;
                        break;
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "INSERT INTO musbil(Cinsiyet,İsim,Soyisim,Dogum_Tarihi,Tc_Kimlik,Telefon,E_Posta,Kalkis_Yeri,Kalkis_Saati,Varis_Yeri,Varis_Saati,Gidis_Tar,Donus_Tar,Koltuk_Num) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + comboBox1.Text + "') ";
                kmt.ExecuteNonQuery();
                kmt.CommandText = "INSERT INTO dolu(doluyerler) VALUES ('" + comboBox1.Text + "') ";
                kmt.ExecuteNonQuery();
                kmt.CommandText = "DELETE from bos WHERE bosyerler='" + comboBox1.Text + "'";
                kmt.ExecuteNonQuery();
                kmt.Dispose();
                bag.Close();
                comboBox1.Items.Clear();
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear();
                textBox9.Clear(); textBox10.Clear(); textBox11.Clear(); textBox12.Clear();
                textBox13.Clear();
                comboBox1.Text = "";
                combo();
                rezervasyonyaz();
                MessageBox.Show("Kayıt işlemi tamamlandı ! ");
            }
            else
            {
                MessageBox.Show("Boş alanları doldurunuz !!!");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
