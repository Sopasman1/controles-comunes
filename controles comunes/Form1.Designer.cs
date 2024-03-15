namespace controles_comunes
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "hola", "", "" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "bueeenas", "", "" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TreeNode treeNode1 = new TreeNode("Nodo1");
            TreeNode treeNode2 = new TreeNode("suwender", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("espadones", new TreeNode[] { treeNode2 });
            TreeNode treeNode4 = new TreeNode("Nodo4");
            TreeNode treeNode5 = new TreeNode("Nodo3", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Nodo2", new TreeNode[] { treeNode5 });
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            lista = new ListView();
            maskedTextBox1 = new MaskedTextBox();
            monthCalendar1 = new MonthCalendar();
            notifyIcon1 = new NotifyIcon(components);
            numericUpDown1 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            treeView1 = new TreeView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 12);
            button1.Name = "button1";
            button1.Size = new Size(115, 40);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Naruto", "Dragon ball", "Bleach", "Berserk", "Vinlansaga ", "Vagabond", "The climber" });
            checkedListBox1.Location = new Point(144, 15);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(128, 58);
            checkedListBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "kanie west", "tyler the creator", "mf doom", "kendrik lamar" });
            comboBox1.Location = new Point(278, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "hola";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(425, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(23, 68);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(69, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "video chido";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 45);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 5;
            label1.Text = "HOLA MUNDO";
            // 
            // lista
            // 
            lista.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lista.Location = new Point(651, 12);
            lista.Name = "lista";
            lista.Size = new Size(137, 93);
            lista.TabIndex = 6;
            toolTip1.SetToolTip(lista, "hola");
            lista.UseCompatibleStateImageBehavior = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(447, 50);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(183, 23);
            maskedTextBox1.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 92);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(447, 82);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(164, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(553, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 266);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(226, 76);
            progressBar1.TabIndex = 11;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 358);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 395);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(278, 122);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(258, 72);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "solo soy un simple terrenal que sueña con quererte\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 358);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 67);
            textBox1.TabIndex = 15;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(278, 200);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Nodo1";
            treeNode2.Name = "espadon de humo";
            treeNode2.Text = "suwender";
            treeNode3.Name = "espadones";
            treeNode3.Text = "espadones";
            treeNode4.Name = "desmontadora";
            treeNode4.Text = "Nodo4";
            treeNode5.Name = "espada ancha";
            treeNode5.Text = "Nodo3";
            treeNode6.Name = "espadas curvas";
            treeNode6.Text = "Nodo2";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode6 });
            treeView1.Size = new Size(177, 142);
            treeView1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(monthCalendar1);
            Controls.Add(maskedTextBox1);
            Controls.Add(lista);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private LinkLabel linkLabel1;
        private Label label1;
        private ListView lista;
        private MaskedTextBox maskedTextBox1;
        private MonthCalendar monthCalendar1;
        private NotifyIcon notifyIcon1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private ToolTip toolTip1;
        private TreeView treeView1;
    }
}
