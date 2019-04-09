namespace WinFormsCourses
{
    partial class FormCourses
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
            this.components = new System.ComponentModel.Container();
            this.tabControlCourses = new System.Windows.Forms.TabControl();
            this.tabPageUniversities = new System.Windows.Forms.TabPage();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.tabPageAuthors = new System.Windows.Forms.TabPage();
            this.dataGridViewUniversities = new System.Windows.Forms.DataGridView();
            this.buttonUniversities = new System.Windows.Forms.Button();
            this.buttonUniversitiesDelete = new System.Windows.Forms.Button();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonCategoriesDelete = new System.Windows.Forms.Button();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.buttonAuthors = new System.Windows.Forms.Button();
            this.buttonAuthorsDelete = new System.Windows.Forms.Button();
            this.uN_IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cA_IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCourses = new CoursesData.DSCourses();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universitiesTableAdapter = new CoursesData.DSCoursesTableAdapters.UniversitiesTableAdapter();
            this.categoriesTableAdapter = new CoursesData.DSCoursesTableAdapters.CategoriesTableAdapter();
            this.authorsTableAdapter = new CoursesData.DSCoursesTableAdapters.AuthorsTableAdapter();
            this.queriesTableAdapter1 = new CoursesData.DSCoursesTableAdapters.QueriesTableAdapter();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aU_IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlCourses.SuspendLayout();
            this.tabPageUniversities.SuspendLayout();
            this.tabPageCategories.SuspendLayout();
            this.tabPageAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCourses
            // 
            this.tabControlCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCourses.Controls.Add(this.tabPageUniversities);
            this.tabControlCourses.Controls.Add(this.tabPageCategories);
            this.tabControlCourses.Controls.Add(this.tabPageAuthors);
            this.tabControlCourses.Location = new System.Drawing.Point(12, 12);
            this.tabControlCourses.Name = "tabControlCourses";
            this.tabControlCourses.SelectedIndex = 0;
            this.tabControlCourses.Size = new System.Drawing.Size(776, 426);
            this.tabControlCourses.TabIndex = 0;
            // 
            // tabPageUniversities
            // 
            this.tabPageUniversities.Controls.Add(this.buttonUniversitiesDelete);
            this.tabPageUniversities.Controls.Add(this.buttonUniversities);
            this.tabPageUniversities.Controls.Add(this.dataGridViewUniversities);
            this.tabPageUniversities.Location = new System.Drawing.Point(4, 29);
            this.tabPageUniversities.Name = "tabPageUniversities";
            this.tabPageUniversities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUniversities.Size = new System.Drawing.Size(768, 393);
            this.tabPageUniversities.TabIndex = 0;
            this.tabPageUniversities.Text = "Університети";
            this.tabPageUniversities.UseVisualStyleBackColor = true;
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Controls.Add(this.buttonCategoriesDelete);
            this.tabPageCategories.Controls.Add(this.buttonCategories);
            this.tabPageCategories.Controls.Add(this.dataGridViewCategories);
            this.tabPageCategories.Location = new System.Drawing.Point(4, 29);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategories.Size = new System.Drawing.Size(768, 393);
            this.tabPageCategories.TabIndex = 1;
            this.tabPageCategories.Text = "Категорії";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // tabPageAuthors
            // 
            this.tabPageAuthors.Controls.Add(this.buttonAuthorsDelete);
            this.tabPageAuthors.Controls.Add(this.buttonAuthors);
            this.tabPageAuthors.Controls.Add(this.dataGridViewAuthors);
            this.tabPageAuthors.Location = new System.Drawing.Point(4, 29);
            this.tabPageAuthors.Name = "tabPageAuthors";
            this.tabPageAuthors.Size = new System.Drawing.Size(768, 393);
            this.tabPageAuthors.TabIndex = 2;
            this.tabPageAuthors.Text = "Автори";
            this.tabPageAuthors.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUniversities
            // 
            this.dataGridViewUniversities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUniversities.AutoGenerateColumns = false;
            this.dataGridViewUniversities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUniversities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.uN_IDDataGridViewTextBoxColumn,
            this.informationDataGridViewTextBoxColumn});
            this.dataGridViewUniversities.DataSource = this.universitiesBindingSource;
            this.dataGridViewUniversities.Location = new System.Drawing.Point(6, 60);
            this.dataGridViewUniversities.Name = "dataGridViewUniversities";
            this.dataGridViewUniversities.RowTemplate.Height = 28;
            this.dataGridViewUniversities.Size = new System.Drawing.Size(756, 327);
            this.dataGridViewUniversities.TabIndex = 0;
            // 
            // buttonUniversities
            // 
            this.buttonUniversities.Location = new System.Drawing.Point(7, 6);
            this.buttonUniversities.Name = "buttonUniversities";
            this.buttonUniversities.Size = new System.Drawing.Size(110, 48);
            this.buttonUniversities.TabIndex = 1;
            this.buttonUniversities.Text = "Зберегти";
            this.buttonUniversities.UseVisualStyleBackColor = true;
            this.buttonUniversities.Click += new System.EventHandler(this.buttonUniversities_Click);
            // 
            // buttonUniversitiesDelete
            // 
            this.buttonUniversitiesDelete.Location = new System.Drawing.Point(123, 6);
            this.buttonUniversitiesDelete.Name = "buttonUniversitiesDelete";
            this.buttonUniversitiesDelete.Size = new System.Drawing.Size(110, 48);
            this.buttonUniversitiesDelete.TabIndex = 2;
            this.buttonUniversitiesDelete.Text = "Видалити";
            this.buttonUniversitiesDelete.UseVisualStyleBackColor = true;
            this.buttonUniversitiesDelete.Click += new System.EventHandler(this.buttonUniversitiesDelete_Click);
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategories.AutoGenerateColumns = false;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.cA_IDDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn});
            this.dataGridViewCategories.DataSource = this.categoriesBindingSource;
            this.dataGridViewCategories.Location = new System.Drawing.Point(6, 60);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowTemplate.Height = 28;
            this.dataGridViewCategories.Size = new System.Drawing.Size(756, 327);
            this.dataGridViewCategories.TabIndex = 0;
            // 
            // buttonCategories
            // 
            this.buttonCategories.Location = new System.Drawing.Point(7, 6);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(110, 48);
            this.buttonCategories.TabIndex = 1;
            this.buttonCategories.Text = "Зберегти";
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonCategoriesDelete
            // 
            this.buttonCategoriesDelete.Location = new System.Drawing.Point(123, 6);
            this.buttonCategoriesDelete.Name = "buttonCategoriesDelete";
            this.buttonCategoriesDelete.Size = new System.Drawing.Size(110, 48);
            this.buttonCategoriesDelete.TabIndex = 2;
            this.buttonCategoriesDelete.Text = "Видалити";
            this.buttonCategoriesDelete.UseVisualStyleBackColor = true;
            this.buttonCategoriesDelete.Click += new System.EventHandler(this.buttonCategoriesDelete_Click);
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.AutoGenerateColumns = false;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.aU_IDDataGridViewTextBoxColumn});
            this.dataGridViewAuthors.DataSource = this.authorsBindingSource;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(6, 60);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.RowTemplate.Height = 28;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(759, 330);
            this.dataGridViewAuthors.TabIndex = 0;
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Location = new System.Drawing.Point(7, 6);
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.Size = new System.Drawing.Size(110, 48);
            this.buttonAuthors.TabIndex = 1;
            this.buttonAuthors.Text = "Зберегти";
            this.buttonAuthors.UseVisualStyleBackColor = true;
            this.buttonAuthors.Click += new System.EventHandler(this.buttonAuthors_Click);
            // 
            // buttonAuthorsDelete
            // 
            this.buttonAuthorsDelete.Location = new System.Drawing.Point(123, 6);
            this.buttonAuthorsDelete.Name = "buttonAuthorsDelete";
            this.buttonAuthorsDelete.Size = new System.Drawing.Size(110, 48);
            this.buttonAuthorsDelete.TabIndex = 2;
            this.buttonAuthorsDelete.Text = "Видалити";
            this.buttonAuthorsDelete.UseVisualStyleBackColor = true;
            this.buttonAuthorsDelete.Click += new System.EventHandler(this.buttonAuthorsDelete_Click);
            // 
            // uN_IDDataGridViewTextBoxColumn
            // 
            this.uN_IDDataGridViewTextBoxColumn.DataPropertyName = "UN_ID";
            this.uN_IDDataGridViewTextBoxColumn.HeaderText = "Номер універститету";
            this.uN_IDDataGridViewTextBoxColumn.Name = "uN_IDDataGridViewTextBoxColumn";
            this.uN_IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uN_IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cA_IDDataGridViewTextBoxColumn
            // 
            this.cA_IDDataGridViewTextBoxColumn.DataPropertyName = "CA_ID";
            this.cA_IDDataGridViewTextBoxColumn.HeaderText = "Номер категорії";
            this.cA_IDDataGridViewTextBoxColumn.Name = "cA_IDDataGridViewTextBoxColumn";
            this.cA_IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cA_IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // informationDataGridViewTextBoxColumn
            // 
            this.informationDataGridViewTextBoxColumn.DataPropertyName = "Information";
            this.informationDataGridViewTextBoxColumn.HeaderText = "Інформація";
            this.informationDataGridViewTextBoxColumn.Name = "informationDataGridViewTextBoxColumn";
            // 
            // universitiesBindingSource
            // 
            this.universitiesBindingSource.DataMember = "Universities";
            this.universitiesBindingSource.DataSource = this.dSCourses;
            // 
            // dSCourses
            // 
            this.dSCourses.DataSetName = "DSCourses";
            this.dSCourses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Інформація";
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.dSCourses;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.dSCourses;
            // 
            // universitiesTableAdapter
            // 
            this.universitiesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // aU_IDDataGridViewTextBoxColumn
            // 
            this.aU_IDDataGridViewTextBoxColumn.DataPropertyName = "AU_ID";
            this.aU_IDDataGridViewTextBoxColumn.HeaderText = "Номер автора";
            this.aU_IDDataGridViewTextBoxColumn.Name = "aU_IDDataGridViewTextBoxColumn";
            this.aU_IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aU_IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlCourses);
            this.Name = "FormCourses";
            this.Text = "Курси";
            this.Load += new System.EventHandler(this.FormCourses_Load);
            this.tabControlCourses.ResumeLayout(false);
            this.tabPageUniversities.ResumeLayout(false);
            this.tabPageCategories.ResumeLayout(false);
            this.tabPageAuthors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUniversities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCourses;
        private System.Windows.Forms.TabPage tabPageUniversities;
        private System.Windows.Forms.TabPage tabPageCategories;
        private System.Windows.Forms.TabPage tabPageAuthors;
        private System.Windows.Forms.DataGridView dataGridViewUniversities;
        private CoursesData.DSCourses dSCourses;
        private System.Windows.Forms.BindingSource universitiesBindingSource;
        private CoursesData.DSCoursesTableAdapters.UniversitiesTableAdapter universitiesTableAdapter;
        private System.Windows.Forms.Button buttonUniversities;
        private System.Windows.Forms.Button buttonUniversitiesDelete;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private CoursesData.DSCoursesTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Button buttonCategoriesDelete;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private CoursesData.DSCoursesTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.Button buttonAuthorsDelete;
        private System.Windows.Forms.Button buttonAuthors;
        private CoursesData.DSCoursesTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uN_IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cA_IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn aU_IDDataGridViewTextBoxColumn;
    }
}

