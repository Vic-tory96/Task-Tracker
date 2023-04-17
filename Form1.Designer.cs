namespace UserInterface
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
            groupBox1 = new GroupBox();
            txtSearchBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmdCancelTask = new Button();
            cmdDeleteTask = new Button();
            cmdUpdateTask = new Button();
            cmdCreateTask = new Button();
            cboStatus = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtTask = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(txtSearchBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmdCancelTask);
            groupBox1.Controls.Add(cmdDeleteTask);
            groupBox1.Controls.Add(cmdUpdateTask);
            groupBox1.Controls.Add(cmdCreateTask);
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtTask);
            groupBox1.ForeColor = SystemColors.WindowText;
            groupBox1.Location = new Point(13, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(776, 176);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task";
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(93, 113);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(289, 31);
            txtSearchBox.TabIndex = 10;
            txtSearchBox.Text = "Search...";
            txtSearchBox.TextChanged += txtSearchBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 40);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 9;
            label3.Text = "Due Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 8;
            label2.Text = "Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 7;
            label1.Text = "Task:";
            // 
            // cmdCancelTask
            // 
            cmdCancelTask.Location = new Point(623, 74);
            cmdCancelTask.Margin = new Padding(4, 3, 4, 3);
            cmdCancelTask.Name = "cmdCancelTask";
            cmdCancelTask.Size = new Size(113, 33);
            cmdCancelTask.TabIndex = 6;
            cmdCancelTask.Text = "Cancel";
            cmdCancelTask.UseVisualStyleBackColor = true;
            cmdCancelTask.Click += cmdCancelTask_Click;
            // 
            // cmdDeleteTask
            // 
            cmdDeleteTask.Location = new Point(502, 71);
            cmdDeleteTask.Margin = new Padding(4, 3, 4, 3);
            cmdDeleteTask.Name = "cmdDeleteTask";
            cmdDeleteTask.Size = new Size(113, 33);
            cmdDeleteTask.TabIndex = 5;
            cmdDeleteTask.Text = "Delete";
            cmdDeleteTask.UseVisualStyleBackColor = true;
            cmdDeleteTask.Click += cmdDeleteTask_Click;
            // 
            // cmdUpdateTask
            // 
            cmdUpdateTask.Location = new Point(384, 70);
            cmdUpdateTask.Margin = new Padding(4, 3, 4, 3);
            cmdUpdateTask.Name = "cmdUpdateTask";
            cmdUpdateTask.Size = new Size(113, 33);
            cmdUpdateTask.TabIndex = 4;
            cmdUpdateTask.Text = "Update";
            cmdUpdateTask.UseVisualStyleBackColor = true;
            cmdUpdateTask.Click += cmdUpdateTask_Click;
            // 
            // cmdCreateTask
            // 
            cmdCreateTask.BackColor = SystemColors.ControlLightLight;
            cmdCreateTask.Location = new Point(265, 71);
            cmdCreateTask.Margin = new Padding(4, 3, 4, 3);
            cmdCreateTask.Name = "cmdCreateTask";
            cmdCreateTask.Size = new Size(113, 33);
            cmdCreateTask.TabIndex = 3;
            cmdCreateTask.Text = "Create";
            cmdCreateTask.UseVisualStyleBackColor = false;
            cmdCreateTask.Click += cmdCreateTask_Click;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(93, 71);
            cboStatus.Margin = new Padding(4, 3, 4, 3);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(168, 33);
            cboStatus.TabIndex = 2;
            cboStatus.Text = "Please Select...";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(527, 35);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(93, 33);
            txtTask.Margin = new Padding(4, 3, 4, 3);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(289, 31);
            txtTask.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 200);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(776, 237);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Light", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(822, 506);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Todo List";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button cmdCancelTask;
        private Button cmdDeleteTask;
        private Button cmdUpdateTask;
        private Button cmdCreateTask;
        private ComboBox cboStatus;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTask;
        private DataGridView dataGridView1;
        private TextBox txtSearchBox;
    }
}