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
            this.universitiesBindingSource.RemoveCurrent();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.Update(this.dSCourses.Categories);
        }

        private void buttonCategoriesDelete_Click(object sender, EventArgs e)
        {
            this.categoriesBindingSource.RemoveCurrent();
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            this.authorsTableAdapter.Update(this.dSCourses.Authors);
        }

        private void buttonAuthorsDelete_Click(object sender, EventArgs e)
        {
            this.authorsBindingSource.RemoveCurrent();
        }
    }
}
