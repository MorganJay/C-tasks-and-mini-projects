namespace VisitorManagementSystem
{
    partial class VisitorMgt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.reasonforvisittextBox = new System.Windows.Forms.TextBox();
            this.phonenumbertextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personofInterestcomboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.visitorLogDataSet = new VisitorManagementSystem.VisitorLogDataSet();
            this.visitorLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitorLogTableAdapter = new VisitorManagementSystem.VisitorLogDataSetTableAdapters.VisitorLogTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personofInterestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonforVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateandTimeofVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorLogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "VISITOR MANAGEMENT SYSTEM";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "VISITOR NAME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "PHONE NUMBER :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "PERSON OF INTEREST :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "EMAIL ADDRESS :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "REASON FOR VISIT :";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(260, 184);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(281, 33);
            this.nametextBox.TabIndex = 2;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(260, 125);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(281, 33);
            this.emailtextBox.TabIndex = 4;
            // 
            // reasonforvisittextBox
            // 
            this.reasonforvisittextBox.Location = new System.Drawing.Point(260, 308);
            this.reasonforvisittextBox.Name = "reasonforvisittextBox";
            this.reasonforvisittextBox.Size = new System.Drawing.Size(281, 33);
            this.reasonforvisittextBox.TabIndex = 5;
            // 
            // phonenumbertextBox
            // 
            this.phonenumbertextBox.Location = new System.Drawing.Point(260, 248);
            this.phonenumbertextBox.MaxLength = 15;
            this.phonenumbertextBox.Name = "phonenumbertextBox";
            this.phonenumbertextBox.Size = new System.Drawing.Size(281, 33);
            this.phonenumbertextBox.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "ddMMMM, yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 367);
            this.dateTimePicker1.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 33);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2017, 8, 24, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.personofInterestDataGridViewTextBoxColumn,
            this.reasonforVisitDataGridViewTextBoxColumn,
            this.visitorNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.dateandTimeofVisitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.visitorLogBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 242);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // personofInterestcomboBox
            // 
            this.personofInterestcomboBox.FormattingEnabled = true;
            this.personofInterestcomboBox.Items.AddRange(new object[] {
            "John",
            "Gabriel",
            "Ayo",
            "Emmanuel",
            "Josiah",
            "Paul"});
            this.personofInterestcomboBox.Location = new System.Drawing.Point(260, 69);
            this.personofInterestcomboBox.Name = "personofInterestcomboBox";
            this.personofInterestcomboBox.Size = new System.Drawing.Size(166, 33);
            this.personofInterestcomboBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(815, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(645, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "SAVE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // visitorLogDataSet
            // 
            this.visitorLogDataSet.DataSetName = "VisitorLogDataSet";
            this.visitorLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitorLogBindingSource
            // 
            this.visitorLogBindingSource.DataMember = "VisitorLog";
            this.visitorLogBindingSource.DataSource = this.visitorLogDataSet;
            // 
            // visitorLogTableAdapter
            // 
            this.visitorLogTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "DATE OF VISIT:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(645, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 42);
            this.button3.TabIndex = 13;
            this.button3.Text = "VIEW";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "S/N";
            this.idDataGridViewTextBoxColumn.MaxInputLength = 19787;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // personofInterestDataGridViewTextBoxColumn
            // 
            this.personofInterestDataGridViewTextBoxColumn.DataPropertyName = "PersonofInterest";
            this.personofInterestDataGridViewTextBoxColumn.HeaderText = "Person of Interest";
            this.personofInterestDataGridViewTextBoxColumn.Name = "personofInterestDataGridViewTextBoxColumn";
            this.personofInterestDataGridViewTextBoxColumn.ReadOnly = true;
            this.personofInterestDataGridViewTextBoxColumn.Width = 200;
            // 
            // reasonforVisitDataGridViewTextBoxColumn
            // 
            this.reasonforVisitDataGridViewTextBoxColumn.DataPropertyName = "ReasonforVisit";
            this.reasonforVisitDataGridViewTextBoxColumn.HeaderText = "Reason for Visit";
            this.reasonforVisitDataGridViewTextBoxColumn.Name = "reasonforVisitDataGridViewTextBoxColumn";
            this.reasonforVisitDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonforVisitDataGridViewTextBoxColumn.Width = 200;
            // 
            // visitorNameDataGridViewTextBoxColumn
            // 
            this.visitorNameDataGridViewTextBoxColumn.DataPropertyName = "VisitorName";
            this.visitorNameDataGridViewTextBoxColumn.HeaderText = "Visitor Name";
            this.visitorNameDataGridViewTextBoxColumn.Name = "visitorNameDataGridViewTextBoxColumn";
            this.visitorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.visitorNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.MaxInputLength = 15;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateandTimeofVisitDataGridViewTextBoxColumn
            // 
            this.dateandTimeofVisitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateandTimeofVisitDataGridViewTextBoxColumn.DataPropertyName = "DateandTimeofVisit";
            this.dateandTimeofVisitDataGridViewTextBoxColumn.HeaderText = "Date of Visit";
            this.dateandTimeofVisitDataGridViewTextBoxColumn.Name = "dateandTimeofVisitDataGridViewTextBoxColumn";
            this.dateandTimeofVisitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(645, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 42);
            this.button4.TabIndex = 14;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "S/N";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Info;
            this.textBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(125, 29);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(62, 30);
            this.textBox.TabIndex = 16;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VisitorMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1273, 675);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personofInterestcomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.phonenumbertextBox);
            this.Controls.Add(this.reasonforvisittextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "VisitorMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISITOR MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorLogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox reasonforvisittextBox;
        private System.Windows.Forms.TextBox phonenumbertextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox personofInterestcomboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private VisitorLogDataSet visitorLogDataSet;
        private System.Windows.Forms.BindingSource visitorLogBindingSource;
        private VisitorLogDataSetTableAdapters.VisitorLogTableAdapter visitorLogTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personofInterestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonforVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateandTimeofVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox;
    }
}

