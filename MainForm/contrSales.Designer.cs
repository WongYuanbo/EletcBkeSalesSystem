namespace EBike.MainForm
{
    partial class contrSales
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
            this.combAssemb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combSaler = new System.Windows.Forms.ComboBox();
            this.combColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combBrand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.combType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combAssemb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combSaler);
            this.groupBox1.Controls.Add(this.combColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.combBrand);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.combType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "销售入库";
            // 
            // combAssemb
            // 
            this.combAssemb.FormattingEnabled = true;
            this.combAssemb.Location = new System.Drawing.Point(88, 148);
            this.combAssemb.Name = "combAssemb";
            this.combAssemb.Size = new System.Drawing.Size(124, 20);
            this.combAssemb.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "装车人员：";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(320, 76);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(124, 21);
            this.txtNum.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "销售数量：";
            // 
            // combSaler
            // 
            this.combSaler.FormattingEnabled = true;
            this.combSaler.Location = new System.Drawing.Point(88, 113);
            this.combSaler.Name = "combSaler";
            this.combSaler.Size = new System.Drawing.Size(124, 20);
            this.combSaler.TabIndex = 20;
            // 
            // combColor
            // 
            this.combColor.FormattingEnabled = true;
            this.combColor.Location = new System.Drawing.Point(88, 76);
            this.combColor.Name = "combColor";
            this.combColor.Size = new System.Drawing.Size(124, 20);
            this.combColor.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "颜  色：";
            // 
            // combBrand
            // 
            this.combBrand.FormattingEnabled = true;
            this.combBrand.Location = new System.Drawing.Point(88, 36);
            this.combBrand.Name = "combBrand";
            this.combBrand.Size = new System.Drawing.Size(124, 20);
            this.combBrand.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "品牌名：";
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(320, 113);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(124, 21);
            this.txtDate.TabIndex = 15;
            // 
            // combType
            // 
            this.combType.FormattingEnabled = true;
            this.combType.Location = new System.Drawing.Point(320, 33);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(124, 20);
            this.combType.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "销售员：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "销售时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "车   型：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(292, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "入   库";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(393, 264);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(74, 25);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取  消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // contrSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "contrSales";
            this.Size = new System.Drawing.Size(497, 318);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combBrand;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combSaler;
        private System.Windows.Forms.ComboBox combAssemb;
        private System.Windows.Forms.Label label7;
    }
}
