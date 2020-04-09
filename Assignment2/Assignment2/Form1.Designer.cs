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
            this.dataGridViewParent = new System.Windows.Forms.DataGridView();
            this.buttonParentRecords = new System.Windows.Forms.Button();
            this.dataGridViewChild = new System.Windows.Forms.DataGridView();
            this.buttonChildRecords = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewChild)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParent
            // 
            this.dataGridViewParent.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParent.Location = new System.Drawing.Point(31, 275);
            this.dataGridViewParent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewParent.Name = "dataGridViewParent";
            this.dataGridViewParent.RowTemplate.Height = 24;
            this.dataGridViewParent.Size = new System.Drawing.Size(387, 221);
            this.dataGridViewParent.TabIndex = 0;
            this.dataGridViewParent.CellMouseClick +=
                new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFaculty_CellMouseClick);
            // 
            // buttonParentRecords
            // 
            this.buttonParentRecords.Location = new System.Drawing.Point(111, 520);
            this.buttonParentRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonParentRecords.Name = "buttonParentRecords";
            this.buttonParentRecords.Size = new System.Drawing.Size(207, 36);
            this.buttonParentRecords.TabIndex = 1;
            this.buttonParentRecords.Text = "Display Parent Records";
            this.buttonParentRecords.UseVisualStyleBackColor = true;
            this.buttonParentRecords.Click += new System.EventHandler(this.buttonFacultyRecords_Click);
            // 
            // dataGridViewChild
            // 
            this.dataGridViewChild.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChild.Location = new System.Drawing.Point(506, 275);
            this.dataGridViewChild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewChild.Name = "dataGridViewChild";
            this.dataGridViewChild.RowTemplate.Height = 24;
            this.dataGridViewChild.Size = new System.Drawing.Size(397, 221);
            this.dataGridViewChild.TabIndex = 2;
            // 
            // buttonChildRecords
            // 
            this.buttonChildRecords.Location = new System.Drawing.Point(504, 520);
            this.buttonChildRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChildRecords.Name = "buttonChildRecords";
            this.buttonChildRecords.Size = new System.Drawing.Size(218, 36);
            this.buttonChildRecords.TabIndex = 3;
            this.buttonChildRecords.Text = "Update Child Records";
            this.buttonChildRecords.UseVisualStyleBackColor = true;
            this.buttonChildRecords.Click += new System.EventHandler(this.buttonChildRecords_Click);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(67, 22);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(287, 229);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 615);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChildRecords);
            this.Controls.Add(this.dataGridViewChild);
            this.Controls.Add(this.buttonParentRecords);
            this.Controls.Add(this.dataGridViewParent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewChild)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonChildRecords;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewParent;
        private System.Windows.Forms.DataGridView dataGridViewChild;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonParentRecords;
    }
}