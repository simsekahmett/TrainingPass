
namespace TrainingPass
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
			this.components = new System.ComponentModel.Container();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 1;
			this.trackBar1.Location = new System.Drawing.Point(100, 50);
			this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(162, 45);
			this.trackBar1.TabIndex = 0;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.progressBar1);
			this.groupBox1.Controls.Add(this.trackBar1);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(290, 129);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ses Ayarları";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(264, 50);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 84);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Anlık Ses Seviyesi:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 50);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Bekleme Süresi:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ses Çıkış Cihazı: ";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(100, 16);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(189, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(3, 100);
			this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(284, 22);
			this.progressBar1.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(6, 138);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(290, 65);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Clicker Ayarları";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(190, 42);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(97, 20);
			this.button3.TabIndex = 6;
			this.button3.Text = "Koordinat Al";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 46);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "[]";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(190, 12);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(99, 20);
			this.textBox1.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 14);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(180, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tıklanacak Yerin Koordinatları (X, Y):";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 16);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(83, 29);
			this.button1.TabIndex = 3;
			this.button1.Text = "Başlat";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Location = new System.Drawing.Point(6, 206);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(290, 51);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Clicker Beklemede";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(204, 16);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(83, 29);
			this.button2.TabIndex = 4;
			this.button2.Text = "Durdur";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.richTextBox1);
			this.groupBox4.Location = new System.Drawing.Point(6, 261);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox4.Size = new System.Drawing.Size(290, 147);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Log";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(3, 16);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(286, 130);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// timer3
			// 
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(305, 414);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "TrainingPass";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.RichTextBox richTextBox1;
	}
}

