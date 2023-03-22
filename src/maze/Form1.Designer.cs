using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace maze
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
            dataGridView1 = new DataGridView();
            buttonVisualize = new Button();
            panel1 = new Panel();
            labelInput = new Label();
            splitContainer1 = new SplitContainer();
            checkProgress = new CheckBox();
            labelLoadSuccess = new Label();
            trackProgress = new TrackBar();
            labelOutput = new Label();
            title = new Label();
            checkTSP = new CheckBox();
            dfsButton = new RadioButton();
            bfsButton = new RadioButton();
            buttonBrowse = new Button();
            textBoxFileName = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            button_start = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackProgress).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(81, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(328, 329);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonVisualize
            // 
            buttonVisualize.Anchor = AnchorStyles.Bottom;
            buttonVisualize.Location = new Point(102, 405);
            buttonVisualize.Name = "buttonVisualize";
            buttonVisualize.Size = new Size(100, 34);
            buttonVisualize.TabIndex = 1;
            buttonVisualize.Text = "Visualize";
            buttonVisualize.UseVisualStyleBackColor = true;
            buttonVisualize.Click += visualizeMap;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(487, 355);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // labelInput
            // 
            labelInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelInput.AutoSize = true;
            labelInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelInput.Location = new Point(12, 104);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(37, 15);
            labelInput.TabIndex = 1;
            labelInput.Text = "Input";
            labelInput.Click += label1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(checkProgress);
            splitContainer1.Panel1.Controls.Add(labelLoadSuccess);
            splitContainer1.Panel1.Controls.Add(trackProgress);
            splitContainer1.Panel1.Controls.Add(labelOutput);
            splitContainer1.Panel1.Controls.Add(title);
            splitContainer1.Panel1.Controls.Add(buttonVisualize);
            splitContainer1.Panel1.Controls.Add(checkTSP);
            splitContainer1.Panel1.Controls.Add(dfsButton);
            splitContainer1.Panel1.Controls.Add(bfsButton);
            splitContainer1.Panel1.Controls.Add(buttonBrowse);
            splitContainer1.Panel1.Controls.Add(textBoxFileName);
            splitContainer1.Panel1.Controls.Add(labelInput);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint_1;
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button_start);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.Panel2MinSize = 350;
            splitContainer1.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(800, 451);
            splitContainer1.SplitterDistance = 306;
            splitContainer1.TabIndex = 3;
            // 
            // checkProgress
            // 
            checkProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkProgress.AutoSize = true;
            checkProgress.Location = new Point(11, 241);
            checkProgress.Name = "checkProgress";
            checkProgress.Size = new Size(91, 19);
            checkProgress.TabIndex = 11;
            checkProgress.Text = "Progress Bar";
            checkProgress.UseVisualStyleBackColor = true;
            checkProgress.CheckedChanged += switchTrackEnable;
            // 
            // labelLoadSuccess
            // 
            labelLoadSuccess.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLoadSuccess.AutoSize = true;
            labelLoadSuccess.ForeColor = Color.Green;
            labelLoadSuccess.Location = new Point(105, 387);
            labelLoadSuccess.Name = "labelLoadSuccess";
            labelLoadSuccess.Size = new Size(93, 15);
            labelLoadSuccess.TabIndex = 9;
            labelLoadSuccess.Text = "Load successfull";
            labelLoadSuccess.Click += label3_Click_1;
            // 
            // trackProgress
            // 
            trackProgress.Enabled = false;
            trackProgress.Location = new Point(12, 266);
            trackProgress.Name = "trackProgress";
            trackProgress.Size = new Size(288, 45);
            trackProgress.TabIndex = 10;
            trackProgress.TickStyle = TickStyle.Both;
            // 
            // labelOutput
            // 
            labelOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelOutput.Location = new Point(12, 148);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(47, 15);
            labelOutput.TabIndex = 8;
            labelOutput.Text = "Output";
            labelOutput.Click += label3_Click;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            title.Font = new Font("Jack Pirate PERSONAL USE ONLY", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = Color.Black;
            title.Location = new Point(26, 9);
            title.Name = "title";
            title.Size = new Size(257, 95);
            title.TabIndex = 7;
            title.Text = "Krusty's Treasure Hunt";
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Click += label2_Click;
            // 
            // checkTSP
            // 
            checkTSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkTSP.AutoSize = true;
            checkTSP.Location = new Point(12, 216);
            checkTSP.Name = "checkTSP";
            checkTSP.Size = new Size(45, 19);
            checkTSP.TabIndex = 3;
            checkTSP.Text = "TSP";
            checkTSP.UseVisualStyleBackColor = true;
            // 
            // dfsButton
            // 
            dfsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dfsButton.AutoSize = true;
            dfsButton.Location = new Point(12, 191);
            dfsButton.Name = "dfsButton";
            dfsButton.Size = new Size(44, 19);
            dfsButton.TabIndex = 6;
            dfsButton.TabStop = true;
            dfsButton.Text = "BFS";
            dfsButton.UseVisualStyleBackColor = true;
            dfsButton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // bfsButton
            // 
            bfsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bfsButton.AutoSize = true;
            bfsButton.Location = new Point(12, 166);
            bfsButton.Name = "bfsButton";
            bfsButton.Size = new Size(45, 19);
            bfsButton.TabIndex = 5;
            bfsButton.TabStop = true;
            bfsButton.Text = "DFS";
            bfsButton.UseVisualStyleBackColor = true;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBrowse.Location = new Point(243, 122);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(57, 23);
            buttonBrowse.TabIndex = 4;
            buttonBrowse.Text = "browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += button2_Click;
            // 
            // textBoxFileName
            // 
            textBoxFileName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFileName.ForeColor = Color.Gray;
            textBoxFileName.Location = new Point(12, 122);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(225, 23);
            textBoxFileName.TabIndex = 3;
            textBoxFileName.Text = "e.g : \"text.txt\"";
            textBoxFileName.TextChanged += textBox1_TextChanged;
            textBoxFileName.GotFocus += RemoveText;
            textBoxFileName.LostFocus += AddText;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button_start.Anchor = AnchorStyles.Bottom;
            button_start.Location = new Point(206, 361);
            button_start.Name = "button1";
            button_start.Size = new Size(75, 23);
            button_start.TabIndex = 3;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Krusty's Treasure Hunt";
            Load += Form1_Load;
            ResizeEnd += resizeCell;
            Resize += resizeCell;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackProgress).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonVisualize;
        public Panel panel1;
        private Label labelInput;
        private SplitContainer splitContainer1;
        private Button buttonBrowse;
        private TextBox textBoxFileName;
        private RadioButton dfsButton;
        private RadioButton bfsButton;
        private CheckBox checkTSP;
        private Label title;
        private OpenFileDialog openFileDialog1;
        private Label labelOutput;
        private Label labelLoadSuccess;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkProgress;
        private TrackBar trackProgress;
        private Solver solver;
        private bool isLoaded;
        private const string emptyInputString = "e.g : \"text.txt\"";
        private string projectRoot;
        private Button button_start;
    }
}