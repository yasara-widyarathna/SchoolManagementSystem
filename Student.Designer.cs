namespace MySchoolManagementSystem
{
    partial class Student
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnDisplay = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 192);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(360, 19);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnDisplay);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(965, 421);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.student_image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(494, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 264);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.FromArgb(255, 128, 128);
            btnDisplay.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplay.Location = new Point(717, 340);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(125, 63);
            btnDisplay.TabIndex = 17;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(255, 128, 128);
            btnNew.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(586, 340);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(125, 63);
            btnNew.TabIndex = 16;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(455, 340);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 63);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 128, 128);
            btnUpdate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(324, 340);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 63);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 128, 128);
            btnAdd.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(193, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 63);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 128, 128);
            btnSave.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(62, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 63);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(199, 140);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(269, 27);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(199, 283);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(248, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(199, 234);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(248, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 290);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 5;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 241);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 4;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 190);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 3;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 147);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 2;
            label4.Text = "Dob";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 98);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 1;
            label3.Text = "StudentName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 53);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "StudentId";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 510);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(965, 220);
            dataGridView1.TabIndex = 2;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 742);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            Load += Student_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private Button btnDisplay;
        private Button btnNew;
        private Button btnDelete;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
    }
}