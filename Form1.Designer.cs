namespace Гороскоп
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
            components = new System.ComponentModel.Container();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            denSegodna = new Label();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(578, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(520, 85);
            label1.Name = "label1";
            label1.Size = new Size(258, 20);
            label1.TabIndex = 2;
            label1.Text = "Укажите дату своего дня рождения:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 3;
            label2.Text = "Настоящее время:\r\n";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // denSegodna
            // 
            denSegodna.AutoSize = true;
            denSegodna.BackColor = Color.Transparent;
            denSegodna.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            denSegodna.ForeColor = Color.Cyan;
            denSegodna.Location = new Point(12, 50);
            denSegodna.Name = "denSegodna";
            denSegodna.Size = new Size(0, 20);
            denSegodna.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 108);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(472, 330);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(504, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 252);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1920x1080;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(denSegodna);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label denSegodna;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
    }
}
