namespace EBike.SrartByGroup
{
    partial class FormUserGroupManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_ModifyPWD = new System.Windows.Forms.RadioButton();
            this.radioBtn_Del = new System.Windows.Forms.RadioButton();
            this.radioBtn_New = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxPWDConfirm_New = new System.Windows.Forms.TextBox();
            this.tBoxPWD_New = new System.Windows.Forms.TextBox();
            this.tBoxUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBoxPWD_Del = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxUser_Del = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tBoxNewPWDConfirm_Modi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxNewPWD_Modi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxOldPWD_Modi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxUser_Modi = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_ModifyPWD);
            this.groupBox1.Controls.Add(this.radioBtn_Del);
            this.groupBox1.Controls.Add(this.radioBtn_New);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "作何操作？";
            // 
            // radioBtn_ModifyPWD
            // 
            this.radioBtn_ModifyPWD.AutoSize = true;
            this.radioBtn_ModifyPWD.Location = new System.Drawing.Point(96, 131);
            this.radioBtn_ModifyPWD.Name = "radioBtn_ModifyPWD";
            this.radioBtn_ModifyPWD.Size = new System.Drawing.Size(95, 16);
            this.radioBtn_ModifyPWD.TabIndex = 2;
            this.radioBtn_ModifyPWD.Text = "修改用户密码";
            this.radioBtn_ModifyPWD.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Del
            // 
            this.radioBtn_Del.AutoSize = true;
            this.radioBtn_Del.Location = new System.Drawing.Point(96, 96);
            this.radioBtn_Del.Name = "radioBtn_Del";
            this.radioBtn_Del.Size = new System.Drawing.Size(71, 16);
            this.radioBtn_Del.TabIndex = 1;
            this.radioBtn_Del.Text = "删除用户";
            this.radioBtn_Del.UseVisualStyleBackColor = true;
            // 
            // radioBtn_New
            // 
            this.radioBtn_New.AutoSize = true;
            this.radioBtn_New.Checked = true;
            this.radioBtn_New.Location = new System.Drawing.Point(96, 62);
            this.radioBtn_New.Name = "radioBtn_New";
            this.radioBtn_New.Size = new System.Drawing.Size(83, 16);
            this.radioBtn_New.TabIndex = 0;
            this.radioBtn_New.TabStop = true;
            this.radioBtn_New.Text = "创建新用户";
            this.radioBtn_New.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(626, 541);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(707, 541);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPre
            // 
            this.btnPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPre.Location = new System.Drawing.Point(545, 541);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 3;
            this.btnPre.Text = "上一步";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBoxPWDConfirm_New);
            this.groupBox2.Controls.Add(this.tBoxPWD_New);
            this.groupBox2.Controls.Add(this.tBoxUser);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(402, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 211);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "创建新用户";
            // 
            // tBoxPWDConfirm_New
            // 
            this.tBoxPWDConfirm_New.Location = new System.Drawing.Point(143, 126);
            this.tBoxPWDConfirm_New.Name = "tBoxPWDConfirm_New";
            this.tBoxPWDConfirm_New.PasswordChar = '*';
            this.tBoxPWDConfirm_New.Size = new System.Drawing.Size(100, 21);
            this.tBoxPWDConfirm_New.TabIndex = 5;
            this.tBoxPWDConfirm_New.Validating += new System.ComponentModel.CancelEventHandler(this.tBox_Validating);
            // 
            // tBoxPWD_New
            // 
            this.tBoxPWD_New.Location = new System.Drawing.Point(143, 95);
            this.tBoxPWD_New.Name = "tBoxPWD_New";
            this.tBoxPWD_New.PasswordChar = '*';
            this.tBoxPWD_New.Size = new System.Drawing.Size(100, 21);
            this.tBoxPWD_New.TabIndex = 4;
            this.tBoxPWD_New.Validating += new System.ComponentModel.CancelEventHandler(this.tBox_Validating);
            // 
            // tBoxUser
            // 
            this.tBoxUser.Location = new System.Drawing.Point(143, 62);
            this.tBoxUser.Name = "tBoxUser";
            this.tBoxUser.Size = new System.Drawing.Size(100, 21);
            this.tBoxUser.TabIndex = 3;
            this.tBoxUser.Validating += new System.ComponentModel.CancelEventHandler(this.tBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码确认：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名称：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tBoxPWD_Del);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.listBoxUser_Del);
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 211);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "删除用户";
            // 
            // tBoxPWD_Del
            // 
            this.tBoxPWD_Del.Location = new System.Drawing.Point(186, 80);
            this.tBoxPWD_Del.Name = "tBoxPWD_Del";
            this.tBoxPWD_Del.PasswordChar = '*';
            this.tBoxPWD_Del.Size = new System.Drawing.Size(100, 21);
            this.tBoxPWD_Del.TabIndex = 8;
            this.tBoxPWD_Del.Visible = false;
            this.tBoxPWD_Del.Validating += new System.ComponentModel.CancelEventHandler(this.tBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "用户密码：";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "选择要删除的用户：";
            // 
            // listBoxUser_Del
            // 
            this.listBoxUser_Del.FormattingEnabled = true;
            this.listBoxUser_Del.ItemHeight = 12;
            this.listBoxUser_Del.Location = new System.Drawing.Point(6, 44);
            this.listBoxUser_Del.Name = "listBoxUser_Del";
            this.listBoxUser_Del.Size = new System.Drawing.Size(141, 160);
            this.listBoxUser_Del.TabIndex = 0;
            this.listBoxUser_Del.SelectedIndexChanged += new System.EventHandler(this.listBoxUser_Del_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tBoxNewPWDConfirm_Modi);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tBoxNewPWD_Modi);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tBoxOldPWD_Modi);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.listBoxUser_Modi);
            this.groupBox4.Location = new System.Drawing.Point(402, 238);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 211);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "修改用户密码";
            // 
            // tBoxNewPWDConfirm_Modi
            // 
            this.tBoxNewPWDConfirm_Modi.Location = new System.Drawing.Point(187, 163);
            this.tBoxNewPWDConfirm_Modi.Name = "tBoxNewPWDConfirm_Modi";
            this.tBoxNewPWDConfirm_Modi.PasswordChar = '*';
            this.tBoxNewPWDConfirm_Modi.Size = new System.Drawing.Size(100, 21);
            this.tBoxNewPWDConfirm_Modi.TabIndex = 16;
            this.tBoxNewPWDConfirm_Modi.Validating += new System.ComponentModel.CancelEventHandler(this.tBox_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "新密码确认：";
            // 
            // tBoxNewPWD_Modi
            // 
            this.tBoxNewPWD_Modi.Location = new System.Drawing.Point(187, 120);
            this.tBoxNewPWD_Modi.Name = "tBoxNewPWD_Modi";
            this.tBoxNewPWD_Modi.PasswordChar = '*';
            this.tBoxNewPWD_Modi.Size = new System.Drawing.Size(100, 21);
            this.tBoxNewPWD_Modi.TabIndex = 14;
            this.tBoxNewPWD_Modi.Validating += new System.ComponentModel.CancelEventHandler(this.tBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "新密码：";
            // 
            // tBoxOldPWD_Modi
            // 
            this.tBoxOldPWD_Modi.Location = new System.Drawing.Point(187, 62);
            this.tBoxOldPWD_Modi.Name = "tBoxOldPWD_Modi";
            this.tBoxOldPWD_Modi.PasswordChar = '*';
            this.tBoxOldPWD_Modi.Size = new System.Drawing.Size(100, 21);
            this.tBoxOldPWD_Modi.TabIndex = 12;
            this.tBoxOldPWD_Modi.Validating += new System.ComponentModel.CancelEventHandler(this.tBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "旧密码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "选择要修改的用户：";
            // 
            // listBoxUser_Modi
            // 
            this.listBoxUser_Modi.FormattingEnabled = true;
            this.listBoxUser_Modi.ItemHeight = 12;
            this.listBoxUser_Modi.Location = new System.Drawing.Point(8, 45);
            this.listBoxUser_Modi.Name = "listBoxUser_Modi";
            this.listBoxUser_Modi.Size = new System.Drawing.Size(141, 160);
            this.listBoxUser_Modi.TabIndex = 9;
            // 
            // FormUserGroupManage
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(794, 576);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormUserGroupManage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.RadioButton radioBtn_ModifyPWD;
        private System.Windows.Forms.RadioButton radioBtn_Del;
        private System.Windows.Forms.RadioButton radioBtn_New;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBoxPWDConfirm_New;
        private System.Windows.Forms.TextBox tBoxPWD_New;
        private System.Windows.Forms.TextBox tBoxUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxUser_Del;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxPWD_Del;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxNewPWDConfirm_Modi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBoxNewPWD_Modi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxOldPWD_Modi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxUser_Modi;
    }
}