using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class FormYurLica : Form
    {
        public FormYurLica()
        {
            InitializeComponent();
            ShowManager();
            ShowYurLica();
        }

        private void listViewYurLica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewYurLica.SelectedItems.Count == 1)
            {
                YurLica ylset = listViewYurLica.SelectedItems[0].Tag as YurLica;
                textBoxSokrNaim.Text = ylset.SokrNaim;
                textBoxAddress.Text = ylset.Addres;
                textBoxEmail.Text = ylset.Email;
                textBoxInn.Text = ylset.Inn;
                comboBoxManager.SelectedIndex = comboBoxManager.FindString(ylset.IdManager.ToString());
            }
            else
            {
                textBoxSokrNaim.Text = "";
                textBoxAddress.Text = "";
                textBoxEmail.Text = "";
                comboBoxManager.SelectedItem = null;
                textBoxInn.Text = "";
            }
        }
        void ShowManager()
        {
            comboBoxManager.Items.Clear();
            foreach (Manager mngset in Program.exdb.Manager)
            {
                string[] item = { mngset.Id.ToString() + ".", mngset.FirstName, mngset.MiddleName, mngset.LastName };
                comboBoxManager.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxManager.SelectedItem != null && textBoxSokrNaim.Text != "" &&  textBoxEmail.Text != ""
                && textBoxAddress.Text != "" && textBoxInn.Text != "")
            {
                YurLica ylset = new YurLica();
                ylset.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                ylset.SokrNaim = (textBoxSokrNaim.Text);
                ylset.Addres = textBoxAddress.Text;
                ylset.Email = textBoxEmail.Text;
                ylset.Inn = textBoxInn.Text;
                ylset.Id.ToString();
                Program.exdb.YurLica.Add(ylset);
                Program.exdb.SaveChanges();
                ShowYurLica();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowYurLica()
        {
            listViewYurLica.Items.Clear();
            foreach (YurLica ylset in Program.exdb.YurLica)
            {
                ListViewItem item = new ListViewItem(new string[]
                {

                    ylset.Id.ToString(),
                    ylset.SokrNaim,
                    ylset.Addres,
                    ylset.Email,
                    ylset.IdManager.ToString(),
                    ylset.Inn
                }); ;
                item.Tag = ylset;
                listViewYurLica.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewYurLica.SelectedItems.Count == 1)
            {
                YurLica ylset = listViewYurLica.SelectedItems[0].Tag as YurLica;

                ylset.SokrNaim = textBoxSokrNaim.Text;
                ylset.Email = textBoxEmail.Text;
                ylset.Addres = textBoxAddress.Text;
                ylset.Inn = textBoxInn.Text;
                ylset.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                Program.exdb.SaveChanges();
                ShowYurLica();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewYurLica.SelectedItems.Count == 1)
                {
                    YurLica ylset = listViewYurLica.SelectedItems[0].Tag as YurLica;
                    Program.exdb.YurLica.Remove(ylset);
                    Program.exdb.SaveChanges();
                    ShowYurLica();
                }

                comboBoxManager.SelectedItem = null;
                textBoxSokrNaim.Text = "";
                textBoxAddress.Text = "";
                textBoxEmail.Text = "";
                textBoxInn.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
