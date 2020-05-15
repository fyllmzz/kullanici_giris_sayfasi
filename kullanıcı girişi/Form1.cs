using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanıcı_girişi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string kad, sifre;
			kad = textBox1.Text;
			sifre = textBox2.Text;
			if (kad=="admin"&&sifre=="123456")
			{
				MessageBox.Show("Giriş Başarılı...");
				Form2 fr2 = new Form2();
				fr2.Show();

			}
			else
			{
				MessageBox.Show("Kullanıcı adı veye şifre yanlış");
			}
		}
	}
}
