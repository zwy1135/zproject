namespace n_queens_problem
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.resultList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "放置几个皇后(十二以内)";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(267, 30);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(100, 21);
            this.numberBox.TabIndex = 1;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(373, 28);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "运行";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(46, 94);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "结果图(请从右方选择，红色为皇后位置)";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.countLabel.Location = new System.Drawing.Point(510, 72);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(66, 19);
            this.countLabel.TabIndex = 7;
            this.countLabel.Text = "计数器";
            // 
            // resultList
            // 
            this.resultList.FormattingEnabled = true;
            this.resultList.ItemHeight = 12;
            this.resultList.Location = new System.Drawing.Point(514, 98);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(156, 400);
            this.resultList.TabIndex = 8;
            this.resultList.SelectedIndexChanged += new System.EventHandler(this.resultList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 509);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "n皇后问题求解器";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.ListBox resultList;
    }
}

