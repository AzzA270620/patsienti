namespace patsient
{
    partial class avtoriz
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
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            this.par = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.parol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(61, 142);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(106, 34);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(196, 142);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(93, 34);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(13, 23);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(42, 20);
            this.log.TabIndex = 2;
            this.log.Text = "login";
            // 
            // par
            // 
            this.par.AutoSize = true;
            this.par.Location = new System.Drawing.Point(17, 61);
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(44, 20);
            this.par.TabIndex = 3;
            this.par.Text = "parol";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(102, 23);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(203, 26);
            this.login.TabIndex = 4;
            // 
            // parol
            // 
            this.parol.Location = new System.Drawing.Point(102, 61);
            this.parol.Name = "parol";
            this.parol.Size = new System.Drawing.Size(203, 26);
            this.parol.TabIndex = 5;
            // 
            // avtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 241);
            this.Controls.Add(this.parol);
            this.Controls.Add(this.login);
            this.Controls.Add(this.par);
            this.Controls.Add(this.log);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Name = "avtoriz";
            this.Text = "avtoriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label par;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox parol;
    }
}