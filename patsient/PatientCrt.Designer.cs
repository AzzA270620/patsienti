namespace patsient
{
    partial class PatientCrt
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PatientCart = new System.Windows.Forms.DataGridView();
            this.id_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnos_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrance_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialls_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ward_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.others_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.full_name = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.diagnos = new System.Windows.Forms.ComboBox();
            this.Ward = new System.Windows.Forms.ComboBox();
            this.Entrance = new System.Windows.Forms.TextBox();
            this.Specialls = new System.Windows.Forms.TextBox();
            this.others = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatientCart)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientCart
            // 
            this.PatientCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_p,
            this.full_name_p,
            this.Sex_p,
            this.Age_p,
            this.diagnos_p,
            this.Entrance_p,
            this.Specialls_p,
            this.Ward_p,
            this.others_p});
            this.PatientCart.Location = new System.Drawing.Point(12, 24);
            this.PatientCart.Name = "PatientCart";
            this.PatientCart.RowTemplate.Height = 28;
            this.PatientCart.Size = new System.Drawing.Size(947, 182);
            this.PatientCart.TabIndex = 0;
            // 
            // id_p
            // 
            this.id_p.HeaderText = "id";
            this.id_p.Name = "id_p";
            // 
            // full_name_p
            // 
            this.full_name_p.HeaderText = "full_name";
            this.full_name_p.Name = "full_name_p";
            // 
            // Sex_p
            // 
            this.Sex_p.HeaderText = "Sex";
            this.Sex_p.Name = "Sex_p";
            // 
            // Age_p
            // 
            this.Age_p.HeaderText = "Age";
            this.Age_p.Name = "Age_p";
            // 
            // diagnos_p
            // 
            this.diagnos_p.HeaderText = "diagnos";
            this.diagnos_p.Name = "diagnos_p";
            // 
            // Entrance_p
            // 
            this.Entrance_p.HeaderText = "Entrance";
            this.Entrance_p.Name = "Entrance_p";
            // 
            // Specialls_p
            // 
            this.Specialls_p.HeaderText = "Specialls";
            this.Specialls_p.Name = "Specialls_p";
            // 
            // Ward_p
            // 
            this.Ward_p.HeaderText = "Ward";
            this.Ward_p.Name = "Ward_p";
            // 
            // others_p
            // 
            this.others_p.HeaderText = "others";
            this.others_p.Name = "others_p";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "full_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "diagnos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Entrance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Specialls";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ward";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 559);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "others";
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(534, 475);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(176, 49);
            this.del.TabIndex = 10;
            this.del.Text = "delete";
            this.del.UseVisualStyleBackColor = true;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(534, 343);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(176, 57);
            this.New.TabIndex = 11;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(534, 412);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(176, 57);
            this.Edit.TabIndex = 12;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(170, 248);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(194, 26);
            this.id.TabIndex = 13;
            // 
            // full_name
            // 
            this.full_name.Location = new System.Drawing.Point(170, 286);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(194, 26);
            this.full_name.TabIndex = 14;
            // 
            // Sex
            // 
            this.Sex.Location = new System.Drawing.Point(170, 324);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(194, 26);
            this.Sex.TabIndex = 15;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(170, 363);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(194, 26);
            this.Age.TabIndex = 16;
            // 
            // diagnos
            // 
            this.diagnos.FormattingEnabled = true;
            this.diagnos.Location = new System.Drawing.Point(170, 403);
            this.diagnos.Name = "diagnos";
            this.diagnos.Size = new System.Drawing.Size(194, 28);
            this.diagnos.TabIndex = 17;
            // 
            // Ward
            // 
            this.Ward.FormattingEnabled = true;
            this.Ward.Location = new System.Drawing.Point(170, 513);
            this.Ward.Name = "Ward";
            this.Ward.Size = new System.Drawing.Size(194, 28);
            this.Ward.TabIndex = 18;
            // 
            // Entrance
            // 
            this.Entrance.Location = new System.Drawing.Point(170, 442);
            this.Entrance.Name = "Entrance";
            this.Entrance.Size = new System.Drawing.Size(194, 26);
            this.Entrance.TabIndex = 19;
            // 
            // Specialls
            // 
            this.Specialls.Location = new System.Drawing.Point(170, 481);
            this.Specialls.Name = "Specialls";
            this.Specialls.Size = new System.Drawing.Size(194, 26);
            this.Specialls.TabIndex = 20;
            // 
            // others
            // 
            this.others.Location = new System.Drawing.Point(170, 559);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(194, 26);
            this.others.TabIndex = 21;
            // 
            // PatientCrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 619);
            this.Controls.Add(this.others);
            this.Controls.Add(this.Specialls);
            this.Controls.Add(this.Entrance);
            this.Controls.Add(this.Ward);
            this.Controls.Add(this.diagnos);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.full_name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.New);
            this.Controls.Add(this.del);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientCart);
            this.Name = "PatientCrt";
            this.Text = "PasientCart";
            ((System.ComponentModel.ISupportInitialize)(this.PatientCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnos_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrance_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialls_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ward_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn others_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.TextBox Sex;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.ComboBox diagnos;
        private System.Windows.Forms.ComboBox Ward;
        private System.Windows.Forms.TextBox Entrance;
        private System.Windows.Forms.TextBox Specialls;
        private System.Windows.Forms.TextBox others;
    }
}

