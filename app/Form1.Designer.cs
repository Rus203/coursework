namespace app
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.matrixSize = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewX = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewL = new System.Windows.Forms.DataGridView();
            this.dataGridViewU = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewU)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.AllowUserToAddRows = false;
            this.dataGridViewA.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewA.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewA.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewA.Location = new System.Drawing.Point(25, 67);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.RowHeadersVisible = false;
            this.dataGridViewA.RowHeadersWidth = 34;
            this.dataGridViewA.RowTemplate.Height = 33;
            this.dataGridViewA.Size = new System.Drawing.Size(434, 282);
            this.dataGridViewA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(238, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Решение СЛАУ методом LU-разложения";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(26, 29);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(112, 34);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btn_solve_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(26, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // matrixSize
            // 
            this.matrixSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matrixSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.matrixSize.FormattingEnabled = true;
            this.matrixSize.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.matrixSize.Location = new System.Drawing.Point(39, 160);
            this.matrixSize.Name = "matrixSize";
            this.matrixSize.Size = new System.Drawing.Size(61, 33);
            this.matrixSize.TabIndex = 4;
            this.matrixSize.SelectedIndexChanged += new System.EventHandler(this.matrixSize_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(173, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Count of the variables";
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AllowUserToAddRows = false;
            this.dataGridViewB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewB.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.ColumnHeadersVisible = false;
            this.dataGridViewB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewB.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewB.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewB.Location = new System.Drawing.Point(462, 67);
            this.dataGridViewB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.RowHeadersVisible = false;
            this.dataGridViewB.RowHeadersWidth = 34;
            this.dataGridViewB.RowTemplate.Height = 33;
            this.dataGridViewB.Size = new System.Drawing.Size(150, 282);
            this.dataGridViewB.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(226, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "matrix A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(483, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "matrix B";
            // 
            // dataGridViewX
            // 
            this.dataGridViewX.AllowUserToAddRows = false;
            this.dataGridViewX.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX.ColumnHeadersVisible = false;
            this.dataGridViewX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewX.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewX.Location = new System.Drawing.Point(616, 67);
            this.dataGridViewX.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewX.Name = "dataGridViewX";
            this.dataGridViewX.ReadOnly = true;
            this.dataGridViewX.RowHeadersVisible = false;
            this.dataGridViewX.RowHeadersWidth = 34;
            this.dataGridViewX.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewX.RowTemplate.Height = 33;
            this.dataGridViewX.Size = new System.Drawing.Size(150, 282);
            this.dataGridViewX.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(632, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "matrix X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSolve);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.matrixSize);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Location = new System.Drawing.Point(808, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 224);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewL
            // 
            this.dataGridViewL.AllowUserToAddRows = false;
            this.dataGridViewL.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewL.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewL.ColumnHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewL.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewL.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewL.Location = new System.Drawing.Point(25, 67);
            this.dataGridViewL.Name = "dataGridViewL";
            this.dataGridViewL.ReadOnly = true;
            this.dataGridViewL.RowHeadersVisible = false;
            this.dataGridViewL.RowHeadersWidth = 34;
            this.dataGridViewL.RowTemplate.Height = 33;
            this.dataGridViewL.Size = new System.Drawing.Size(434, 282);
            this.dataGridViewL.TabIndex = 13;
            // 
            // dataGridViewU
            // 
            this.dataGridViewU.AllowUserToAddRows = false;
            this.dataGridViewU.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewU.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewU.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewU.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewU.ColumnHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewU.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewU.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewU.Location = new System.Drawing.Point(462, 67);
            this.dataGridViewU.Name = "dataGridViewU";
            this.dataGridViewU.ReadOnly = true;
            this.dataGridViewU.RowHeadersVisible = false;
            this.dataGridViewU.RowHeadersWidth = 34;
            this.dataGridViewU.RowTemplate.Height = 33;
            this.dataGridViewU.Size = new System.Drawing.Size(434, 282);
            this.dataGridViewU.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(193, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "matrix L";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridViewA);
            this.groupBox2.Controls.Add(this.dataGridViewB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataGridViewX);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 365);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(660, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "matrix U";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dataGridViewL);
            this.groupBox3.Controls.Add(this.dataGridViewU);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 371);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.SystemColors.Control;
            this.labelError.Location = new System.Drawing.Point(817, 339);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(357, 38);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "text";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1186, 848);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewU)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewA;
        private Button btnSolve;
        private Button btnClear;
        private ComboBox matrixRows;
        private Button btnSave;
        private ComboBox matrixColumns;
        private Label label2;
        private Label label3;
        private DataGridView dataGridViewB;
        private DataGridViewTextBoxColumn Column1;
        private ComboBox matrixSize;
        private DataGridViewTextBoxColumn Column2;
        private Label label4;
        private Label label5;
        private DataGridView dataGridViewX;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private GroupBox groupBox1;
        private DataGridView dataGridViewL;
        private DataGridView dataGridViewU;
        private Label label6;
        private GroupBox groupBox2;
        private Label label7;
        private GroupBox groupBox3;
        private Label labelError;
    }
}