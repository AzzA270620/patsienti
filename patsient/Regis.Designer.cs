namespace patsient
{
    partial class Regis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chief_id = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.parol = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Cancellation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this._ch,
            this.email_ch});
            this.dataGridView1.Location = new System.Drawing.Point(40, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(447, 148);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "chief_id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "login";
            this.Column2.Name = "Column2";
            // 
            // _ch
            // 
            this._ch.HeaderText = "parol";
            this._ch.Name = "_ch";
            // 
            // email_ch
            // 
            this.email_ch.HeaderText = "email";
            this.email_ch.Name = "email_ch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "chief_id";
            // 
            // chief_id
            // 
            this.chief_id.Location = new System.Drawing.Point(111, 226);
            this.chief_id.Name = "chief_id";
            this.chief_id.Size = new System.Drawing.Size(221, 26);
            this.chief_id.TabIndex = 2;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(111, 259);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(221, 26);
            this.login.TabIndex = 3;
            // 
            // parol
            // 
            this.parol.Location = new System.Drawing.Point(111, 293);
            this.parol.Name = "parol";
            this.parol.Size = new System.Drawing.Size(221, 26);
            this.parol.TabIndex = 4;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(111, 325);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(221, 26);
            this.email.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "parol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "email";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(353, 222);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(122, 30);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(353, 258);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(122, 26);
            this.Insert.TabIndex = 10;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(353, 291);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(122, 28);
            this.Update.TabIndex = 11;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(353, 325);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(122, 26);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Cancellation
            // 
            this.Cancellation.Location = new System.Drawing.Point(353, 355);
            this.Cancellation.Name = "Cancellation";
            this.Cancellation.Size = new System.Drawing.Size(122, 36);
            this.Cancellation.TabIndex = 13;
            this.Cancellation.Text = "Cancellation";
            this.Cancellation.UseVisualStyleBackColor = true;
            // 
            // Regis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 629);
            this.Controls.Add(this.Cancellation);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.parol);
            this.Controls.Add(this.login);
            this.Controls.Add(this.chief_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Regis";
            this.Text = "Regis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ch;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_ch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chief_id;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox parol;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancellation;
    }
}