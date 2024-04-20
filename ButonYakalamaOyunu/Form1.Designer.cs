namespace ButonYakalamaOyunu
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(248, 209);
            button1.Name = "button1";
            button1.Size = new Size(222, 77);
            button1.TabIndex = 0;
            button1.Text = "Beni Yakala";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseMove += button1_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(391, 16);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 1;
            label1.Text = "Toplam Puanınız : 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(9, 13);
            label2.Name = "label2";
            label2.Size = new Size(195, 23);
            label2.TabIndex = 2;
            label2.Text = "Lütfen İsminizi Giriniz :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(78, 320);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(607, 453);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximumSize = new Size(625, 500);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}
