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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
            ShowManager();
        }

        private void listViewManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewManager.SelectedItems.Count == 1)
            {
                Manager mngset = listViewManager.SelectedItems[0].Tag as Manager;
                textBoxFirstName.Text = mngset.FirstName;
                textBoxMiddleName.Text = mngset.MiddleName;
                textBoxLastName.Text = mngset.LastName;
                textBoxEmail.Text = mngset.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Manager mngset = new Manager();
            mngset.FirstName = textBoxFirstName.Text;
            mngset.MiddleName = textBoxMiddleName.Text;
            mngset.LastName = textBoxLastName.Text;
            mngset.Email = textBoxEmail.Text;
            Program.exdb.Manager.Add(mngset);
            Program.exdb.SaveChanges();
            ShowManager();
        }
        void ShowManager()
        {
            listViewManager.Items.Clear();
            foreach (Manager mngset in Program.exdb.Manager)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    mngset.Id.ToString(), mngset.FirstName, mngset.MiddleName, mngset.LastName, mngset.Email,
                });
                item.Tag = mngset;
                listViewManager.Items.Add(item);
            }
            listViewManager.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewManager.SelectedItems.Count == 1)
            {
                Manager mngset = listViewManager.SelectedItems[0].Tag as Manager;
                mngset.FirstName = textBoxFirstName.Text;
                mngset.MiddleName = textBoxMiddleName.Text;
                mngset.LastName = textBoxLastName.Text;
                mngset.Email = textBoxEmail.Text;
                Program.exdb.SaveChanges();
                ShowManager();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewManager.SelectedItems.Count == 1)
                {
                    Manager mngset = listViewManager.SelectedItems[0].Tag as Manager;
                    Program.exdb.Manager.Remove(mngset);
                    Program.exdb.SaveChanges();
                    ShowManager();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
