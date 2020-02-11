namespace BackPropagationNeuralNetwork
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Select_Data = new System.Windows.Forms.Button();
            this.Inputbu = new System.Windows.Forms.Button();
            this.filename_txt = new System.Windows.Forms.TextBox();
            this.data_txt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.num_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HidLong_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.alpha_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eta_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.times_txt = new System.Windows.Forms.TextBox();
            this.Learn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.hidcount_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Learn_databu = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.insertlearn_txt = new System.Windows.Forms.TextBox();
            this.Drawbu = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.outlearn_txt = new System.Windows.Forms.TextBox();
            this.outpulearn_bu = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Revise_txt = new System.Windows.Forms.TextBox();
            this.Revise_bu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.chat1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BatchIn_Bu = new System.Windows.Forms.Button();
            this.BatchRe_Bu = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chat1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(320, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(149, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Learn_Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(149, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 290);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deviation";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(320, 264);
            this.dataGridView2.TabIndex = 0;
            // 
            // Select_Data
            // 
            this.Select_Data.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Select_Data.Location = new System.Drawing.Point(12, 12);
            this.Select_Data.Name = "Select_Data";
            this.Select_Data.Size = new System.Drawing.Size(121, 37);
            this.Select_Data.TabIndex = 5;
            this.Select_Data.Text = "Select_Data";
            this.Select_Data.UseVisualStyleBackColor = true;
            this.Select_Data.Click += new System.EventHandler(this.Select_Data_Click);
            // 
            // Inputbu
            // 
            this.Inputbu.Enabled = false;
            this.Inputbu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Inputbu.Location = new System.Drawing.Point(6, 451);
            this.Inputbu.Name = "Inputbu";
            this.Inputbu.Size = new System.Drawing.Size(65, 37);
            this.Inputbu.TabIndex = 7;
            this.Inputbu.Text = "Input";
            this.Inputbu.UseVisualStyleBackColor = true;
            this.Inputbu.Click += new System.EventHandler(this.button1_Click);
            // 
            // filename_txt
            // 
            this.filename_txt.Location = new System.Drawing.Point(68, 57);
            this.filename_txt.Name = "filename_txt";
            this.filename_txt.Size = new System.Drawing.Size(65, 22);
            this.filename_txt.TabIndex = 8;
            // 
            // data_txt
            // 
            this.data_txt.Location = new System.Drawing.Point(50, 494);
            this.data_txt.Name = "data_txt";
            this.data_txt.Size = new System.Drawing.Size(89, 22);
            this.data_txt.TabIndex = 9;
            this.data_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_txt_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(149, 617);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 87);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 23);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(320, 61);
            this.dataGridView3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fild Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "num";
            // 
            // num_txt
            // 
            this.num_txt.Location = new System.Drawing.Point(68, 358);
            this.num_txt.Name = "num_txt";
            this.num_txt.Size = new System.Drawing.Size(65, 22);
            this.num_txt.TabIndex = 33;
            this.num_txt.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Hid Long";
            // 
            // HidLong_txt
            // 
            this.HidLong_txt.Location = new System.Drawing.Point(68, 302);
            this.HidLong_txt.Name = "HidLong_txt";
            this.HidLong_txt.Size = new System.Drawing.Size(65, 22);
            this.HidLong_txt.TabIndex = 31;
            this.HidLong_txt.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "alpha";
            // 
            // alpha_txt
            // 
            this.alpha_txt.Location = new System.Drawing.Point(68, 275);
            this.alpha_txt.Name = "alpha_txt";
            this.alpha_txt.Size = new System.Drawing.Size(65, 22);
            this.alpha_txt.TabIndex = 29;
            this.alpha_txt.Text = "0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "eta";
            // 
            // eta_txt
            // 
            this.eta_txt.Location = new System.Drawing.Point(68, 248);
            this.eta_txt.Name = "eta_txt";
            this.eta_txt.Size = new System.Drawing.Size(65, 22);
            this.eta_txt.TabIndex = 27;
            this.eta_txt.Text = "0.5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "Times";
            // 
            // times_txt
            // 
            this.times_txt.Location = new System.Drawing.Point(68, 220);
            this.times_txt.Name = "times_txt";
            this.times_txt.Size = new System.Drawing.Size(65, 22);
            this.times_txt.TabIndex = 25;
            this.times_txt.Text = "10000";
            // 
            // Learn
            // 
            this.Learn.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Learn.Location = new System.Drawing.Point(12, 155);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(121, 36);
            this.Learn.TabIndex = 24;
            this.Learn.Text = "Learn";
            this.Learn.UseVisualStyleBackColor = true;
            this.Learn.Click += new System.EventHandler(this.Learn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Hid count";
            // 
            // hidcount_txt
            // 
            this.hidcount_txt.Location = new System.Drawing.Point(68, 330);
            this.hidcount_txt.Name = "hidcount_txt";
            this.hidcount_txt.Size = new System.Drawing.Size(65, 22);
            this.hidcount_txt.TabIndex = 35;
            this.hidcount_txt.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "data";
            // 
            // Learn_databu
            // 
            this.Learn_databu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Learn_databu.Location = new System.Drawing.Point(12, 85);
            this.Learn_databu.Name = "Learn_databu";
            this.Learn_databu.Size = new System.Drawing.Size(121, 36);
            this.Learn_databu.TabIndex = 38;
            this.Learn_databu.Text = "Learn_Data";
            this.Learn_databu.UseVisualStyleBackColor = true;
            this.Learn_databu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "Fild Name";
            // 
            // insertlearn_txt
            // 
            this.insertlearn_txt.Location = new System.Drawing.Point(68, 125);
            this.insertlearn_txt.Name = "insertlearn_txt";
            this.insertlearn_txt.Size = new System.Drawing.Size(65, 22);
            this.insertlearn_txt.TabIndex = 39;
            // 
            // Drawbu
            // 
            this.Drawbu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Drawbu.Location = new System.Drawing.Point(78, 451);
            this.Drawbu.Name = "Drawbu";
            this.Drawbu.Size = new System.Drawing.Size(65, 37);
            this.Drawbu.TabIndex = 44;
            this.Drawbu.Text = "Draw";
            this.Drawbu.UseVisualStyleBackColor = true;
            this.Drawbu.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(28, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 22);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "Clear Data";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "Name";
            // 
            // outlearn_txt
            // 
            this.outlearn_txt.Location = new System.Drawing.Point(55, 423);
            this.outlearn_txt.Name = "outlearn_txt";
            this.outlearn_txt.Size = new System.Drawing.Size(78, 22);
            this.outlearn_txt.TabIndex = 47;
            // 
            // outpulearn_bu
            // 
            this.outpulearn_bu.Enabled = false;
            this.outpulearn_bu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outpulearn_bu.Location = new System.Drawing.Point(12, 386);
            this.outpulearn_bu.Name = "outpulearn_bu";
            this.outpulearn_bu.Size = new System.Drawing.Size(121, 31);
            this.outpulearn_bu.TabIndex = 46;
            this.outpulearn_bu.Text = "Output Learn";
            this.outpulearn_bu.UseVisualStyleBackColor = true;
            this.outpulearn_bu.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 572);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 51;
            this.label11.Text = "Ans";
            // 
            // Revise_txt
            // 
            this.Revise_txt.Location = new System.Drawing.Point(46, 565);
            this.Revise_txt.Name = "Revise_txt";
            this.Revise_txt.Size = new System.Drawing.Size(89, 22);
            this.Revise_txt.TabIndex = 50;
            // 
            // Revise_bu
            // 
            this.Revise_bu.Enabled = false;
            this.Revise_bu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Revise_bu.Location = new System.Drawing.Point(12, 522);
            this.Revise_bu.Name = "Revise_bu";
            this.Revise_bu.Size = new System.Drawing.Size(121, 37);
            this.Revise_bu.TabIndex = 52;
            this.Revise_bu.Text = "Revise";
            this.Revise_bu.UseVisualStyleBackColor = true;
            this.Revise_bu.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(261, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 53;
            this.button1.Text = "Output_Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(481, 680);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(655, 23);
            this.progressBar1.TabIndex = 54;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1142, 680);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 24);
            this.button2.TabIndex = 55;
            this.button2.Text = "Stop Learning";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1165, 652);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 18);
            this.label12.TabIndex = 56;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // chat1
            // 
            chartArea3.Name = "ChartArea1";
            this.chat1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chat1.Legends.Add(legend3);
            this.chat1.Location = new System.Drawing.Point(481, 20);
            this.chat1.Name = "chat1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chat1.Series.Add(series3);
            this.chat1.Size = new System.Drawing.Size(789, 683);
            this.chat1.TabIndex = 4;
            this.chat1.Text = "chart1";
            this.chat1.Click += new System.EventHandler(this.chat1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1204, 639);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 12);
            this.label13.TabIndex = 57;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox2.Location = new System.Drawing.Point(152, 18);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 20);
            this.checkBox2.TabIndex = 58;
            this.checkBox2.Text = "同步顯示";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(1203, 593);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 18);
            this.label14.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(427, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 61;
            // 
            // BatchIn_Bu
            // 
            this.BatchIn_Bu.Enabled = false;
            this.BatchIn_Bu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BatchIn_Bu.Location = new System.Drawing.Point(14, 594);
            this.BatchIn_Bu.Name = "BatchIn_Bu";
            this.BatchIn_Bu.Size = new System.Drawing.Size(121, 37);
            this.BatchIn_Bu.TabIndex = 62;
            this.BatchIn_Bu.Text = "Batch Input";
            this.BatchIn_Bu.UseVisualStyleBackColor = true;
            this.BatchIn_Bu.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // BatchRe_Bu
            // 
            this.BatchRe_Bu.Enabled = false;
            this.BatchRe_Bu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BatchRe_Bu.Location = new System.Drawing.Point(12, 663);
            this.BatchRe_Bu.Name = "BatchRe_Bu";
            this.BatchRe_Bu.Size = new System.Drawing.Size(121, 37);
            this.BatchRe_Bu.TabIndex = 63;
            this.BatchRe_Bu.Text = "Batch Revise";
            this.BatchRe_Bu.UseVisualStyleBackColor = true;
            this.BatchRe_Bu.Click += new System.EventHandler(this.BatchRe_Bu_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(69, 640);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 16);
            this.label16.TabIndex = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 712);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BatchRe_Bu);
            this.Controls.Add(this.BatchIn_Bu);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Revise_bu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Revise_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.outlearn_txt);
            this.Controls.Add(this.outpulearn_bu);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Drawbu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.insertlearn_txt);
            this.Controls.Add(this.Learn_databu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hidcount_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.num_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HidLong_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alpha_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eta_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.times_txt);
            this.Controls.Add(this.Learn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.data_txt);
            this.Controls.Add(this.filename_txt);
            this.Controls.Add(this.Inputbu);
            this.Controls.Add(this.Select_Data);
            this.Controls.Add(this.chat1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BackPropagationNeuralNetwork";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chat1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Select_Data;
        private System.Windows.Forms.Button Inputbu;
        private System.Windows.Forms.TextBox filename_txt;
        private System.Windows.Forms.TextBox data_txt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox num_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HidLong_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox alpha_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eta_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox times_txt;
        private System.Windows.Forms.Button Learn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hidcount_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Learn_databu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox insertlearn_txt;
        private System.Windows.Forms.Button Drawbu;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox outlearn_txt;
        private System.Windows.Forms.Button outpulearn_bu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Revise_txt;
        private System.Windows.Forms.Button Revise_bu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chat1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BatchIn_Bu;
        private System.Windows.Forms.Button BatchRe_Bu;
        private System.Windows.Forms.Label label16;
    }
}

