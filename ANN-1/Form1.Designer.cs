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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea28 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend28 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea29 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend29 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series49 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea30 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend30 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series50 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chat1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chat1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(481, 315);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(224, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(489, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Train Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(224, 699);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(489, 226);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 34);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(481, 188);
            this.dataGridView2.TabIndex = 0;
            // 
            // Select_Data
            // 
            this.Select_Data.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Select_Data.Location = new System.Drawing.Point(18, 18);
            this.Select_Data.Margin = new System.Windows.Forms.Padding(4);
            this.Select_Data.Name = "Select_Data";
            this.Select_Data.Size = new System.Drawing.Size(182, 56);
            this.Select_Data.TabIndex = 5;
            this.Select_Data.Text = "Select Data";
            this.Select_Data.UseVisualStyleBackColor = true;
            this.Select_Data.Click += new System.EventHandler(this.Select_Data_Click);
            // 
            // Inputbu
            // 
            this.Inputbu.Enabled = false;
            this.Inputbu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Inputbu.Location = new System.Drawing.Point(6, 825);
            this.Inputbu.Margin = new System.Windows.Forms.Padding(4);
            this.Inputbu.Name = "Inputbu";
            this.Inputbu.Size = new System.Drawing.Size(98, 56);
            this.Inputbu.TabIndex = 7;
            this.Inputbu.Text = "Input";
            this.Inputbu.UseVisualStyleBackColor = true;
            this.Inputbu.Click += new System.EventHandler(this.button1_Click);
            // 
            // filename_txt
            // 
            this.filename_txt.Location = new System.Drawing.Point(102, 86);
            this.filename_txt.Margin = new System.Windows.Forms.Padding(4);
            this.filename_txt.Name = "filename_txt";
            this.filename_txt.Size = new System.Drawing.Size(96, 29);
            this.filename_txt.TabIndex = 8;
            // 
            // data_txt
            // 
            this.data_txt.Location = new System.Drawing.Point(72, 890);
            this.data_txt.Margin = new System.Windows.Forms.Padding(4);
            this.data_txt.Name = "data_txt";
            this.data_txt.Size = new System.Drawing.Size(132, 29);
            this.data_txt.TabIndex = 9;
            this.data_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_txt_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(224, 922);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(489, 115);
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
            this.dataGridView3.Location = new System.Drawing.Point(4, 34);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(481, 77);
            this.dataGridView3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "File Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 545);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Norm";
            // 
            // num_txt
            // 
            this.num_txt.Location = new System.Drawing.Point(102, 537);
            this.num_txt.Margin = new System.Windows.Forms.Padding(4);
            this.num_txt.Name = "num_txt";
            this.num_txt.Size = new System.Drawing.Size(96, 29);
            this.num_txt.TabIndex = 33;
            this.num_txt.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 460);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Hid Layer";
            // 
            // HidLong_txt
            // 
            this.HidLong_txt.Location = new System.Drawing.Point(102, 453);
            this.HidLong_txt.Margin = new System.Windows.Forms.Padding(4);
            this.HidLong_txt.Name = "HidLong_txt";
            this.HidLong_txt.Size = new System.Drawing.Size(96, 29);
            this.HidLong_txt.TabIndex = 31;
            this.HidLong_txt.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 416);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "alpha";
            // 
            // alpha_txt
            // 
            this.alpha_txt.Location = new System.Drawing.Point(102, 412);
            this.alpha_txt.Margin = new System.Windows.Forms.Padding(4);
            this.alpha_txt.Name = "alpha_txt";
            this.alpha_txt.Size = new System.Drawing.Size(96, 29);
            this.alpha_txt.TabIndex = 29;
            this.alpha_txt.Text = "0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 380);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "LR";
            // 
            // eta_txt
            // 
            this.eta_txt.Location = new System.Drawing.Point(102, 372);
            this.eta_txt.Margin = new System.Windows.Forms.Padding(4);
            this.eta_txt.Name = "eta_txt";
            this.eta_txt.Size = new System.Drawing.Size(96, 29);
            this.eta_txt.TabIndex = 27;
            this.eta_txt.Text = "0.5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Times";
            // 
            // times_txt
            // 
            this.times_txt.Location = new System.Drawing.Point(102, 330);
            this.times_txt.Margin = new System.Windows.Forms.Padding(4);
            this.times_txt.Name = "times_txt";
            this.times_txt.Size = new System.Drawing.Size(96, 29);
            this.times_txt.TabIndex = 25;
            this.times_txt.Text = "100";
            // 
            // Learn
            // 
            this.Learn.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Learn.Location = new System.Drawing.Point(18, 232);
            this.Learn.Margin = new System.Windows.Forms.Padding(4);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(182, 54);
            this.Learn.TabIndex = 24;
            this.Learn.Text = "Learn";
            this.Learn.UseVisualStyleBackColor = true;
            this.Learn.Click += new System.EventHandler(this.Learn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 501);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "Hid num";
            // 
            // hidcount_txt
            // 
            this.hidcount_txt.Location = new System.Drawing.Point(102, 495);
            this.hidcount_txt.Margin = new System.Windows.Forms.Padding(4);
            this.hidcount_txt.Name = "hidcount_txt";
            this.hidcount_txt.Size = new System.Drawing.Size(96, 29);
            this.hidcount_txt.TabIndex = 35;
            this.hidcount_txt.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 898);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "data";
            // 
            // Learn_databu
            // 
            this.Learn_databu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Learn_databu.Location = new System.Drawing.Point(18, 128);
            this.Learn_databu.Margin = new System.Windows.Forms.Padding(4);
            this.Learn_databu.Name = "Learn_databu";
            this.Learn_databu.Size = new System.Drawing.Size(182, 54);
            this.Learn_databu.TabIndex = 38;
            this.Learn_databu.Text = "Load Parameters";
            this.Learn_databu.UseVisualStyleBackColor = true;
            this.Learn_databu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 196);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 40;
            this.label9.Text = "File Name";
            // 
            // insertlearn_txt
            // 
            this.insertlearn_txt.Location = new System.Drawing.Point(102, 188);
            this.insertlearn_txt.Margin = new System.Windows.Forms.Padding(4);
            this.insertlearn_txt.Name = "insertlearn_txt";
            this.insertlearn_txt.Size = new System.Drawing.Size(96, 29);
            this.insertlearn_txt.TabIndex = 39;
            // 
            // Drawbu
            // 
            this.Drawbu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Drawbu.Location = new System.Drawing.Point(114, 825);
            this.Drawbu.Margin = new System.Windows.Forms.Padding(4);
            this.Drawbu.Name = "Drawbu";
            this.Drawbu.Size = new System.Drawing.Size(98, 56);
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
            this.checkBox1.Location = new System.Drawing.Point(20, 291);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 31);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "Reset Network";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 790);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 48;
            this.label10.Text = "Name";
            // 
            // outlearn_txt
            // 
            this.outlearn_txt.Location = new System.Drawing.Point(82, 779);
            this.outlearn_txt.Margin = new System.Windows.Forms.Padding(4);
            this.outlearn_txt.Name = "outlearn_txt";
            this.outlearn_txt.Size = new System.Drawing.Size(115, 29);
            this.outlearn_txt.TabIndex = 47;
            // 
            // outpulearn_bu
            // 
            this.outpulearn_bu.Enabled = false;
            this.outpulearn_bu.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outpulearn_bu.Location = new System.Drawing.Point(18, 724);
            this.outpulearn_bu.Margin = new System.Windows.Forms.Padding(4);
            this.outpulearn_bu.Name = "outpulearn_bu";
            this.outpulearn_bu.Size = new System.Drawing.Size(182, 47);
            this.outpulearn_bu.TabIndex = 46;
            this.outpulearn_bu.Text = "Save Parameters";
            this.outpulearn_bu.UseVisualStyleBackColor = true;
            this.outpulearn_bu.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 1006);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 21);
            this.label11.TabIndex = 51;
            this.label11.Text = "Corroct Ans";
            // 
            // Revise_txt
            // 
            this.Revise_txt.Location = new System.Drawing.Point(117, 1000);
            this.Revise_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Revise_txt.Name = "Revise_txt";
            this.Revise_txt.Size = new System.Drawing.Size(85, 29);
            this.Revise_txt.TabIndex = 50;
            this.Revise_txt.TextChanged += new System.EventHandler(this.Revise_txt_TextChanged);
            // 
            // Revise_bu
            // 
            this.Revise_bu.Enabled = false;
            this.Revise_bu.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Revise_bu.Location = new System.Drawing.Point(17, 927);
            this.Revise_bu.Margin = new System.Windows.Forms.Padding(4);
            this.Revise_bu.Name = "Revise_bu";
            this.Revise_bu.Size = new System.Drawing.Size(182, 56);
            this.Revise_bu.TabIndex = 52;
            this.Revise_bu.Text = "Add Data";
            this.Revise_bu.UseVisualStyleBackColor = true;
            this.Revise_bu.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(392, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 51);
            this.button1.TabIndex = 53;
            this.button1.Text = "Output Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(719, 994);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1028, 34);
            this.progressBar1.TabIndex = 54;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1755, 994);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 36);
            this.button2.TabIndex = 55;
            this.button2.Text = "Stop Learning";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // chat1
            // 
            chartArea28.Name = "ChartArea1";
            this.chat1.ChartAreas.Add(chartArea28);
            legend28.Name = "Legend1";
            this.chat1.Legends.Add(legend28);
            this.chat1.Location = new System.Drawing.Point(721, 475);
            this.chat1.Margin = new System.Windows.Forms.Padding(4);
            this.chat1.Name = "chat1";
            series46.ChartArea = "ChartArea1";
            series46.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series46.Legend = "Legend1";
            series46.Name = "Series1";
            series47.ChartArea = "ChartArea1";
            series47.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series47.Legend = "Legend1";
            series47.Name = "Series3";
            this.chat1.Series.Add(series46);
            this.chat1.Series.Add(series47);
            this.chat1.Size = new System.Drawing.Size(630, 500);
            this.chat1.TabIndex = 20;
            this.chat1.Text = "chart1";
            this.chat1.Click += new System.EventHandler(this.chat1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox2.Location = new System.Drawing.Point(228, 27);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 27);
            this.checkBox2.TabIndex = 58;
            this.checkBox2.Text = "同步顯示";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(640, 56);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 25);
            this.label15.TabIndex = 61;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView4);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(224, 416);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(489, 275);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Val Data";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(4, 34);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(481, 237);
            this.dataGridView4.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(384, 3);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 25);
            this.label17.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1752, 937);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 18);
            this.label13.TabIndex = 60;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1750, 869);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 18);
            this.label14.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1565, 901);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 18);
            this.label12.TabIndex = 60;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // chart1
            // 
            chartArea29.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea29);
            legend29.Name = "Legend1";
            this.chart1.Legends.Add(legend29);
            this.chart1.Location = new System.Drawing.Point(1359, 475);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series48.ChartArea = "ChartArea1";
            series48.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series48.Legend = "Legend1";
            series48.Name = "Series1";
            series49.ChartArea = "ChartArea1";
            series49.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series49.Legend = "Legend1";
            series49.Name = "Series2";
            this.chart1.Series.Add(series48);
            this.chart1.Series.Add(series49);
            this.chart1.Size = new System.Drawing.Size(551, 500);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(721, 71);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(400, 397);
            this.textBox2.TabIndex = 69;
            // 
            // chart2
            // 
            chartArea30.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea30);
            legend30.Name = "Legend1";
            this.chart2.Legends.Add(legend30);
            this.chart2.Location = new System.Drawing.Point(1128, 56);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series50.ChartArea = "ChartArea1";
            series50.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series50.Legend = "Legend1";
            series50.Name = "Series1";
            this.chart2.Series.Add(series50);
            this.chart2.Size = new System.Drawing.Size(782, 411);
            this.chart2.TabIndex = 70;
            this.chart2.Text = "chart2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 587);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 29);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "0.00001";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1, 582);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 42);
            this.label16.TabIndex = 34;
            this.label16.Text = "Gradient \r\nlower bound";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1050);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
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
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.data_txt);
            this.Controls.Add(this.filename_txt);
            this.Controls.Add(this.Inputbu);
            this.Controls.Add(this.Select_Data);
            this.Controls.Add(this.chat1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chat1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
    }
}

