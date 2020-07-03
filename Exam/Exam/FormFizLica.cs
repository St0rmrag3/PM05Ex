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
    public partial class FormFizLica : Form
    { 
        public FormFizLica()
        {
            InitializeComponent();
            ShowManager();
            ShowPol();
            ShowFizLica();
        }

        private void listViewManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFizLica.SelectedItems.Count == 1)
            {
                FizLica flset = listViewFizLica.SelectedItems[0].Tag as FizLica;
                textBoxFirstName.Text = flset.FirstName;
                textBoxMiddleName.Text = flset.MiddleName;
                textBoxLastName.Text = flset.LastName;
                textBoxEmail.Text = flset.Email;
                textBoxInn.Text = flset.Inn;
                comboBoxPol.SelectedIndex = comboBoxPol.FindString(flset.Pol.ToString());
                comboBoxManager.SelectedIndex = comboBoxManager.FindString(flset.IdManager.ToString());
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
                comboBoxPol.SelectedItem = null;
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

        void ShowPol()
        {
            comboBoxPol.Items.Add("Мужской");
            comboBoxPol.Items.Add("Женский");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxManager.SelectedItem != null && textBoxFirstName.Text != "" && comboBoxPol.SelectedItem != null && textBoxEmail.Text != "" 
                && textBoxMiddleName.Text != "" && textBoxLastName.Text != "" && textBoxInn.Text != "")
            {
                FizLica flset = new FizLica();
                flset.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                flset.FirstName = (textBoxFirstName.Text);
                flset.Pol = (comboBoxPol.SelectedItem.ToString());
                flset.MiddleName = textBoxMiddleName.Text;
                flset.LastName = textBoxLastName.Text;
                flset.Email = textBoxEmail.Text;
                flset.Inn = textBoxInn.Text;
                flset.Id.ToString();
                Program.exdb.FizLica.Add(flset);
                Program.exdb.SaveChanges();
                ShowFizLica();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowFizLica()
        {
            listViewFizLica.Items.Clear();
            foreach (FizLica flset in Program.exdb.FizLica)
            {
                ListViewItem item = new ListViewItem(new string[]
                {

                    flset.Id.ToString(),
                    flset.FirstName,
                    flset.MiddleName,
                    flset.LastName,
                    flset.Email,
                    flset.Inn,
                    flset.Pol,
                    flset.IdManager.ToString(),    

                }); ;
                item.Tag = flset;
                listViewFizLica.Items.Add(item);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFizLica.SelectedItems.Count == 1)
                {
                    FizLica flset = listViewFizLica.SelectedItems[0].Tag as FizLica;
                    Program.exdb.FizLica.Remove(flset);
                    Program.exdb.SaveChanges();
                    ShowFizLica();
                }

                comboBoxManager.SelectedItem = null;
                textBoxFirstName.Text = "";
                comboBoxPol.SelectedItem = null;
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
                textBoxInn.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewFizLica.SelectedItems.Count == 1)
            {
                FizLica flset = listViewFizLica.SelectedItems[0].Tag as FizLica;

                flset.FirstName = textBoxFirstName.Text;
                flset.MiddleName = textBoxMiddleName.Text;
                flset.LastName = textBoxLastName.Text;
                flset.Email = textBoxEmail.Text;
                flset.Inn = textBoxInn.Text;
                flset.Pol = comboBoxPol.SelectedItem.ToString();
                flset.IdManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                Program.exdb.SaveChanges();
                ShowFizLica();
            }
        }
    }
}
