namespace Receptes
{
    partial class UserControl2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nyersanyagIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegiEgysegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nyersanyagIdDataGridViewTextBoxColumn,
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn,
            this.egysegarDataGridViewTextBoxColumn,
            this.mennyisegiEgysegDataGridViewTextBoxColumn,
            this.receptekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nyersanyagokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(234, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(825, 570);
            this.dataGridView1.TabIndex = 0;
            // 
            // nyersanyagIdDataGridViewTextBoxColumn
            // 
            this.nyersanyagIdDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagId";
            this.nyersanyagIdDataGridViewTextBoxColumn.HeaderText = "NyersanyagId";
            this.nyersanyagIdDataGridViewTextBoxColumn.Name = "nyersanyagIdDataGridViewTextBoxColumn";
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // mennyisegiEgysegIdDataGridViewTextBoxColumn
            // 
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn.DataPropertyName = "MennyisegiEgysegId";
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn.HeaderText = "MennyisegiEgysegId";
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn.Name = "mennyisegiEgysegIdDataGridViewTextBoxColumn";
            // 
            // egysegarDataGridViewTextBoxColumn
            // 
            this.egysegarDataGridViewTextBoxColumn.DataPropertyName = "Egysegar";
            this.egysegarDataGridViewTextBoxColumn.HeaderText = "Egysegar";
            this.egysegarDataGridViewTextBoxColumn.Name = "egysegarDataGridViewTextBoxColumn";
            // 
            // mennyisegiEgysegDataGridViewTextBoxColumn
            // 
            this.mennyisegiEgysegDataGridViewTextBoxColumn.DataPropertyName = "MennyisegiEgyseg";
            this.mennyisegiEgysegDataGridViewTextBoxColumn.HeaderText = "MennyisegiEgyseg";
            this.mennyisegiEgysegDataGridViewTextBoxColumn.Name = "mennyisegiEgysegDataGridViewTextBoxColumn";
            // 
            // receptekDataGridViewTextBoxColumn
            // 
            this.receptekDataGridViewTextBoxColumn.DataPropertyName = "Receptek";
            this.receptekDataGridViewTextBoxColumn.HeaderText = "Receptek";
            this.receptekDataGridViewTextBoxColumn.Name = "receptekDataGridViewTextBoxColumn";
            this.receptekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nyersanyagokBindingSource
            // 
            this.nyersanyagokBindingSource.DataSource = typeof(Receptes.Models.Nyersanyagok);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 574);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1102, 634);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nyersanyagIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegiEgysegIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegiEgysegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receptekDataGridViewTextBoxColumn;
        private BindingSource nyersanyagokBindingSource;
        private ListBox listBox1;
    }
}
