using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = textBox1.Text;
            listView1.Items.Add(item);
            ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(item, textBox2.Text);
            item.SubItems.Add(subItem2);
            ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem(item, textBox3.Text);
            item.SubItems.Add(subItem3);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult x = MessageBox.Show("Ban co muon xoa", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (x == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    selectedItem.Text = textBox1.Text;
                }
                if (!string.IsNullOrWhiteSpace(textBox2.Text) && selectedItem.SubItems.Count > 1)
                {
                    selectedItem.SubItems[1].Text = textBox2.Text;
                }
                if (!string.IsNullOrWhiteSpace(textBox3.Text) && selectedItem.SubItems.Count > 2)
                {
                    selectedItem.SubItems[2].Text = textBox3.Text;
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
