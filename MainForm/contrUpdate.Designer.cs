namespace EBike.MainForm
{
    partial class contrUpdate
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSaler = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.saleTime = new System.Windows.Forms.DateTimePicker();
            this.txtSaleOrNot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtRKPers = new System.Windows.Forms.TextBox();
            this.combBId = new System.Windows.Forms.ComboBox();
            this.rkTime = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSaler);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.saleTime);
            this.groupBox1.Controls.Add(this.txtSaleOrNot);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Controls.Add(this.txtRKPers);
            this.groupBox1.Controls.Add(this.combBId);
            this.groupBox1.Controls.Add(this.rkTime);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改车辆信息";
            // 
            // txtSaler
            // 
            this.txtSaler.Location = new System.Drawing.Point(81, 143);
            this.txtSaler.Name = "txtSaler";
            this.txtSaler.Size = new System.Drawing.Size(124, 21);
            this.txtSaler.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "销售员：";
            // 
            // saleTime
            // 
            this.saleTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.saleTime.Location = new System.Drawing.Point(333, 143);
            this.saleTime.Name = "saleTime";
            this.saleTime.Size = new System.Drawing.Size(124, 21);
            this.saleTime.TabIndex = 24;
            // 
            // txtSaleOrNot
            // 
            this.txtSaleOrNot.Location = new System.Drawing.Point(333, 104);
            this.txtSaleOrNot.Name = "txtSaleOrNot";
            this.txtSaleOrNot.Size = new System.Drawing.Size(124, 21);
            this.txtSaleOrNot.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "销售时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "是否售出：";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(333, 26);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(124, 21);
            this.txtType.TabIndex = 19;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(81, 65);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(124, 21);
            this.txtBrand.TabIndex = 18;
            // 
            // txtRKPers
            // 
            this.txtRKPers.Location = new System.Drawing.Point(81, 104);
            this.txtRKPers.Name = "txtRKPers";
            this.txtRKPers.Size = new System.Drawing.Size(124, 21);
            this.txtRKPers.TabIndex = 17;
            // 
            // combBId
            // 
            this.combBId.FormattingEnabled = true;
            this.combBId.Location = new System.Drawing.Point(81, 27);
            this.combBId.Name = "combBId";
            this.combBId.Size = new System.Drawing.Size(124, 20);
            this.combBId.TabIndex = 16;
            this.combBId.SelectedIndexChanged += new System.EventHandler(this.combBId_SelectedIndexChanged);
            // 
            // rkTime
            // 
            this.rkTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rkTime.Location = new System.Drawing.Point(333, 65);
            this.rkTime.Name = "rkTime";
            this.rkTime.Size = new System.Drawing.Size(124, 21);
            this.rkTime.TabIndex = 15;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(81, 183);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(124, 21);
            this.txtNote.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "备  注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "入库人：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "入库时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "品牌名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "车    型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "车辆ID：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(216, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "修  改";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(336, 264);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(74, 25);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取  消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // contrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "contrUpdate";
            this.Size = new System.Drawing.Size(497, 318);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.DateTimePicker rkTime;
        private System.Windows.Forms.ComboBox combBId;
        private System.Windows.Forms.DateTimePicker saleTime;
        private System.Windows.Forms.TextBox txtSaleOrNot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtRKPers;
        private System.Windows.Forms.TextBox txtSaler;
        private System.Windows.Forms.Label label9;
    }
}
