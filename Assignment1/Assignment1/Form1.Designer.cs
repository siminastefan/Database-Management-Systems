using System.Windows.Forms;

namespace Assignment1
{
    partial class Form1
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
            this.dataGridViewFaculty = new System.Windows.Forms.DataGridView();
            this.buttonFacultyRecords = new System.Windows.Forms.Button();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.buttonChildRecords = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.textBoxFid = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFaculty
            // 
            this.dataGridViewFaculty.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaculty.Location = new System.Drawing.Point(31, 275);
            this.dataGridViewFaculty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewFaculty.Name = "dataGridViewFaculty";
            this.dataGridViewFaculty.RowTemplate.Height = 24;
            this.dataGridViewFaculty.Size = new System.Drawing.Size(387, 221);
            this.dataGridViewFaculty.TabIndex = 0;
            this.dataGridViewFaculty.CellMouseClick +=
                new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFaculty_CellMouseClick);
            // 
            // buttonFacultyRecords
            // 
            this.buttonFacultyRecords.Location = new System.Drawing.Point(111, 520);
            this.buttonFacultyRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFacultyRecords.Name = "buttonFacultyRecords";
            this.buttonFacultyRecords.Size = new System.Drawing.Size(207, 36);
            this.buttonFacultyRecords.TabIndex = 1;
            this.buttonFacultyRecords.Text = "Display Faculty Records";
            this.buttonFacultyRecords.UseVisualStyleBackColor = true;
            this.buttonFacultyRecords.Click += new System.EventHandler(this.buttonFacultyRecords_Click);
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(506, 275);
            this.dataGridViewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(397, 221);
            this.dataGridViewStudent.TabIndex = 2;
            // 
            // buttonChildRecords
            // 
            this.buttonChildRecords.Location = new System.Drawing.Point(504, 520);
            this.buttonChildRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChildRecords.Name = "buttonChildRecords";
            this.buttonChildRecords.Size = new System.Drawing.Size(218, 36);
            this.buttonChildRecords.TabIndex = 3;
            this.buttonChildRecords.Text = "Update Student Records";
            this.buttonChildRecords.UseVisualStyleBackColor = true;
            this.buttonChildRecords.Click += new System.EventHandler(this.buttonChildRecords_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(31, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fid:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(31, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Age:";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(111, 64);
            this.textBoxFN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(100, 27);
            this.textBoxFN.TabIndex = 10;
            // 
            // textBoxLN
            // 
            this.textBoxLN.Location = new System.Drawing.Point(111, 111);
            this.textBoxLN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(100, 27);
            this.textBoxLN.TabIndex = 11;
            // 
            // textBoxFid
            // 
            this.textBoxFid.Location = new System.Drawing.Point(111, 158);
            this.textBoxFid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFid.Name = "textBoxFid";
            this.textBoxFid.Size = new System.Drawing.Size(100, 27);
            this.textBoxFid.TabIndex = 12;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(111, 208);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 27);
            this.textBoxAge.TabIndex = 13;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(617, 22);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 51);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(617, 94);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(105, 52);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(755, 520);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(148, 36);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sid:";
            // 
            // textBoxSid
            // 
            this.textBoxSid.Location = new System.Drawing.Point(111, 20);
            this.textBoxSid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSid.Name = "textBoxSid";
            this.textBoxSid.Size = new System.Drawing.Size(100, 27);
            this.textBoxSid.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 615);
            this.Controls.Add(this.textBoxSid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxFid);
            this.Controls.Add(this.textBoxLN);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonChildRecords);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.buttonFacultyRecords);
            this.Controls.Add(this.dataGridViewFaculty);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFaculty;
        private System.Windows.Forms.Button buttonFacultyRecords;
        private System.Windows.Forms.Button buttonChildRecords;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.TextBox textBoxFid;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxSid;
        private System.Windows.Forms.Label label1;
    }
}