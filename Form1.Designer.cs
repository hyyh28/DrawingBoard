namespace drawboard
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
            this.db = new System.Windows.Forms.PictureBox();
            this.arrow = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.ellipse = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.recta = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pencolor = new System.Windows.Forms.Button();
            this.thepen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // db
            // 
            this.db.Location = new System.Drawing.Point(50, -1);
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(1478, 677);
            this.db.TabIndex = 0;
            this.db.TabStop = false;
            this.db.MouseDown += new System.Windows.Forms.MouseEventHandler(this.db_MouseDown);
            this.db.MouseMove += new System.Windows.Forms.MouseEventHandler(this.db_MouseMove);
            this.db.MouseUp += new System.Windows.Forms.MouseEventHandler(this.db_MouseUp);
            // 
            // arrow
            // 
            this.arrow.Cursor = System.Windows.Forms.Cursors.Default;
            this.arrow.Location = new System.Drawing.Point(-3, -1);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(52, 23);
            this.arrow.TabIndex = 1;
            this.arrow.Text = "箭头";
            this.arrow.UseVisualStyleBackColor = true;
            this.arrow.Click += new System.EventHandler(this.arrow_Click);
            // 
            // line
            // 
            this.line.Cursor = System.Windows.Forms.Cursors.Default;
            this.line.Location = new System.Drawing.Point(-3, 28);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(52, 23);
            this.line.TabIndex = 2;
            this.line.Text = "直线";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // ellipse
            // 
            this.ellipse.Cursor = System.Windows.Forms.Cursors.Default;
            this.ellipse.Location = new System.Drawing.Point(-3, 57);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(52, 23);
            this.ellipse.TabIndex = 3;
            this.ellipse.Text = "椭圆";
            this.ellipse.UseVisualStyleBackColor = true;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.clear.Location = new System.Drawing.Point(-3, 86);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(52, 23);
            this.clear.TabIndex = 4;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(-3, 224);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 21);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "画笔宽度";
            // 
            // recta
            // 
            this.recta.Location = new System.Drawing.Point(-3, 115);
            this.recta.Name = "recta";
            this.recta.Size = new System.Drawing.Size(50, 23);
            this.recta.TabIndex = 7;
            this.recta.Text = "矩形";
            this.recta.UseVisualStyleBackColor = true;
            this.recta.Click += new System.EventHandler(this.recta_Click);
            // 
            // pencolor
            // 
            this.pencolor.Location = new System.Drawing.Point(-3, 176);
            this.pencolor.Name = "pencolor";
            this.pencolor.Size = new System.Drawing.Size(52, 23);
            this.pencolor.TabIndex = 8;
            this.pencolor.Text = "颜色";
            this.pencolor.UseVisualStyleBackColor = true;
            this.pencolor.Click += new System.EventHandler(this.pencolor_Click);
            // 
            // thepen
            // 
            this.thepen.Location = new System.Drawing.Point(-3, 144);
            this.thepen.Name = "thepen";
            this.thepen.Size = new System.Drawing.Size(50, 23);
            this.thepen.TabIndex = 9;
            this.thepen.Text = "钢笔";
            this.thepen.UseVisualStyleBackColor = true;
            this.thepen.Click += new System.EventHandler(this.thepen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "by hy";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(-1, 252);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(48, 23);
            this.save.TabIndex = 11;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 538);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thepen);
            this.Controls.Add(this.pencolor);
            this.Controls.Add(this.recta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.ellipse);
            this.Controls.Add(this.line);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.db);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox db;
        private System.Windows.Forms.Button arrow;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recta;
        private System.Windows.Forms.Button pencolor;
        public System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button thepen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save;
    }
}

