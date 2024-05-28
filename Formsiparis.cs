using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace magazaproje
{
 public partial class Formsiparis : Form
 {
 public Formsiparis()
 {
 InitializeComponent();
 }
 NpgsqlConnection baglanti = new 
NpgsqlConnection("server=localHost; port=5432; Database=DBMagaza; user 
ID=postgres; password= Meriignay.01");
 private void Formsiparis_Load(object sender, EventArgs e)
 {
 baglanti.Open();
 NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from
kargofirmasi ", baglanti);
 DataTable dt = new DataTable();
 da.Fill(dt);
 comboBox1.DisplayMember = "kargofirmasiad";
 comboBox1.ValueMember = "kargofirmasiid";
 comboBox1.DataSource = dt;
 baglanti.Close();
 }
 private void label1_Click(object sender, EventArgs e)
 {
 }
 private void button4_Click(object sender, EventArgs e)
 {
 }
 private void button3_Click(object sender, EventArgs e)
 {
 }
 private void button2_Click(object sender, EventArgs e)
 {
 }
 
 private void label2_Click(object sender, EventArgs e)
 {
 }
 private void button1_Click(object sender, EventArgs e)
 {
 }
 
 private void dataGridView1_CellContentClick(object sender, 
DataGridViewCellEventArgs e)
 {
 }
 private void button5_Click(object sender, EventArgs e)
 {
 }
 private void btnlistele_Click(object sender, EventArgs e)
 {
 string sorgu = "select * from siparis";
 NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, 
baglanti);
 DataSet ds = new DataSet();
 da.Fill(ds);
 dataGridView1.DataSource = ds.Tables[0];
 }
 private void comboboxkargofirma_SelectedIndexChanged(object 
sender, EventArgs e)
 {
 
 }
 private void btnekle_Click(object sender, EventArgs e)
 {
 baglanti.Open();
 NpgsqlCommand komut = new NpgsqlCommand("insert into 
siparis (siparisid,kargofirmasiid,adresid) values (@p1,@p2,@p3)", 
baglanti);
 komut.Parameters.AddWithValue("@p1", int.Parse 
(textBox2.Text));
 komut.Parameters.AddWithValue("@p2", int.Parse 
(comboBox1.SelectedValue.ToString()));
 komut.Parameters.AddWithValue("@p3", int.Parse 
(textBox1.Text));
 komut.ExecuteNonQuery();
 baglanti.Close();
 MessageBox.Show("Siparis kaydi basariyla 
gerceklesti.","Bilgi", MessageBoxButtons.OK, 
MessageBoxIcon.Information);
 }
 private void textBox2_TextChanged_1(object sender, EventArgs e)
 {
 
 }
 private void textBox1_TextChanged_1(object sender, EventArgs e)
 {
 
 }
 private void label3_Click(object sender, EventArgs e)
 {
 }
 private void btnsil_Click(object sender, EventArgs e)
 {
 baglanti.Open();
 NpgsqlCommand komut2 = new NpgsqlCommand("Delete from 
siparis where siparisid=@p1", baglanti);
 komut2.Parameters.AddWithValue("@p1", 
int.Parse(textBox2.Text));
 komut2.ExecuteNonQuery();
 baglanti.Close();
 MessageBox.Show("Urun silme islemi basariyla gerceklesti.",
"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
 
 }
 private void btnguncelle_Click(object sender, EventArgs e)
 {
 baglanti.Open();
 NpgsqlCommand komut3 = new NpgsqlCommand("update 
public.\"siparis\" set \"kargofirmasiid\"=@p2,\"adresid\"=@p3 " +
 "where \"siparisid\"=@p1", baglanti);
 komut3.Parameters.AddWithValue("@p1", 
int.Parse(textBox2.Text));
 komut3.Parameters.AddWithValue("@p2", 
int.Parse(comboBox1.SelectedValue.ToString()));
 komut3.Parameters.AddWithValue("@p3", 
int.Parse(textBox1.Text));
 komut3.ExecuteNonQuery();
 MessageBox.Show(" güncelleme işlemi başarılı oldu", 
"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 baglanti.Close();
 }
 private void comboBox1_SelectedIndexChanged(object sender, 
EventArgs e)
 {
 }
 private void Formsiparis_FormClosing(object sender, 
FormClosingEventArgs e)
 {
 
 }
 }
}
