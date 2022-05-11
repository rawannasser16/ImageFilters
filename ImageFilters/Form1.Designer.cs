namespace ImageFilters
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnZGraph = new System.Windows.Forms.Button();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(496, 469);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(496, 513);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(512, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 431);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 431);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(8, 466);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(126, 62);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(700, 466);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(128, 62);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnZGraph
            // 
            this.btnZGraph.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZGraph.Location = new System.Drawing.Point(842, 466);
            this.btnZGraph.Name = "btnZGraph";
            this.btnZGraph.Size = new System.Drawing.Size(126, 62);
            this.btnZGraph.TabIndex = 3;
            this.btnZGraph.Text = "Z Graph Example";
            this.btnZGraph.UseVisualStyleBackColor = true;
            this.btnZGraph.Click += new System.EventHandler(this.btnZGraph_Click);
            // 
            // combo1
            // 
            this.combo1.Items.AddRange(new object[] {
            "Adaptive",
            "Alpha-Trim"});
            this.combo1.Location = new System.Drawing.Point(190, 469);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(120, 21);
            this.combo1.TabIndex = 1;
            this.combo1.SelectedIndexChanged += new System.EventHandler(this.combo1_SelectedIndexChanged);
            // 
            // combo2
            // 
            this.combo2.Items.AddRange(new object[] {
            "Quick sort",
            "Count Sort",
            "Heap Sort"});
            this.combo2.Location = new System.Drawing.Point(330, 466);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(122, 21);
            this.combo2.TabIndex = 1;
            this.combo2.SelectedIndexChanged += new System.EventHandler(this.combo2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(989, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1002, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 541);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnZGraph);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.combo2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Image Filters...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnZGraph;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

