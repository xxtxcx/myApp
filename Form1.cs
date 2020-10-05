using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PairsName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }






        private void BtnNum_Click(object sender, EventArgs e)
        {
            try
            {

             int number = Convert.ToInt16(txtNum.Text);
            if (number % 2 == 0)
            {
                ListOkcs.Number = number;
                label3.Text = txtNum.Text;
            }
            else
            {
                MessageBox.Show("Введите четное число", "Внимание", MessageBoxButtons.OK);
            }
            
                
                ListOkcs.Number = Convert.ToInt16(txtNum.Text);

                label3.Text = txtNum.Text;
                txtNum.Clear();
                listBox2.Items.Clear();
                listBox1.Items.Clear();
            }
            catch 
            {
                MessageBox.Show("Введите цифру", "Внимание", MessageBoxButtons.OK);
                txtNum.Clear();
            }
            

           

        }

        private void BtnNms_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= ListOkcs.Number)
            {
                MessageBox.Show("Список заполнен", "Внимание", MessageBoxButtons.OK);
                txtNms.Clear();
            }
            else
            {
                listBox1.Items.Add($"{txtNms.Text}");
                txtNms.Clear();
                
            }
        }

        private void BtnSfl_Click(object sender, EventArgs e)
        {
            try
            {
                var rnd = new Random();
                for (int i = ListOkcs.Number - 1; i >= 1; i--)
                {
                    int j = rnd.Next(i + 1);

                    var temp = listBox1.Items[j];
                    listBox1.Items[j] = listBox1.Items[i];
                    listBox1.Items[i] = temp;

                }
            }
            catch
            {
                MessageBox.Show("Список заполнен не до конца", "Внимание", MessageBoxButtons.OK);
            }
        }

        private void BtnUn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ListOkcs.Number / 2; i++)
                {
                    listBox2.Items.Add($"{listBox2.Items.Count + 1}.{listBox1.Items[i]} & {listBox1.Items[i + ListOkcs.Number / 2]} ");

                }
            }
            catch
            {
                MessageBox.Show("Список заполнен не до конца", "Внимание", MessageBoxButtons.OK);
            }
              

            

        }

        void TxtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                BtnNum_Click(btnNum, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        void TxtNms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                BtnNms_Click(btnNms, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnClrN_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void BtnClrL_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }


    }
}
