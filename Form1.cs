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
 public partial class Form1 : Form
 {
 public Form1()
 {
 InitializeComponent();
 }
 NpgsqlConnection baglanti = new 
NpgsqlConnection("server=localHost; port=5432; Database=DBMagaza; user 
ID=postgres; password= Meriignay.01");
 
 private void label1_Click(object sender, EventArgs e)
 {
 
 }
 private void label2_Click(object sender, EventArgs e)
 {
 }
 private void button1_Click(object sender, EventArgs e)
 {
 string sorgu = "select * from urun";
 NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, 
baglanti);
 DataSet ds = new DataSet();
 da.Fill(ds);
 dataGridView1.DataSource = ds.Tables[0];
 }
 private void button3_Click(object sender, EventArgs e)
 {
 baglanti.Open();
 NpgsqlCommand komut2 = new NpgsqlCommand("Delete from urun 
where urunid=@p1", baglanti);
 komut2.Parameters.AddWithValue("@p1", 
int.Parse(textBox2.Text));
 komut2.ExecuteNonQuery();
 baglanti.Close();
 MessageBox.Show("Urun silme islemi basariyla gerceklesti.",
"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
 }
 
 private void button2_Click(object sender, EventArgs e)
 {
 baglanti.Open();
 NpgsqlCommand komut1 = new NpgsqlCommand("insert into urun 
(urunid,urunadi,basimyili,sayfasayisi,magazaid,yazarid,cevirmenid,yayin
eviid,kategoriid) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p10)", 
baglanti);
 komut1.Parameters.AddWithValue("@p1", int.Parse 
(textBox2.Text));
 komut1.Parameters.AddWithValue("@p2", textBox1.Text);
 komut1.Parameters.AddWithValue("@p3", int.Parse 
(textbasimyiliid.Text));
 komut1.Parameters.AddWithValue("@p4", int.Parse 
(textsayfasayisiid.Text));
 komut1.Parameters.AddWithValue("@p5", int.Parse 
(textmagazaid.Text));
 komut1.Parameters.AddWithValue("@p6", int.Parse 
(textyazarid.Text));
 komut1.Parameters.AddWithValue("@p7", int.Parse 
(textcevirmenid.Text));
 komut1.Parameters.AddWithValue("@p8", int.Parse 
(textyayineviid.Text));
 // komut1.Parameters.AddWithValue("@p9", int.Parse 
(texturunsiparisid.Text));
 komut1.Parameters.AddWithValue("@p10", int.Parse 
(textkategoriid.Text));
 komut1.ExecuteNonQuery();
 baglanti.Close();
 MessageBox.Show("Urun basarili bir sekilde eklendi.");
 }
 private void dataGridView1_CellContentClick(object sender, 
DataGridViewCellEventArgs e)
 {
 }
 private void button4_Click(object sender, EventArgs e)
 {
 baglanti.Open();
 NpgsqlCommand komut3 = new NpgsqlCommand("update urun set 
urunadi=@p1, basimyili=@p2, sayfasayisi=@p3, magazaid=@p4 where 
urunid=@p5", baglanti);
 komut3.Parameters.AddWithValue("@p1", textBox1.Text);
 komut3.Parameters.AddWithValue("@p2", 
int.Parse(textbasimyiliid.Text));
 komut3.Parameters.AddWithValue("@p3", 
int.Parse(textsayfasayisiid.Text));
 komut3.Parameters.AddWithValue("@p4", 
int.Parse(textmagazaid.Text));
 komut3.Parameters.AddWithValue("@p5", 
int.Parse(textBox2.Text));
 komut3.ExecuteNonQuery();
 MessageBox.Show(" güncelleme işlemi başarılı oldu", 
"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 baglanti.Close();
 }
 private void button5_Click(object sender, EventArgs e)
 {
 baglanti.Open();
 string sorgu = "select * from public.\"urun\" 
where \"urunadi\" LIKE '%" + textBox1.Text + "%'";
 NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, 
baglanti);
 DataSet ds = new DataSet();
 da.Fill(ds);
 dataGridView1.DataSource = ds.Tables[0];
 baglanti.Close();
 }
 private void Form1_Load(object sender, EventArgs e)
 {
 }
 private void textcevirmenid_TextChanged(object sender, 
EventArgs e)
 {
 }
 
 private void textBox2_TextChanged_1(object sender, EventArgs e)
 {
 
 }
 private void textBox1_TextChanged_3(object sender, EventArgs e)
 {
 
 }
 private void textyazarid_TextChanged(object sender, EventArgs 
e)
 {
 }
 private void textmagazaid_TextChanged(object sender, EventArgs 
e)
 {
 }
 private void textsayfasayisiid_TextChanged(object sender, 
EventArgs e)
 {
 }
 private void textbasimyiliid_TextChanged(object sender, 
EventArgs e)
 {
 }
 private void texturunsiparisid_TextChanged(object sender, 
EventArgs e)
 {
 }
 private void textkategoriid_TextChanged(object sender, 
EventArgs e)
 {
 }
 private void textyayineviid_TextChanged(object sender, 
EventArgs e)
 {
 }
 private void label3_Click(object sender, EventArgs e)
 {
 }
 private void button1_Click_1(object sender, EventArgs e)
 {
 Formsiparis formgecis = new Formsiparis();
 formgecis.ShowDialog();
 
 }
 }
}
