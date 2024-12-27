namespace Tyuiu.NedelkinFA.Sprint7.Project.V13
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCountries = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapitalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDevelopedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PopulationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.chkIsDeveloped = new System.Windows.Forms.CheckBox();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCountries
            // 
            this.dgvCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.CapitalColumn,
            this.AreaColumn,
            this.IsDevelopedColumn,
            this.PopulationColumn,
            this.NationalityColumn,
            this.NotesColumn});
            this.dgvCountries.Location = new System.Drawing.Point(12, 12);
            this.dgvCountries.Name = "dgvCountries";
            this.dgvCountries.Size = new System.Drawing.Size(776, 200);
            this.dgvCountries.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.Name = "NameColumn";
            // 
            // CapitalColumn
            // 
            this.CapitalColumn.HeaderText = "Столица";
            this.CapitalColumn.Name = "CapitalColumn";
            // 
            // AreaColumn
            // 
            this.AreaColumn.HeaderText = "Площадь";
            this.AreaColumn.Name = "AreaColumn";
            // 
            // IsDevelopedColumn
            // 
            this.IsDevelopedColumn.HeaderText = "Развита ли страна";
            this.IsDevelopedColumn.Name = "IsDevelopedColumn";
            // 
            // PopulationColumn
            // 
            this.PopulationColumn.HeaderText = "Население";
            this.PopulationColumn.Name = "PopulationColumn";
            // 
            // NationalityColumn
            // 
            this.NationalityColumn.HeaderText = "Преобладающая нация";
            this.NationalityColumn.Name = "NationalityColumn";
            // 
            // NotesColumn
            // 
            this.NotesColumn.HeaderText = "Примечания";
            this.NotesColumn.Name = "NotesColumn";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 230);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(95, 256);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(150, 20);
            this.txtCapital.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(95, 282);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(150, 20);
            this.txtArea.TabIndex = 3;
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(95, 308);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(150, 20);
            this.txtPopulation.TabIndex = 4;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(95, 334);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(150, 20);
            this.txtNationality.TabIndex = 5;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(95, 360);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(150, 20);
            this.txtNotes.TabIndex = 6;
            // 
            // chkIsDeveloped
            // 
            this.chkIsDeveloped.AutoSize = true;
            this.chkIsDeveloped.Location = new System.Drawing.Point(95, 386);
            this.chkIsDeveloped.Name = "chkIsDeveloped";
            this.chkIsDeveloped.Size = new System.Drawing.Size(106, 17);
            this.chkIsDeveloped.TabIndex = 7;
            this.chkIsDeveloped.Text = "Развита страна";
            this.chkIsDeveloped.UseVisualStyleBackColor = true;
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Location = new System.Drawing.Point(12, 417);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(75, 23);
            this.btnAddCountry.TabIndex = 8;
            this.btnAddCountry.Text = "Добавить";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(93, 417);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveData.TabIndex = 9;
            this.btnSaveData.Text = "Сохранить";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(174, 417);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 10;
            this.btnLoadData.Text = "Загрузить";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.Location = new System.Drawing.Point(255, 417);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCountry.TabIndex = 11;
            this.btnDeleteCountry.Text = "Удалить";
            this.btnDeleteCountry.UseVisualStyleBackColor = true;
            this.btnDeleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Столица:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Площадь:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Население:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Нация:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Примечания:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Развита ли?";

            // 
            // FormMain
            // 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteCountry);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.chkIsDeveloped);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtPopulation);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvCountries);
            this.Name = "FormMain";
            this.Text = "Географический справочник";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCountries;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapitalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDevelopedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopulationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesColumn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.CheckBox chkIsDeveloped;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnDeleteCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
