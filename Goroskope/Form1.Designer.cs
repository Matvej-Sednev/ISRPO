
namespace Goroskope
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.buttonAnalysis = new System.Windows.Forms.Button();
            this.labelDateBirth = new System.Windows.Forms.Label();
            this.labelTodayIs = new System.Windows.Forms.Label();
            this.pictureBoxImageZodiac = new System.Windows.Forms.PictureBox();
            this.label_Loading = new System.Windows.Forms.Label();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.labelDateToday = new System.Windows.Forms.Label();
            this.labelZodiac = new System.Windows.Forms.Label();
            this.pictureBoxImageChineseZodiac = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageElement = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageSeason = new System.Windows.Forms.PictureBox();
            this.labelChineseZodiac = new System.Windows.Forms.Label();
            this.labelElement = new System.Windows.Forms.Label();
            this.labelSeason = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCharacteristic = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chorte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateBirth2 = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fiz = new System.Windows.Forms.CheckBox();
            this.emoc = new System.Windows.Forms.CheckBox();
            this.smart = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nedela = new System.Windows.Forms.RadioButton();
            this.mesach = new System.Windows.Forms.RadioButton();
            this.period = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageZodiac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageChineseZodiac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSeason)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chorte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateBirth
            // 
            this.dateBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirth.CalendarForeColor = System.Drawing.Color.Aqua;
            this.dateBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dateBirth.CalendarTitleBackColor = System.Drawing.Color.Green;
            this.dateBirth.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.dateBirth.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirth.Location = new System.Drawing.Point(958, 19);
            this.dateBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dateBirth.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateBirth.Size = new System.Drawing.Size(176, 26);
            this.dateBirth.TabIndex = 1;
            this.dateBirth.Value = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateBirth.ValueChanged += new System.EventHandler(this.dateBirth_ValueChanged);
            // 
            // buttonAnalysis
            // 
            this.buttonAnalysis.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonAnalysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAnalysis.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.buttonAnalysis.FlatAppearance.BorderSize = 3;
            this.buttonAnalysis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.buttonAnalysis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.buttonAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalysis.ForeColor = System.Drawing.Color.SlateBlue;
            this.buttonAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnalysis.Location = new System.Drawing.Point(958, 52);
            this.buttonAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnalysis.Name = "buttonAnalysis";
            this.buttonAnalysis.Size = new System.Drawing.Size(176, 77);
            this.buttonAnalysis.TabIndex = 3;
            this.buttonAnalysis.Text = "Анализ";
            this.buttonAnalysis.UseVisualStyleBackColor = false;
            this.buttonAnalysis.Click += new System.EventHandler(this.buttonAnalysis_Click);
            // 
            // labelDateBirth
            // 
            this.labelDateBirth.AutoSize = true;
            this.labelDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateBirth.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelDateBirth.Location = new System.Drawing.Point(643, 19);
            this.labelDateBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateBirth.Name = "labelDateBirth";
            this.labelDateBirth.Size = new System.Drawing.Size(286, 26);
            this.labelDateBirth.TabIndex = 4;
            this.labelDateBirth.Text = "Укажите дату рождения:";
            // 
            // labelTodayIs
            // 
            this.labelTodayIs.AutoSize = true;
            this.labelTodayIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTodayIs.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelTodayIs.Location = new System.Drawing.Point(17, 22);
            this.labelTodayIs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTodayIs.Name = "labelTodayIs";
            this.labelTodayIs.Size = new System.Drawing.Size(172, 26);
            this.labelTodayIs.TabIndex = 0;
            this.labelTodayIs.Text = "Текущая дата:";
            // 
            // pictureBoxImageZodiac
            // 
            this.pictureBoxImageZodiac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImageZodiac.Location = new System.Drawing.Point(820, 200);
            this.pictureBoxImageZodiac.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxImageZodiac.Name = "pictureBoxImageZodiac";
            this.pictureBoxImageZodiac.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImageZodiac.TabIndex = 6;
            this.pictureBoxImageZodiac.TabStop = false;
            // 
            // label_Loading
            // 
            this.label_Loading.Location = new System.Drawing.Point(0, 0);
            this.label_Loading.Name = "label_Loading";
            this.label_Loading.Size = new System.Drawing.Size(100, 23);
            this.label_Loading.TabIndex = 17;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // labelDateToday
            // 
            this.labelDateToday.AutoSize = true;
            this.labelDateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateToday.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelDateToday.Location = new System.Drawing.Point(197, 22);
            this.labelDateToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateToday.Name = "labelDateToday";
            this.labelDateToday.Size = new System.Drawing.Size(0, 26);
            this.labelDateToday.TabIndex = 9;
            // 
            // labelZodiac
            // 
            this.labelZodiac.AutoSize = true;
            this.labelZodiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZodiac.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelZodiac.Location = new System.Drawing.Point(816, 177);
            this.labelZodiac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZodiac.Name = "labelZodiac";
            this.labelZodiac.Size = new System.Drawing.Size(149, 17);
            this.labelZodiac.TabIndex = 10;
            this.labelZodiac.Text = "Ваш знак зодиака:";
            // 
            // pictureBoxImageChineseZodiac
            // 
            this.pictureBoxImageChineseZodiac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImageChineseZodiac.Location = new System.Drawing.Point(1044, 200);
            this.pictureBoxImageChineseZodiac.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxImageChineseZodiac.Name = "pictureBoxImageChineseZodiac";
            this.pictureBoxImageChineseZodiac.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImageChineseZodiac.TabIndex = 11;
            this.pictureBoxImageChineseZodiac.TabStop = false;
            // 
            // pictureBoxImageElement
            // 
            this.pictureBoxImageElement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImageElement.Location = new System.Drawing.Point(820, 385);
            this.pictureBoxImageElement.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxImageElement.Name = "pictureBoxImageElement";
            this.pictureBoxImageElement.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImageElement.TabIndex = 12;
            this.pictureBoxImageElement.TabStop = false;
            // 
            // pictureBoxImageSeason
            // 
            this.pictureBoxImageSeason.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImageSeason.Location = new System.Drawing.Point(1044, 385);
            this.pictureBoxImageSeason.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxImageSeason.Name = "pictureBoxImageSeason";
            this.pictureBoxImageSeason.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImageSeason.TabIndex = 13;
            this.pictureBoxImageSeason.TabStop = false;
            // 
            // labelChineseZodiac
            // 
            this.labelChineseZodiac.AutoSize = true;
            this.labelChineseZodiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChineseZodiac.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelChineseZodiac.Location = new System.Drawing.Point(1015, 170);
            this.labelChineseZodiac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChineseZodiac.Name = "labelChineseZodiac";
            this.labelChineseZodiac.Size = new System.Drawing.Size(231, 17);
            this.labelChineseZodiac.TabIndex = 14;
            this.labelChineseZodiac.Text = "Ваш китайский знак зодиака:";
            // 
            // labelElement
            // 
            this.labelElement.AutoSize = true;
            this.labelElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElement.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelElement.Location = new System.Drawing.Point(816, 362);
            this.labelElement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelElement.Name = "labelElement";
            this.labelElement.Size = new System.Drawing.Size(108, 17);
            this.labelElement.TabIndex = 15;
            this.labelElement.Text = "Ваша стихия:";
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeason.ForeColor = System.Drawing.Color.NavajoWhite;
            this.labelSeason.Location = new System.Drawing.Point(1040, 362);
            this.labelSeason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(170, 17);
            this.labelSeason.TabIndex = 16;
            this.labelSeason.Text = "Ваш сезон рождения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(187, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 18;
            // 
            // textBoxCharacteristic
            // 
            this.textBoxCharacteristic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxCharacteristic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCharacteristic.Enabled = false;
            this.textBoxCharacteristic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCharacteristic.ForeColor = System.Drawing.Color.DarkViolet;
            this.textBoxCharacteristic.Location = new System.Drawing.Point(7, 52);
            this.textBoxCharacteristic.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCharacteristic.Multiline = true;
            this.textBoxCharacteristic.Name = "textBoxCharacteristic";
            this.textBoxCharacteristic.Size = new System.Drawing.Size(799, 663);
            this.textBoxCharacteristic.TabIndex = 5;
            this.textBoxCharacteristic.TextChanged += new System.EventHandler(this.textBoxCharacteristic_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1253, 741);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxCharacteristic);
            this.tabPage1.Controls.Add(this.labelSeason);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelTodayIs);
            this.tabPage1.Controls.Add(this.pictureBoxImageElement);
            this.tabPage1.Controls.Add(this.labelChineseZodiac);
            this.tabPage1.Controls.Add(this.labelElement);
            this.tabPage1.Controls.Add(this.labelDateToday);
            this.tabPage1.Controls.Add(this.pictureBoxImageSeason);
            this.tabPage1.Controls.Add(this.buttonAnalysis);
            this.tabPage1.Controls.Add(this.dateBirth);
            this.tabPage1.Controls.Add(this.pictureBoxImageChineseZodiac);
            this.tabPage1.Controls.Add(this.labelZodiac);
            this.tabPage1.Controls.Add(this.labelDateBirth);
            this.tabPage1.Controls.Add(this.pictureBoxImageZodiac);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1245, 708);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ГОРОСКОП";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.checkBox5);
            this.tabPage2.Controls.Add(this.checkBox4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.smart);
            this.tabPage2.Controls.Add(this.emoc);
            this.tabPage2.Controls.Add(this.fiz);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Label2);
            this.tabPage2.Controls.Add(this.dateBirth2);
            this.tabPage2.Controls.Add(this.chorte);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1245, 708);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "БИОРИТМЫ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chorte
            // 
            chartArea1.Name = "ChartArea1";
            this.chorte.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chorte.Legends.Add(legend1);
            this.chorte.Location = new System.Drawing.Point(0, 0);
            this.chorte.Name = "chorte";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chorte.Series.Add(series1);
            this.chorte.Size = new System.Drawing.Size(608, 708);
            this.chorte.TabIndex = 0;
            this.chorte.Text = "chart1";
            // 
            // dateBirth2
            // 
            this.dateBirth2.Location = new System.Drawing.Point(1022, 6);
            this.dateBirth2.Name = "dateBirth2";
            this.dateBirth2.Size = new System.Drawing.Size(200, 26);
            this.dateBirth2.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(614, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(128, 20);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Дата рождения";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(955, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 78);
            this.button1.TabIndex = 4;
            this.button1.Text = "показать биоритмы сделать анализ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fiz
            // 
            this.fiz.AutoSize = true;
            this.fiz.Location = new System.Drawing.Point(955, 57);
            this.fiz.Name = "fiz";
            this.fiz.Size = new System.Drawing.Size(120, 24);
            this.fiz.TabIndex = 5;
            this.fiz.Text = "Физ. состав";
            this.fiz.UseVisualStyleBackColor = true;
            // 
            // emoc
            // 
            this.emoc.AutoSize = true;
            this.emoc.Location = new System.Drawing.Point(955, 88);
            this.emoc.Name = "emoc";
            this.emoc.Size = new System.Drawing.Size(129, 24);
            this.emoc.TabIndex = 6;
            this.emoc.Text = "Эмоц. состав";
            this.emoc.UseVisualStyleBackColor = true;
            // 
            // smart
            // 
            this.smart.AutoSize = true;
            this.smart.Location = new System.Drawing.Point(955, 119);
            this.smart.Name = "smart";
            this.smart.Size = new System.Drawing.Size(162, 24);
            this.smart.TabIndex = 7;
            this.smart.Text = "Интелект. состав";
            this.smart.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.period);
            this.groupBox1.Controls.Add(this.mesach);
            this.groupBox1.Controls.Add(this.nedela);
            this.groupBox1.Location = new System.Drawing.Point(618, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 217);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "период";
            // 
            // nedela
            // 
            this.nedela.AutoSize = true;
            this.nedela.Location = new System.Drawing.Point(16, 31);
            this.nedela.Name = "nedela";
            this.nedela.Size = new System.Drawing.Size(84, 24);
            this.nedela.TabIndex = 0;
            this.nedela.TabStop = true;
            this.nedela.Text = "неделя";
            this.nedela.UseVisualStyleBackColor = true;
            // 
            // mesach
            // 
            this.mesach.AutoSize = true;
            this.mesach.Location = new System.Drawing.Point(16, 62);
            this.mesach.Name = "mesach";
            this.mesach.Size = new System.Drawing.Size(73, 24);
            this.mesach.TabIndex = 1;
            this.mesach.TabStop = true;
            this.mesach.Text = "месяц";
            this.mesach.UseVisualStyleBackColor = true;
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Location = new System.Drawing.Point(16, 93);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(145, 24);
            this.period.TabIndex = 2;
            this.period.TabStop = true;
            this.period.Text = "период в датах";
            this.period.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "От:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "До:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(62, 139);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(62, 171);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker3.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(618, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 78);
            this.button2.TabIndex = 9;
            this.button2.Text = "показать биоритмы сделать анализ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(955, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 78);
            this.button3.TabIndex = 10;
            this.button3.Text = "показать биоритмы сделать анализ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(618, 637);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(167, 24);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Показать легенду";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(618, 667);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(49, 24);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "3D";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(618, 279);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(604, 252);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1256, 754);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_Loading);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гороскоп";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageZodiac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageChineseZodiac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageSeason)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chorte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Button buttonAnalysis;
        private System.Windows.Forms.Label labelDateBirth;
        private System.Windows.Forms.Label labelTodayIs;
        private System.Windows.Forms.PictureBox pictureBoxImageZodiac;
        private System.Windows.Forms.Label label_Loading;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Label labelDateToday;
        private System.Windows.Forms.Label labelZodiac;
        private System.Windows.Forms.PictureBox pictureBoxImageChineseZodiac;
        private System.Windows.Forms.PictureBox pictureBoxImageElement;
        private System.Windows.Forms.PictureBox pictureBoxImageSeason;
        private System.Windows.Forms.Label labelChineseZodiac;
        private System.Windows.Forms.Label labelElement;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCharacteristic;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chorte;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton period;
        private System.Windows.Forms.RadioButton mesach;
        private System.Windows.Forms.RadioButton nedela;
        private System.Windows.Forms.CheckBox smart;
        private System.Windows.Forms.CheckBox emoc;
        private System.Windows.Forms.CheckBox fiz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DateTimePicker dateBirth2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

