namespace Receptes
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxFogás = new System.Windows.Forms.TextBox();
            this.textBoxHozzávaló = new System.Windows.Forms.TextBox();
            this.listBoxFogások = new System.Windows.Forms.ListBox();
            this.listBoxHozzávalók = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg4foDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hozzávalóBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzávalóBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFogás
            // 
            this.textBoxFogás.Location = new System.Drawing.Point(15, 13);
            this.textBoxFogás.Name = "textBoxFogás";
            this.textBoxFogás.Size = new System.Drawing.Size(242, 23);
            this.textBoxFogás.TabIndex = 0;
            this.textBoxFogás.TextChanged += new System.EventHandler(this.textBoxFogás_TextChanged);
            // 
            // textBoxHozzávaló
            // 
            this.textBoxHozzávaló.Location = new System.Drawing.Point(989, 13);
            this.textBoxHozzávaló.Name = "textBoxHozzávaló";
            this.textBoxHozzávaló.Size = new System.Drawing.Size(242, 23);
            this.textBoxHozzávaló.TabIndex = 1;
            this.textBoxHozzávaló.TextChanged += new System.EventHandler(this.textBoxHozzávaló_TextChanged);
            // 
            // listBoxFogások
            // 
            this.listBoxFogások.FormattingEnabled = true;
            this.listBoxFogások.ItemHeight = 15;
            this.listBoxFogások.Location = new System.Drawing.Point(15, 42);
            this.listBoxFogások.Name = "listBoxFogások";
            this.listBoxFogások.Size = new System.Drawing.Size(242, 619);
            this.listBoxFogások.TabIndex = 2;
            this.listBoxFogások.SelectedIndexChanged += new System.EventHandler(this.listBoxFogások_SelectedIndexChanged);
            // 
            // listBoxHozzávalók
            // 
            this.listBoxHozzávalók.FormattingEnabled = true;
            this.listBoxHozzávalók.ItemHeight = 15;
            this.listBoxHozzávalók.Location = new System.Drawing.Point(989, 42);
            this.listBoxHozzávalók.Name = "listBoxHozzávalók";
            this.listBoxHozzávalók.Size = new System.Drawing.Size(242, 619);
            this.listBoxHozzávalók.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.mennyiseg4foDataGridViewTextBoxColumn,
            this.egysegNevDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hozzávalóBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(263, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(720, 619);
            this.dataGridView1.TabIndex = 4;
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            this.mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            // 
            // egysegNevDataGridViewTextBoxColumn
            // 
            this.egysegNevDataGridViewTextBoxColumn.DataPropertyName = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.HeaderText = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.Name = "egysegNevDataGridViewTextBoxColumn";
            // 
            // árDataGridViewTextBoxColumn
            // 
            this.árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            this.árDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            // 
            // hozzávalóBindingSource
            // 
            this.hozzávalóBindingSource.DataSource = typeof(Receptes.Hozzávaló);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxHozzávalók);
            this.Controls.Add(this.listBoxFogások);
            this.Controls.Add(this.textBoxHozzávaló);
            this.Controls.Add(this.textBoxFogás);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1247, 673);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzávalóBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFogás;
        private TextBox textBoxHozzávaló;
        private ListBox listBoxFogások;
        private ListBox listBoxHozzávalók;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private BindingSource hozzávalóBindingSource;
    }
}
