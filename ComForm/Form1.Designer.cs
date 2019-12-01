namespace ComForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSerialPortswitch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboStopBits = new System.Windows.Forms.ComboBox();
            this.comboparity = new System.Windows.Forms.ComboBox();
            this.comboDataBits = new System.Windows.Forms.ComboBox();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.comboPortNames = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearContent = new System.Windows.Forms.Button();
            this.checkShowReTime = new System.Windows.Forms.CheckBox();
            this.radioReHEX = new System.Windows.Forms.RadioButton();
            this.radioReASCII = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBoxRe = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numSdInvertal = new System.Windows.Forms.NumericUpDown();
            this.checkAutoSd = new System.Windows.Forms.CheckBox();
            this.radioSdASCII = new System.Windows.Forms.RadioButton();
            this.checkNewLine = new System.Windows.Forms.CheckBox();
            this.radioSdHEX = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtBoxSd = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRevice = new System.Windows.Forms.Label();
            this.lblSend = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSdInvertal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSerialPortswitch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboStopBits);
            this.panel1.Controls.Add(this.comboparity);
            this.panel1.Controls.Add(this.comboDataBits);
            this.panel1.Controls.Add(this.comboBaudRate);
            this.panel1.Controls.Add(this.comboPortNames);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 258);
            this.panel1.TabIndex = 0;
            // 
            // btnSerialPortswitch
            // 
            this.btnSerialPortswitch.BackColor = System.Drawing.Color.Green;
            this.btnSerialPortswitch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSerialPortswitch.Location = new System.Drawing.Point(7, 188);
            this.btnSerialPortswitch.Name = "btnSerialPortswitch";
            this.btnSerialPortswitch.Size = new System.Drawing.Size(166, 34);
            this.btnSerialPortswitch.TabIndex = 2;
            this.btnSerialPortswitch.Text = "打开串口";
            this.btnSerialPortswitch.UseVisualStyleBackColor = false;
            this.btnSerialPortswitch.Click += new System.EventHandler(this.BtnSerialPortswitch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(2, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "校验位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "串   口";
            // 
            // comboStopBits
            // 
            this.comboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStopBits.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboStopBits.FormattingEnabled = true;
            this.comboStopBits.Location = new System.Drawing.Point(63, 150);
            this.comboStopBits.Name = "comboStopBits";
            this.comboStopBits.Size = new System.Drawing.Size(109, 29);
            this.comboStopBits.TabIndex = 0;
            this.comboStopBits.SelectedIndexChanged += new System.EventHandler(this.ComboStopBits_SelectedIndexChanged);
            // 
            // comboparity
            // 
            this.comboparity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboparity.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboparity.FormattingEnabled = true;
            this.comboparity.Location = new System.Drawing.Point(63, 113);
            this.comboparity.Name = "comboparity";
            this.comboparity.Size = new System.Drawing.Size(109, 29);
            this.comboparity.TabIndex = 0;
            this.comboparity.SelectedIndexChanged += new System.EventHandler(this.Comboparity_SelectedIndexChanged);
            // 
            // comboDataBits
            // 
            this.comboDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDataBits.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboDataBits.FormattingEnabled = true;
            this.comboDataBits.Location = new System.Drawing.Point(63, 76);
            this.comboDataBits.Name = "comboDataBits";
            this.comboDataBits.Size = new System.Drawing.Size(109, 29);
            this.comboDataBits.TabIndex = 0;
            this.comboDataBits.SelectedIndexChanged += new System.EventHandler(this.ComboDataBits_SelectedIndexChanged);
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaudRate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBaudRate.FormattingEnabled = true;
            this.comboBaudRate.Location = new System.Drawing.Point(64, 39);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(109, 29);
            this.comboBaudRate.TabIndex = 0;
            this.comboBaudRate.SelectedIndexChanged += new System.EventHandler(this.ComboBaudRate_SelectedIndexChanged);
            // 
            // comboPortNames
            // 
            this.comboPortNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPortNames.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboPortNames.FormattingEnabled = true;
            this.comboPortNames.Location = new System.Drawing.Point(63, 2);
            this.comboPortNames.Name = "comboPortNames";
            this.comboPortNames.Size = new System.Drawing.Size(109, 29);
            this.comboPortNames.TabIndex = 0;
            this.comboPortNames.SelectedIndexChanged += new System.EventHandler(this.ComboPortNames_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnClearContent);
            this.panel2.Controls.Add(this.checkShowReTime);
            this.panel2.Controls.Add(this.radioReHEX);
            this.panel2.Controls.Add(this.radioReASCII);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 119);
            this.panel2.TabIndex = 1;
            // 
            // btnClearContent
            // 
            this.btnClearContent.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearContent.Location = new System.Drawing.Point(8, 75);
            this.btnClearContent.Name = "btnClearContent";
            this.btnClearContent.Size = new System.Drawing.Size(158, 32);
            this.btnClearContent.TabIndex = 2;
            this.btnClearContent.Text = "清空接收";
            this.btnClearContent.UseVisualStyleBackColor = true;
            this.btnClearContent.Click += new System.EventHandler(this.BtnClearContent_Click);
            // 
            // checkShowReTime
            // 
            this.checkShowReTime.AutoSize = true;
            this.checkShowReTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkShowReTime.Location = new System.Drawing.Point(9, 44);
            this.checkShowReTime.Name = "checkShowReTime";
            this.checkShowReTime.Size = new System.Drawing.Size(157, 25);
            this.checkShowReTime.TabIndex = 1;
            this.checkShowReTime.Text = "显示接收数据时间";
            this.checkShowReTime.UseVisualStyleBackColor = true;
            // 
            // radioReHEX
            // 
            this.radioReHEX.AutoSize = true;
            this.radioReHEX.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioReHEX.Location = new System.Drawing.Point(115, 13);
            this.radioReHEX.Name = "radioReHEX";
            this.radioReHEX.Size = new System.Drawing.Size(59, 25);
            this.radioReHEX.TabIndex = 0;
            this.radioReHEX.TabStop = true;
            this.radioReHEX.Text = "HEX";
            this.radioReHEX.UseVisualStyleBackColor = true;
            this.radioReHEX.CheckedChanged += new System.EventHandler(this.RadioRe_CheckedChanged);
            // 
            // radioReASCII
            // 
            this.radioReASCII.AutoSize = true;
            this.radioReASCII.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioReASCII.Location = new System.Drawing.Point(9, 13);
            this.radioReASCII.Name = "radioReASCII";
            this.radioReASCII.Size = new System.Drawing.Size(69, 25);
            this.radioReASCII.TabIndex = 0;
            this.radioReASCII.TabStop = true;
            this.radioReASCII.Text = "ASCII";
            this.radioReASCII.UseVisualStyleBackColor = true;
            this.radioReASCII.CheckedChanged += new System.EventHandler(this.RadioRe_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtBoxRe);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(202, 3);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel1.SetRowSpan(this.panel4, 2);
            this.panel4.Size = new System.Drawing.Size(591, 383);
            this.panel4.TabIndex = 3;
            // 
            // txtBoxRe
            // 
            this.txtBoxRe.AllowDrop = true;
            this.txtBoxRe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxRe.Location = new System.Drawing.Point(0, 0);
            this.txtBoxRe.Multiline = true;
            this.txtBoxRe.Name = "txtBoxRe";
            this.txtBoxRe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxRe.Size = new System.Drawing.Size(587, 379);
            this.txtBoxRe.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.numSdInvertal);
            this.panel3.Controls.Add(this.checkAutoSd);
            this.panel3.Controls.Add(this.radioSdASCII);
            this.panel3.Controls.Add(this.checkNewLine);
            this.panel3.Controls.Add(this.radioSdHEX);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 85);
            this.panel3.TabIndex = 4;
            // 
            // numSdInvertal
            // 
            this.numSdInvertal.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSdInvertal.Location = new System.Drawing.Point(106, 57);
            this.numSdInvertal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSdInvertal.Name = "numSdInvertal";
            this.numSdInvertal.Size = new System.Drawing.Size(80, 21);
            this.numSdInvertal.TabIndex = 3;
            this.numSdInvertal.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSdInvertal.ValueChanged += new System.EventHandler(this.NumSdInvertal_ValueChanged);
            // 
            // checkAutoSd
            // 
            this.checkAutoSd.AutoSize = true;
            this.checkAutoSd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkAutoSd.Location = new System.Drawing.Point(7, 54);
            this.checkAutoSd.Name = "checkAutoSd";
            this.checkAutoSd.Size = new System.Drawing.Size(93, 25);
            this.checkAutoSd.TabIndex = 2;
            this.checkAutoSd.Text = "自动发送";
            this.checkAutoSd.UseVisualStyleBackColor = true;
            this.checkAutoSd.CheckedChanged += new System.EventHandler(this.CheckAutoSd_CheckedChanged);
            // 
            // radioSdASCII
            // 
            this.radioSdASCII.AutoSize = true;
            this.radioSdASCII.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioSdASCII.Location = new System.Drawing.Point(9, 3);
            this.radioSdASCII.Name = "radioSdASCII";
            this.radioSdASCII.Size = new System.Drawing.Size(69, 25);
            this.radioSdASCII.TabIndex = 0;
            this.radioSdASCII.TabStop = true;
            this.radioSdASCII.Text = "ASCII";
            this.radioSdASCII.UseVisualStyleBackColor = true;
            this.radioSdASCII.CheckedChanged += new System.EventHandler(this.RadioSd_CheckedChanged);
            // 
            // checkNewLine
            // 
            this.checkNewLine.AutoSize = true;
            this.checkNewLine.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkNewLine.Location = new System.Drawing.Point(7, 29);
            this.checkNewLine.Name = "checkNewLine";
            this.checkNewLine.Size = new System.Drawing.Size(93, 25);
            this.checkNewLine.TabIndex = 1;
            this.checkNewLine.Text = "发送新行";
            this.checkNewLine.UseVisualStyleBackColor = true;
            this.checkNewLine.CheckedChanged += new System.EventHandler(this.CheckNewLine_CheckedChanged);
            // 
            // radioSdHEX
            // 
            this.radioSdHEX.AutoSize = true;
            this.radioSdHEX.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioSdHEX.Location = new System.Drawing.Point(115, 3);
            this.radioSdHEX.Name = "radioSdHEX";
            this.radioSdHEX.Size = new System.Drawing.Size(59, 25);
            this.radioSdHEX.TabIndex = 0;
            this.radioSdHEX.TabStop = true;
            this.radioSdHEX.Text = "HEX";
            this.radioSdHEX.UseVisualStyleBackColor = true;
            this.radioSdHEX.CheckedChanged += new System.EventHandler(this.RadioSd_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(202, 392);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxSd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Size = new System.Drawing.Size(591, 85);
            this.splitContainer1.SplitterDistance = 491;
            this.splitContainer1.TabIndex = 5;
            // 
            // txtBoxSd
            // 
            this.txtBoxSd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxSd.Location = new System.Drawing.Point(0, 0);
            this.txtBoxSd.Multiline = true;
            this.txtBoxSd.Name = "txtBoxSd";
            this.txtBoxSd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxSd.Size = new System.Drawing.Size(487, 81);
            this.txtBoxSd.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 81);
            this.button3.TabIndex = 0;
            this.button3.Text = "发送";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.lblRevice);
            this.panel5.Controls.Add(this.lblSend);
            this.panel5.Controls.Add(this.lblStatus);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 483);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(790, 25);
            this.panel5.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(734, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "v0.01";
            // 
            // lblRevice
            // 
            this.lblRevice.AutoSize = true;
            this.lblRevice.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRevice.Location = new System.Drawing.Point(294, 0);
            this.lblRevice.Name = "lblRevice";
            this.lblRevice.Size = new System.Drawing.Size(72, 19);
            this.lblRevice.TabIndex = 0;
            this.lblRevice.Text = "Rx: 0Bytes";
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSend.Location = new System.Drawing.Point(181, 0);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(71, 19);
            this.lblSend.TabIndex = 0;
            this.lblSend.Text = "Tx: 0Bytes";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.Location = new System.Drawing.Point(5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 19);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "串口已关闭";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "协同串口调试助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSdInvertal)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPortNames;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboStopBits;
        private System.Windows.Forms.ComboBox comboparity;
        private System.Windows.Forms.ComboBox comboDataBits;
        private System.Windows.Forms.ComboBox comboBaudRate;
        private System.Windows.Forms.Button btnSerialPortswitch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkShowReTime;
        private System.Windows.Forms.RadioButton radioReHEX;
        private System.Windows.Forms.RadioButton radioReASCII;
        private System.Windows.Forms.Button btnClearContent;
        private System.Windows.Forms.TextBox txtBoxRe;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBoxSd;
        private System.Windows.Forms.RadioButton radioSdASCII;
        private System.Windows.Forms.CheckBox checkNewLine;
        private System.Windows.Forms.RadioButton radioSdHEX;
        private System.Windows.Forms.NumericUpDown numSdInvertal;
        private System.Windows.Forms.CheckBox checkAutoSd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRevice;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
    }
}

