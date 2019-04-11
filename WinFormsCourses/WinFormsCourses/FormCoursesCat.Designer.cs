namespace WinFormsCourses
{
    partial class FormCoursesCat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSaveCoursesCat = new System.Windows.Forms.Button();
            this.buttonDeleteCoursesCat = new System.Windows.Forms.Button();
            this.buttonSearchCoursesCat = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelUniversity = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveCoursesCat
            // 
            this.buttonSaveCoursesCat.Location = new System.Drawing.Point(7, 6);
            this.buttonSaveCoursesCat.Name = "buttonSaveCoursesCat";
            this.buttonSaveCoursesCat.Size = new System.Drawing.Size(110, 48);
            this.buttonSaveCoursesCat.TabIndex = 0;
            this.buttonSaveCoursesCat.Text = "Зберегти";
            this.buttonSaveCoursesCat.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCoursesCat
            // 
            this.buttonDeleteCoursesCat.Location = new System.Drawing.Point(123, 6);
            this.buttonDeleteCoursesCat.Name = "buttonDeleteCoursesCat";
            this.buttonDeleteCoursesCat.Size = new System.Drawing.Size(110, 48);
            this.buttonDeleteCoursesCat.TabIndex = 1;
            this.buttonDeleteCoursesCat.Text = "Видалити";
            this.buttonDeleteCoursesCat.UseVisualStyleBackColor = true;
            // 
            // buttonSearchCoursesCat
            // 
            this.buttonSearchCoursesCat.Location = new System.Drawing.Point(239, 6);
            this.buttonSearchCoursesCat.Name = "buttonSearchCoursesCat";
            this.buttonSearchCoursesCat.Size = new System.Drawing.Size(110, 48);
            this.buttonSearchCoursesCat.TabIndex = 2;
            this.buttonSearchCoursesCat.Text = "Пошук";
            this.buttonSearchCoursesCat.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBox5);
            this.groupBoxSearch.Controls.Add(this.textBox4);
            this.groupBoxSearch.Controls.Add(this.textBox3);
            this.groupBoxSearch.Controls.Add(this.textBox2);
            this.groupBoxSearch.Controls.Add(this.textBox1);
            this.groupBoxSearch.Controls.Add(this.labelAuthor);
            this.groupBoxSearch.Controls.Add(this.labelCategory);
            this.groupBoxSearch.Controls.Add(this.labelUniversity);
            this.groupBoxSearch.Controls.Add(this.labelDescription);
            this.groupBoxSearch.Controls.Add(this.labelTitle);
            this.groupBoxSearch.Location = new System.Drawing.Point(7, 60);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(781, 181);
            this.groupBoxSearch.TabIndex = 3;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Параметри пошуку";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(5, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(56, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Назва";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(5, 60);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(97, 20);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Інформація";
            // 
            // labelUniversity
            // 
            this.labelUniversity.AutoSize = true;
            this.labelUniversity.Location = new System.Drawing.Point(5, 89);
            this.labelUniversity.Name = "labelUniversity";
            this.labelUniversity.Size = new System.Drawing.Size(102, 20);
            this.labelUniversity.TabIndex = 2;
            this.labelUniversity.Text = "Університет";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(5, 119);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(83, 20);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Категорія";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(5, 148);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(56, 20);
            this.labelAuthor.TabIndex = 4;
            this.labelAuthor.Text = "Автор";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 26);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 26);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(263, 26);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(158, 142);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(263, 26);
            this.textBox5.TabIndex = 9;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(7, 247);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowTemplate.Height = 28;
            this.dataGridViewSearch.Size = new System.Drawing.Size(781, 365);
            this.dataGridViewSearch.TabIndex = 4;
            // 
            // FormCoursesCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonSearchCoursesCat);
            this.Controls.Add(this.buttonDeleteCoursesCat);
            this.Controls.Add(this.buttonSaveCoursesCat);
            this.Name = "FormCoursesCat";
            this.Text = "Курси за категорією";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveCoursesCat;
        private System.Windows.Forms.Button buttonDeleteCoursesCat;
        private System.Windows.Forms.Button buttonSearchCoursesCat;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelUniversity;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
    }
}