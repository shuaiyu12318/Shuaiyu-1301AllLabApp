namespace LabAss2
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textNumber1 = new System.Windows.Forms.TextBox();
            this.textNumber2 = new System.Windows.Forms.TextBox();
            this.inPlus = new System.Windows.Forms.Button();
            this.inMinus = new System.Windows.Forms.Button();
            this.inMultiplication = new System.Windows.Forms.Button();
            this.inDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNumber1
            // 
            this.textNumber1.Location = new System.Drawing.Point(142, 97);
            this.textNumber1.Name = "textNumber1";
            this.textNumber1.Size = new System.Drawing.Size(145, 25);
            this.textNumber1.TabIndex = 0;
            // 
            // textNumber2
            // 
            this.textNumber2.Location = new System.Drawing.Point(421, 97);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(146, 25);
            this.textNumber2.TabIndex = 1;
            // 
            // inPlus
            // 
            this.inPlus.Location = new System.Drawing.Point(142, 164);
            this.inPlus.Name = "inPlus";
            this.inPlus.Size = new System.Drawing.Size(63, 37);
            this.inPlus.TabIndex = 2;
            this.inPlus.Text = "+";
            this.inPlus.UseVisualStyleBackColor = true;
            this.inPlus.Click += new System.EventHandler(this.inPlus_Click);
            // 
            // inMinus
            // 
            this.inMinus.Location = new System.Drawing.Point(243, 164);
            this.inMinus.Name = "inMinus";
            this.inMinus.Size = new System.Drawing.Size(65, 37);
            this.inMinus.TabIndex = 3;
            this.inMinus.Text = "-";
            this.inMinus.UseVisualStyleBackColor = true;
            this.inMinus.Click += new System.EventHandler(this.inMinus_Click);
            // 
            // inMultiplication
            // 
            this.inMultiplication.Location = new System.Drawing.Point(370, 164);
            this.inMultiplication.Name = "inMultiplication";
            this.inMultiplication.Size = new System.Drawing.Size(75, 37);
            this.inMultiplication.TabIndex = 4;
            this.inMultiplication.Text = "*";
            this.inMultiplication.UseVisualStyleBackColor = true;
            this.inMultiplication.Click += new System.EventHandler(this.inMultiplication_Click);
            // 
            // inDivision
            // 
            this.inDivision.Location = new System.Drawing.Point(503, 164);
            this.inDivision.Name = "inDivision";
            this.inDivision.Size = new System.Drawing.Size(75, 37);
            this.inDivision.TabIndex = 5;
            this.inDivision.Text = "/";
            this.inDivision.UseVisualStyleBackColor = true;
            this.inDivision.Click += new System.EventHandler(this.inDivision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inDivision);
            this.Controls.Add(this.inMultiplication);
            this.Controls.Add(this.inMinus);
            this.Controls.Add(this.inPlus);
            this.Controls.Add(this.textNumber2);
            this.Controls.Add(this.textNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumber1;
        private System.Windows.Forms.TextBox textNumber2;
        private System.Windows.Forms.Button inPlus;
        private System.Windows.Forms.Button inMinus;
        private System.Windows.Forms.Button inMultiplication;
        private System.Windows.Forms.Button inDivision;
    }
}

