using System.Data.Common;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            buttonVisualize = new Button();
            panel1 = new Panel();
            labelInput = new Label();
            splitContainer1 = new SplitContainer();
            label_progress = new Label();
            progressBar1 = new ProgressBar();
            label_interval = new Label();
            checkProgress = new CheckBox();
            labelLoadSuccess = new Label();
            trackProgress = new TrackBar();
            labelAlgorithm = new Label();
            title = new Label();
            checkTSP = new CheckBox();
            dfsButton = new RadioButton();
            bfsButton = new RadioButton();
            buttonBrowse = new Button();
            textBoxFileName = new TextBox();
            textBox_exec_time = new TextBox();
            textBox_steps = new TextBox();
            textBox_nodes = new TextBox();
            textBox_route = new TextBox();
            label_exec_ime = new Label();
            label_step = new Label();
            label_nodes = new Label();
            label_route = new Label();
            button_start = new Button();
            openFileDialog1 = new OpenFileDialog();
            timerLoadDialogue = new System.Windows.Forms.Timer(components);
            backgroundWorkerColoring = new System.ComponentModel.BackgroundWorker();
            helpProvider1 = new HelpProvider();
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
            dataGridView1.BackgroundColor = Color.CadetBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(81, 11);
            dataGridView1.MinimumSize = new Size(326, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(326, 357);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // buttonVisualize
            // 
            buttonVisualize.Anchor = AnchorStyles.Bottom;
            buttonVisualize.BackColor = Color.LightBlue;
            buttonVisualize.Cursor = Cursors.Hand;
            buttonVisualize.Location = new Point(101, 463);
            buttonVisualize.Name = "buttonVisualize";
            buttonVisualize.Size = new Size(100, 34);
            buttonVisualize.TabIndex = 1;
            buttonVisualize.Text = "Visualize";
            buttonVisualize.UseVisualStyleBackColor = false;
            buttonVisualize.Click += visualizeMap;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.CadetBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(485, 383);
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
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label_progress);
            splitContainer1.Panel1.Controls.Add(progressBar1);
            splitContainer1.Panel1.Controls.Add(label_interval);
            splitContainer1.Panel1.Controls.Add(checkProgress);
            splitContainer1.Panel1.Controls.Add(labelLoadSuccess);
            splitContainer1.Panel1.Controls.Add(trackProgress);
            splitContainer1.Panel1.Controls.Add(labelAlgorithm);
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
            splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBox_exec_time);
            splitContainer1.Panel2.Controls.Add(textBox_steps);
            splitContainer1.Panel2.Controls.Add(textBox_nodes);
            splitContainer1.Panel2.Controls.Add(textBox_route);
            splitContainer1.Panel2.Controls.Add(label_exec_ime);
            splitContainer1.Panel2.Controls.Add(label_step);
            splitContainer1.Panel2.Controls.Add(label_nodes);
            splitContainer1.Panel2.Controls.Add(label_route);
            splitContainer1.Panel2.Controls.Add(button_start);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.Panel2MinSize = 450;
            splitContainer1.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(800, 511);
            splitContainer1.SplitterDistance = 306;
            splitContainer1.TabIndex = 3;
            // 
            // label_progress
            // 
            label_progress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_progress.ForeColor = SystemColors.ControlText;
            label_progress.Location = new Point(11, 329);
            label_progress.Name = "label_progress";
            label_progress.Size = new Size(204, 19);
            label_progress.TabIndex = 13;
            label_progress.Text = "Progress";
            label_progress.TextAlign = ContentAlignment.MiddleLeft;
            label_progress.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.ForeColor = SystemColors.GradientInactiveCaption;
            progressBar1.Location = new Point(11, 351);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(285, 23);
            progressBar1.TabIndex = 12;
            progressBar1.Visible = false;
            // 
            // label_interval
            // 
            label_interval.Enabled = false;
            label_interval.Location = new Point(12, 263);
            label_interval.Name = "label_interval";
            label_interval.Size = new Size(100, 15);
            label_interval.TabIndex = 12;
            label_interval.Text = "Interval : 100 ms";
            label_interval.Click += label1_Click_1;
            // 
            // checkProgress
            // 
            checkProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkProgress.AutoSize = true;
            checkProgress.Cursor = Cursors.Hand;
            checkProgress.Location = new Point(13, 241);
            checkProgress.Name = "checkProgress";
            checkProgress.Size = new Size(103, 19);
            checkProgress.TabIndex = 11;
            checkProgress.Text = "Show progress";
            checkProgress.UseVisualStyleBackColor = true;
            checkProgress.CheckedChanged += switchTrackEnable;
            // 
            // labelLoadSuccess
            // 
            labelLoadSuccess.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLoadSuccess.ForeColor = Color.Green;
            labelLoadSuccess.Location = new Point(48, 420);
            labelLoadSuccess.Name = "labelLoadSuccess";
            labelLoadSuccess.Size = new Size(207, 40);
            labelLoadSuccess.TabIndex = 9;
            labelLoadSuccess.Text = "Load successful";
            labelLoadSuccess.TextAlign = ContentAlignment.BottomCenter;
            labelLoadSuccess.Visible = false;
            labelLoadSuccess.Click += label3_Click_1;
            // 
            // trackProgress
            // 
            trackProgress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackProgress.BackColor = Color.LightBlue;
            trackProgress.Cursor = Cursors.Hand;
            trackProgress.Enabled = false;
            trackProgress.Location = new Point(12, 281);
            trackProgress.Maximum = 5000;
            trackProgress.Minimum = 100;
            trackProgress.Name = "trackProgress";
            trackProgress.Size = new Size(286, 45);
            trackProgress.TabIndex = 10;
            trackProgress.TickFrequency = 1000;
            trackProgress.TickStyle = TickStyle.Both;
            trackProgress.Value = 100;
            trackProgress.Scroll += trackProgress_Scroll;
            trackProgress.ValueChanged += trackProgress_ValueChanged;
            // 
            // labelAlgorithm
            // 
            labelAlgorithm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAlgorithm.AutoSize = true;
            labelAlgorithm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAlgorithm.Location = new Point(12, 148);
            labelAlgorithm.Name = "labelAlgorithm";
            labelAlgorithm.Size = new Size(63, 15);
            labelAlgorithm.TabIndex = 8;
            labelAlgorithm.Text = "Algorithm";
            labelAlgorithm.Click += label3_Click;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            title.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = Color.Black;
            title.Location = new Point(26, 9);
            title.Name = "title";
            title.Size = new Size(255, 95);
            title.TabIndex = 7;
            title.Text = "Maze Treasure Hunt";
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Click += label2_Click;
            // 
            // checkTSP
            // 
            checkTSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkTSP.AutoSize = true;
            checkTSP.Cursor = Cursors.Hand;
            checkTSP.Location = new Point(13, 216);
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
            dfsButton.Checked = true;
            dfsButton.Cursor = Cursors.Hand;
            dfsButton.Location = new Point(13, 169);
            dfsButton.Name = "dfsButton";
            dfsButton.Size = new Size(45, 19);
            dfsButton.TabIndex = 6;
            dfsButton.TabStop = true;
            dfsButton.Text = "DFS";
            dfsButton.UseVisualStyleBackColor = true;
            dfsButton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // bfsButton
            // 
            bfsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bfsButton.AutoSize = true;
            bfsButton.Cursor = Cursors.Hand;
            bfsButton.Location = new Point(13, 191);
            bfsButton.Name = "bfsButton";
            bfsButton.Size = new Size(44, 19);
            bfsButton.TabIndex = 5;
            bfsButton.Text = "BFS";
            bfsButton.UseVisualStyleBackColor = true;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBrowse.BackColor = Color.LightBlue;
            buttonBrowse.Cursor = Cursors.Hand;
            buttonBrowse.Location = new Point(241, 122);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(57, 23);
            buttonBrowse.TabIndex = 4;
            buttonBrowse.Text = "browse";
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += button2_Click;
            // 
            // textBoxFileName
            // 
            textBoxFileName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFileName.BackColor = SystemColors.Window;
            textBoxFileName.ForeColor = Color.Gray;
            textBoxFileName.Location = new Point(12, 122);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(223, 23);
            textBoxFileName.TabIndex = 3;
            textBoxFileName.TextChanged += textBox1_TextChanged;
            textBoxFileName.GotFocus += RemoveText;
            textBoxFileName.LostFocus += AddText;
            // 
            // textBox_exec_time
            // 
            textBox_exec_time.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox_exec_time.BackColor = Color.White;
            textBox_exec_time.BorderStyle = BorderStyle.FixedSingle;
            textBox_exec_time.Location = new Point(367, 463);
            textBox_exec_time.Name = "textBox_exec_time";
            textBox_exec_time.ReadOnly = true;
            textBox_exec_time.Size = new Size(109, 23);
            textBox_exec_time.TabIndex = 11;
            textBox_exec_time.WordWrap = false;
            // 
            // textBox_steps
            // 
            textBox_steps.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox_steps.BackColor = Color.White;
            textBox_steps.BorderStyle = BorderStyle.FixedSingle;
            textBox_steps.Location = new Point(367, 418);
            textBox_steps.Name = "textBox_steps";
            textBox_steps.ReadOnly = true;
            textBox_steps.Size = new Size(109, 23);
            textBox_steps.TabIndex = 10;
            // 
            // textBox_nodes
            // 
            textBox_nodes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_nodes.BackColor = Color.White;
            textBox_nodes.BorderStyle = BorderStyle.FixedSingle;
            textBox_nodes.Location = new Point(75, 463);
            textBox_nodes.Name = "textBox_nodes";
            textBox_nodes.ReadOnly = true;
            textBox_nodes.Size = new Size(109, 23);
            textBox_nodes.TabIndex = 9;
            // 
            // textBox_route
            // 
            textBox_route.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_route.BackColor = Color.White;
            textBox_route.BorderStyle = BorderStyle.FixedSingle;
            textBox_route.Location = new Point(75, 418);
            textBox_route.Multiline = true;
            textBox_route.Name = "textBox_route";
            textBox_route.ReadOnly = true;
            textBox_route.ScrollBars = ScrollBars.Horizontal;
            textBox_route.Size = new Size(206, 39);
            textBox_route.TabIndex = 8;
            textBox_route.WordWrap = false;
            // 
            // label_exec_ime
            // 
            label_exec_ime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_exec_ime.Location = new Point(292, 463);
            label_exec_ime.Name = "label_exec_ime";
            label_exec_ime.Size = new Size(69, 36);
            label_exec_ime.TabIndex = 7;
            label_exec_ime.Text = "Execution  : time";
            // 
            // label_step
            // 
            label_step.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_step.Location = new Point(292, 420);
            label_step.Name = "label_step";
            label_step.Size = new Size(69, 15);
            label_step.TabIndex = 6;
            label_step.Text = "Steps          :";
            label_step.Click += label2_Click_1;
            // 
            // label_nodes
            // 
            label_nodes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_nodes.Location = new Point(3, 463);
            label_nodes.Name = "label_nodes";
            label_nodes.Size = new Size(66, 36);
            label_nodes.TabIndex = 5;
            label_nodes.Text = "Nodes      : Checked ";
            // 
            // label_route
            // 
            label_route.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_route.Location = new Point(3, 420);
            label_route.Name = "label_route";
            label_route.Size = new Size(66, 15);
            label_route.TabIndex = 4;
            label_route.Text = "Route       :";
            label_route.Click += label_rute_Click;
            // 
            // button_start
            // 
            button_start.Anchor = AnchorStyles.Bottom;
            button_start.BackColor = Color.LightBlue;
            button_start.Cursor = Cursors.Hand;
            button_start.Location = new Point(207, 389);
            button_start.Name = "button_start";
            button_start.Size = new Size(75, 23);
            button_start.TabIndex = 3;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += button_start_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // timerLoadDialogue
            // 
            timerLoadDialogue.Interval = 2000;
            timerLoadDialogue.Tick += timer1_TickStopLoadLabel;
            // 
            // backgroundWorkerColoring
            // 
            backgroundWorkerColoring.WorkerReportsProgress = true;
            backgroundWorkerColoring.WorkerSupportsCancellation = true;
            backgroundWorkerColoring.DoWork += backgroundWorker1_DoWork;
            backgroundWorkerColoring.ProgressChanged += backgroundWorkerColoring_ProgressChanged;
            backgroundWorkerColoring.RunWorkerCompleted += backgroundWorkerColoring_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 511);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(750, 550);
            Name = "Form1";
            Text = "Maze Treasure Hunt";
            Load += Form1_Load;
            ResizeBegin += resizeCell;
            ResizeEnd += resizeCell;
            Resize += resizeCell;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
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
        private Label labelAlgorithm;
        private Label labelLoadSuccess;
        private System.Windows.Forms.Timer timerLoadDialogue;
        private CheckBox checkProgress;
        private TrackBar trackProgress;
        private Solver solver;
        private bool isLoaded;
        private const string emptyInputString = "e.g : \"text.txt\" , default dir is in .\\test";
        private string projectRoot;
        private Button button_start;
        private Label label_route;
        private Label label_step;
        private Label label_nodes;
        private Label label_exec_ime;
        private TextBox textBox_exec_time;
        private TextBox textBox_steps;
        private TextBox textBox_nodes;
        private TextBox textBox_route;
        private System.ComponentModel.BackgroundWorker backgroundWorkerColoring;
        private Label label_interval;
        private ProgressBar progressBar1;
        private Label label_progress;
        private HelpProvider helpProvider1;
    }
}