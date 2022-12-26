using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BDLoad();
            LoadManufacture();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void BDLoad()
        {
            dataGridView1.Rows.Clear();
            using (EXAM11Entities db = new EXAM11Entities())
            {
                var DataTovar = db.TOVARS;
                label1.Text = DataTovar.Count().ToString();
                label3.Text = DataTovar.Count().ToString();
                foreach(var tovar in DataTovar)
                {
                    DataGridViewImageColumn img = new DataGridViewImageColumn();
                    try
                    {
                        Image image = new Bitmap($"../../Images/{tovar.IMAGENAME}");
                        img.Image = image;
                    }
                    catch
                    {
                        Image image = new Bitmap($"../../Images/picture.png");
                        img.Image = image;
                    }
                    dataGridView1.Rows.Add(tovar.IDTOVARS, img.Image,db.NAMETOVAR.Where(n => n.IDNAMETOVAR == tovar.IDNAMETOVAR).FirstOrDefault().NAMETOVAR1,tovar.DESCRIPTIONS, db.MANUFACTURE.Where(n => n.IDMANUFACTURE == tovar.IDMANUFACTURE).FirstOrDefault().NAMEMANUFACTURE, tovar.PRICE,tovar.AMOUNTSTORE);
                    if(tovar.AMOUNTSTORE <= 0) { dataGridView1.Rows[dataGridView1.Rows.Count-1].DefaultCellStyle.BackColor = Color.Gray; }
                }
            }
        }

        private void LoadManufacture()
        {
            using (EXAM11Entities db = new EXAM11Entities())
            {
                var DataManufacture = db.MANUFACTURE;
                foreach(var manufacture in DataManufacture)
                {
                    comboBox2.Items.Add(manufacture.NAMEMANUFACTURE);
                }
            }
        }

        private void SearchLoad()
        {
            dataGridView1.Rows.Clear();
            using (EXAM11Entities db = new EXAM11Entities())
            {
                if ((comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && comboBox2.SelectedIndex != -1) || (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)) 
                {
                    var DataTovar = db.VIEWSEARCH(textBox1.Text); 
                    foreach (var tovar in DataTovar)
                    {
                        DataGridViewImageColumn img = new DataGridViewImageColumn();
                        try
                        {
                            Image image = new Bitmap($"../../Images/{tovar.IMAGENAME}");
                            img.Image = image;
                        }
                        catch
                        {
                            Image image = new Bitmap($"../../Images/picture.png");
                            img.Image = image;
                        }
                        dataGridView1.Rows.Add(tovar.IDTOVARS, img.Image, tovar.NAMETOVAR, tovar.DESCRIPTIONS, tovar.NAMEMANUFACTURE, tovar.PRICE, tovar.AMOUNTSTORE);
                        if (tovar.AMOUNTSTORE <= 0) { dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gray; }
                    }
                    label1.Text = DataTovar.Count().ToString();
                }
                if ((comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0 && comboBox2.SelectedIndex != -1) || (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == -1))
                {
                    var DataTovar = db.VIEWSEARCH(textBox1.Text).OrderByDescending(t => t.PRICE);
                    foreach (var tovar in DataTovar)
                    {
                        DataGridViewImageColumn img = new DataGridViewImageColumn();
                        try
                        {
                            Image image = new Bitmap($"../../Images/{tovar.IMAGENAME}");
                            img.Image = image;
                        }
                        catch
                        {
                            Image image = new Bitmap($"../../Images/picture.png");
                            img.Image = image;
                        }
                        dataGridView1.Rows.Add(tovar.IDTOVARS, img.Image, tovar.NAMETOVAR, tovar.DESCRIPTIONS, tovar.NAMEMANUFACTURE, tovar.PRICE, tovar.AMOUNTSTORE);
                        if (tovar.AMOUNTSTORE <= 0) { dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gray; }
                    }
                    label1.Text = DataTovar.Count().ToString();
                }
                if ((comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0 && comboBox2.SelectedIndex != -1) || (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == -1))
                {
                    var DataTovar = db.VIEWSEARCH(textBox1.Text).OrderBy(t => t.PRICE);
                    foreach (var tovar in DataTovar)
                    {
                        DataGridViewImageColumn img = new DataGridViewImageColumn();
                        try
                        {
                            Image image = new Bitmap($"../../Images/{tovar.IMAGENAME}");
                            img.Image = image;
                        }
                        catch
                        {
                            Image image = new Bitmap($"../../Images/picture.png");
                            img.Image = image;
                        }
                        dataGridView1.Rows.Add(tovar.IDTOVARS, img.Image, tovar.NAMETOVAR, tovar.DESCRIPTIONS, tovar.NAMEMANUFACTURE, tovar.PRICE, tovar.AMOUNTSTORE);
                        if (tovar.AMOUNTSTORE <= 0) { dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gray; }
                    }
                    label1.Text = DataTovar.Count().ToString();
                }
                if ((comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex != 0 && comboBox2.SelectedIndex != -1) || (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex != 0 && comboBox2.SelectedIndex != -1))
                {
                    var DataTovar = db.VIEWSEARCH(textBox1.Text).Where(t => t.NAMEMANUFACTURE == comboBox2.SelectedItem.ToString());
                    foreach (var tovar in DataTovar)
                    {
                        DataGridViewImageColumn img = new DataGridViewImageColumn();
                        try
                        {
                            Image image = new Bitmap($"../../Images/{tovar.IMAGENAME}");
                            img.Image = image;
                        }
                        catch
                        {
                            Image image = new Bitmap($"../../Images/picture.png");
                            img.Image = image;
                        }
                        dataGridView1.Rows.Add(tovar.IDTOVARS, img.Image, tovar.NAMETOVAR, tovar.DESCRIPTIONS, tovar.NAMEMANUFACTURE, tovar.PRICE, tovar.AMOUNTSTORE);
                        if (tovar.AMOUNTSTORE <= 0) { dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gray; }
                    }
                    label1.Text = DataTovar.Count().ToString();
                }
                if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex != 0 && comboBox2.SelectedIndex != -1)
                {
                    var DataTovar = db.VIEWSEARCH(textBox1.Text).OrderByDescending(t => t.PRICE).Where(t => t.NAMEMANUFACTURE == comboBox2.SelectedItem.ToString());
                    foreach (var tovar in DataTovar)
                    {
                        DataGridViewImageColumn img = new DataGridViewImageColumn();
                        try
                        {
                            Image image = new Bitmap($"../../Images/{tovar.IMAGENAME}");
                            img.Image = image;
                        }
                        catch
                        {
                            Image image = new Bitmap($"../../Images/picture.png");
                            img.Image = image;
                        }
                        dataGridView1.Rows.Add(tovar.IDTOVARS, img.Image, tovar.NAMETOVAR, tovar.DESCRIPTIONS, tovar.NAMEMANUFACTURE, tovar.PRICE, tovar.AMOUNTSTORE);
                        if (tovar.AMOUNTSTORE <= 0) { dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gray; }
                    }
                    label1.Text = DataTovar.Count().ToString();
                }
                if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex != 0 && comboBox2.SelectedIndex != -1)
                {
                    var DataTovar = db.VIEWSEARCH(textBox1.Text).OrderBy(t => t.PRICE).Where(t => t.NAMEMANUFACTURE == comboBox2.SelectedItem.ToString());
                    foreach (var tovar in DataTovar)
                    {
                        DataGridViewImageColumn img = new DataGridViewImageColumn();
                        try
                        {
                            Image image = new Bitmap($"../../Images/{tovar.IMAGENAME}");
                            img.Image = image;
                        }
                        catch
                        {
                            Image image = new Bitmap($"../../Images/picture.png");
                            img.Image = image;
                        }
                        dataGridView1.Rows.Add(tovar.IDTOVARS, img.Image, tovar.NAMETOVAR, tovar.DESCRIPTIONS, tovar.NAMEMANUFACTURE, tovar.PRICE, tovar.AMOUNTSTORE);
                        if (tovar.AMOUNTSTORE <= 0) { dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gray; }
                    }
                    label1.Text = DataTovar.Count().ToString();
                }
            }
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchLoad();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchLoad();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchLoad();
        }
    }
}
