
namespace PlayerStats.View
{
    partial class Player
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
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerDBDataSet = new PlayerStats.PlayerDBDataSet();
            this.playerTableAdapter = new PlayerStats.PlayerDBDataSetTableAdapters.PlayerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AutoGenerateColumns = false;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn});
            this.dgvPlayers.DataSource = this.playerBindingSource;
            this.dgvPlayers.Location = new System.Drawing.Point(47, 34);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.Size = new System.Drawing.Size(240, 150);
            this.dgvPlayers.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "points";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.playerDBDataSet;
            // 
            // playerDBDataSet
            // 
            this.playerDBDataSet.DataSetName = "PlayerDBDataSet";
            this.playerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(664, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 83);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Name.Location = new System.Drawing.Point(396, 34);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(121, 30);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(396, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Points";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(538, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(538, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlayerStats.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPlayers);
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayers;
        private PlayerDBDataSet playerDBDataSet;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private PlayerDBDataSetTableAdapters.PlayerTableAdapter playerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}