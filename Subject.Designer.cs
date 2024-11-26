namespace MySchoolManagementSystem
{
    partial class Subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subject));
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            panel1.Size = new Size(988, 66);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(360, 19);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 0;
            label1.Text = "Subject";
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
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(957, 317);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Subject Information";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(456, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 264);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.FromArgb(255, 128, 128);
            btnDisplay.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplay.Location = new Point(272, 230);
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
            btnNew.Location = new Point(141, 230);
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
            btnDelete.Location = new Point(10, 230);
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
            btnUpdate.Location = new Point(272, 161);
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
            btnAdd.Location = new Point(141, 161);
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
            btnSave.Location = new Point(10, 161);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 63);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 27);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 98);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 1;
            label3.Text = "SubjectName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 53);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "SubjectId";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 405);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(957, 245);
            dataGridView1.TabIndex = 3;
            // 
            // Subject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 662);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Subject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subject";
            Load += Subject_Load;
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
        private PictureBox pictureBox1;
        private Button btnDisplay;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSave;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
    }
}