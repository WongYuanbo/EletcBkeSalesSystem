namespace EBike.SrartByGroup
{
    partial class FormStartByGroup
    { /// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartByGroup));
            this.lblPwd = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUserMgd = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cekBoxSetNowUser = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Location = new System.Drawing.Point(117, 134);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(47, 12);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "密  码:";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(116, 191);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "登录";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(216, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUserMgd
            // 
            this.btnUserMgd.BackColor = System.Drawing.Color.Transparent;
            this.btnUserMgd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserMgd.Location = new System.Drawing.Point(290, 105);
            this.btnUserMgd.Name = "btnUserMgd";
            this.btnUserMgd.Size = new System.Drawing.Size(75, 23);
            this.btnUserMgd.TabIndex = 24;
            this.btnUserMgd.Text = "用户管理";
            this.btnUserMgd.UseVisualStyleBackColor = false;
            this.btnUserMgd.Visible = false;
            this.btnUserMgd.Click += new System.EventHandler(this.btnUserMgd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 131);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // comboGroup
            // 
            this.comboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(170, 105);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(100, 20);
            this.comboGroup.TabIndex = 28;
            this.comboGroup.SelectedIndexChanged += new System.EventHandler(this.comboGroup_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(117, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "用  户:";
            // 
            // cekBoxSetNowUser
            // 
            this.cekBoxSetNowUser.AutoSize = true;
            this.cekBoxSetNowUser.BackColor = System.Drawing.Color.Transparent;
            this.cekBoxSetNowUser.Location = new System.Drawing.Point(119, 160);
            this.cekBoxSetNowUser.Name = "cekBoxSetNowUser";
            this.cekBoxSetNowUser.Size = new System.Drawing.Size(72, 16);
            this.cekBoxSetNowUser.TabIndex = 30;
            this.cekBoxSetNowUser.Text = "默认用户";
            this.cekBoxSetNowUser.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("仿宋", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(115, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "电动车销售管理系统";
            // 
            // FormStartByGroup
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cekBoxSetNowUser);
            this.Controls.Add(this.comboGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUserMgd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStartByGroup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUserMgd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cekBoxSetNowUser;
        private System.Windows.Forms.Label label2;
    }
}