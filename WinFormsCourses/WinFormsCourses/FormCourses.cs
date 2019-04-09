using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCourses
{
    public partial class FormCourses : Form
    {
        public FormCourses()
        {
            InitializeComponent();
        }

        private void FormCourses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSCourses.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.dSCourses.Authors);
            // TODO: This line of code loads data into the 'dSCourses.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.dSCourses.Categories);
            // TODO: This line of code loads data into the 'dSCourses.Universities' table. You can move, or remove it, as needed.
            this.universitiesTableAdapter.Fill(this.dSCourses.Universities);

        }

        private void buttonUniversities_Click(object sender, EventArgs e)
        {
            this.universitiesTableAdapter.Update(this.dSCourses.Universities);
        }

        private void buttonUniversitiesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewUniversities.CurrentRow.Cells["uN_IDDataGridViewTextBoxColumn"].Value;

                global::System.Nullable<int> un_count = queriesTableAdapter1.SQCountUN_IDinCourses(id);

                if (un_count == 0)
                {
                    this.universitiesBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Неможливо видалити! До університету прив'язані курси!", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації про університет", "Видалення інформації про університет");
            }
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.Update(this.dSCourses.Categories);
        }

        private void buttonCategoriesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewCategories.CurrentRow.Cells["cA_IDDataGridViewTextBoxColumn"].Value;

                global::System.Nullable<int> ca_count = queriesTableAdapter1.SQCountCA_IDinCourses(id);

                if (ca_count == 0)
                {
                    this.categoriesBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Неможливо видалити! До категорії прив'язані курси!", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації про категорію", "Видалення інформації про категорію");
            }
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            this.authorsTableAdapter.Update(this.dSCourses.Authors);
        }

        private void buttonAuthorsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewAuthors.CurrentRow.Cells["aU_IDDataGridViewTextBoxColumn"].Value;

                global::System.Nullable<int> au_count = queriesTableAdapter1.SQCountAU_IDinCourses(id);

                if (au_count == 0)
                {
                    this.authorsBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Неможливо видалити! До автора прив'язані курси!", "Помилка видалення");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації про автора", "Видалення інформації про автора");
            }
        }
    }
}
