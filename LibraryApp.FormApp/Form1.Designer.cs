namespace LibraryApp.FormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 364);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(685, 223);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(703, 232);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 1;
            button1.Text = "Kitapları Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(703, 273);
            button2.Name = "button2";
            button2.Size = new Size(172, 35);
            button2.TabIndex = 1;
            button2.Text = "Yazar Adına Göre";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(703, 314);
            button3.Name = "button3";
            button3.Size = new Size(172, 35);
            button3.TabIndex = 1;
            button3.Text = "Kategoriye Göre";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(703, 487);
            button4.Name = "button4";
            button4.Size = new Size(172, 35);
            button4.TabIndex = 1;
            button4.Text = "Son 10 Kitap";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(703, 528);
            button5.Name = "button5";
            button5.Size = new Size(172, 35);
            button5.TabIndex = 1;
            button5.Text = "Stok Kontrol";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(703, 405);
            button6.Name = "button6";
            button6.Size = new Size(172, 35);
            button6.TabIndex = 1;
            button6.Text = "Tarihe Göre Sırala";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(703, 446);
            button7.Name = "button7";
            button7.Size = new Size(172, 35);
            button7.TabIndex = 1;
            button7.Text = "Fiyata Göre Sırala";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(881, 405);
            button8.Name = "button8";
            button8.Size = new Size(172, 35);
            button8.TabIndex = 1;
            button8.Text = "İndirim Oranları";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(881, 487);
            button9.Name = "button9";
            button9.Size = new Size(172, 35);
            button9.TabIndex = 1;
            button9.Text = "button1";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(881, 528);
            button10.Name = "button10";
            button10.Size = new Size(172, 35);
            button10.TabIndex = 1;
            button10.Text = "button1";
            button10.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(703, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 599);
            Controls.Add(textBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox textBox1;
    }
}