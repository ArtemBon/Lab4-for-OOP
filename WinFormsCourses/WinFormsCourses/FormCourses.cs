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
    }
}
