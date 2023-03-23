using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tambahCell(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("", "");
            dataGridView1.Rows.Add(new DataGridViewRow());
        }

        private void resizeCell(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || dataGridView1.ColumnCount == 0) return;
            int selisih = 3;
            int height = (dataGridView1.Size.Height - selisih) / dataGridView1.RowCount;
            int width = (dataGridView1.Size.Width - selisih) / dataGridView1.ColumnCount;
            int sisaH = (dataGridView1.Size.Height - selisih) % dataGridView1.RowCount;
            int sisaW = (dataGridView1.Size.Height - selisih) % dataGridView1.RowCount;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (sisaH > 0)
                {
                    row.Height = height + 1;
                    sisaH--;
                }
                else
                {
                    row.Height = height;
                }
            }
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (sisaW > 0)
                {
                    col.Width = width + 1;
                    sisaW--;
                }
                else
                {
                    col.Width = width;
                }
            }

        }

        private void clearDataGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
        }

        private void colorCell(int row, int col, Color c)
        {
            dataGridView1[col, row].Style.BackColor = c;
        }

        private void colorPath(List<Coordinate> coordinates)
        {
            clearCellColor();
            foreach (var c in coordinates)
            {
                int col = c.x;
                int row = c.y;
                Color oldColor = dataGridView1[col, row].Style.BackColor;
                if (oldColor == Color.White)
                {
                    colorCell(row, col, Color.LightGreen);
                }
                else if (oldColor == Color.LightGreen)
                {
                    colorCell(row, col, Color.Green);
                }
                else
                {
                    colorCell(row, col, Color.DarkGreen);
                }
            }
        }
        private void clearCellColor()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1[j, i].Style.BackColor != Color.Black)
                        dataGridView1[j, i].Style.BackColor = Color.White;
                }
            }
        }

        private void clearTextInfo()
        {
            textBox_nodes.Clear();
            textBox_exec_time.Clear();
            textBox_route.Clear();
            textBox_steps.Clear();
        }
        private void clearAllInfo()
        {
            clearDataGridView();
            clearTextInfo();
        }

        private void visualizeMap(object sender, EventArgs e)
        {
            clearAllInfo();
            try
            {
                string fullDir;
                if (System.IO.Path.IsPathRooted(textBoxFileName.Text))
                {
                    fullDir = textBoxFileName.Text;
                }
                else
                {
                    fullDir = System.IO.Path.GetFullPath(projectRoot + "\\test\\" + textBoxFileName.Text);
                }
                var lines = File.ReadAllLines(fullDir);
                int rowLen = lines.Length;
                if (rowLen == 0)
                {
                    throw new Exception("File kosong");
                }
                int colLen = (lines[0].Length + 1) / 2;
                foreach (var line in lines)
                {
                    System.Diagnostics.Debug.WriteLine(line.Length);
                    if (line.Length != lines[0].Length)
                    {
                        throw new Exception("Banyak kolom tidak konsisten");
                    }
                }
                char[,] matrix = new char[rowLen, colLen];
                for (int i = 0; i < rowLen; i++)
                {
                    for (int j = 0; j < colLen; j++)
                    {
                        matrix[i, j] = lines[i][j * 2];
                        if (matrix[i, j] != 'K' && matrix[i, j] != 'R' && matrix[i, j] != 'X' && matrix[i, j] != 'T')
                            throw new Exception("File tidak valid");
                    }
                }
                solver = new Solver(matrix, rowLen, colLen);
                dataGridView1.ColumnCount = colLen;
                dataGridView1.RowCount = rowLen;
                for (int i = 0; i < rowLen; i++)
                {
                    for (int j = 0; j < colLen; j++)
                    {
                        if (matrix[i, j] == 'X')
                        {
                            colorCell(i, j, Color.Black);
                        }
                        else
                        {
                            colorCell(i, j, Color.White);
                            if (matrix[i, j] == 'K')
                            {
                                dataGridView1[j, i].Value = "Start";
                            }
                            else if (matrix[i, j] == 'T')
                            {
                                dataGridView1[j, i].Value = "Treasure";

                            }
                        }
                    }
                }
                resizeCell(sender, e);
                labelLoadSuccess.Text = "Load successful";
                labelLoadSuccess.ForeColor = Color.Green;
                isLoaded = true;


            }
            catch (IOException)
            {
                labelLoadSuccess.Text = "Load failed";
                labelLoadSuccess.ForeColor = Color.Red;
                isLoaded = false;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                labelLoadSuccess.Text = "File is not valid";
                labelLoadSuccess.ForeColor = Color.Red;
                isLoaded = false;
            }
            labelLoadSuccess.Show();
            timerLoadDialogue.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..");
            projectRoot = System.IO.Path.GetFullPath(CombinedPath);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveText(object sender, EventArgs e)
        {
            if (textBoxFileName.Text == emptyInputString)
            {
                textBoxFileName.Text = "";
                textBoxFileName.ForeColor = Color.Black;
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFileName.Text))
            {
                textBoxFileName.Text = emptyInputString;
                textBoxFileName.ForeColor = Color.Gray;
            }
        }

        private void switchTrackEnable(object sender, EventArgs e)
        {
            if (trackProgress.Enabled)
            {
                trackProgress.Enabled = false;
                label_interval.Enabled = false;
            }
            else
            {
                trackProgress.Enabled = true;
                label_interval.Enabled = true;

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBoxFileName.Text = openFileDialog1.FileName;
            textBoxFileName.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_TickStopLoadLabel(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)sender;
            timer.Stop();
            labelLoadSuccess.Hide();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            if (!isButtonStart())
            {
                backgroundWorkerColoring.CancelAsync();
                label_progress.Text = "Pending cancelation...";
                return;
            }
            clearTextInfo();
            clearCellColor();
            PathResult result;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (dfsButton.Checked)
            {
                result = solver.solveByDFS(checkTSP.Checked);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("BFS");
                result = solver.solveByBFS(checkTSP.Checked);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            for (int i = 1; i < result.path.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(result.path[i]);
                if (i != 1)
                {
                    textBox_route.Text += '-';
                }
                Coordinate now = result.path[i];
                Coordinate bef = result.path[i - 1];
                if (now.x == bef.x + 1 && now.y == bef.y)
                {
                    textBox_route.Text += 'R';
                }
                else if (now.x == bef.x && now.y == bef.y + 1)
                {
                    textBox_route.Text += 'D';
                }
                else if (now.x == bef.x - 1 && now.y == bef.y)
                {
                    textBox_route.Text += 'L';
                }
                else if (now.x == bef.x && now.y == bef.y - 1)
                {
                    textBox_route.Text += 'U';
                }
                else
                {
                    throw new Exception("Path tidak valid!");
                }
            }
            textBox_exec_time.Text = elapsedMs + " ms";
            textBox_nodes.Text = result.searchOrder.Count.ToString();
            textBox_steps.Text = (result.path.Count - 1).ToString();
            if (checkProgress.Checked)
            {
                object[] args = new object[] { result.searchOrder, result.path, trackProgress.Value };
                switchButtonStartAndStop();
                buttonVisualize.Enabled = false;
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                label_progress.Visible = true;
                label_progress.Text = "Progress";
                backgroundWorkerColoring.RunWorkerAsync(argument: args);
            }
            else
            {
                colorPath(result.path);
            }
        }

        private void label_rute_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            object[] parameters = e.Argument as object[];
            var listSearched = (List<Coordinate>)parameters[0];
            var listPath = (List<Coordinate>)parameters[1];
            var interval = (int)parameters[2];
            var worker = (BackgroundWorker)sender;
            int cnt = 0;
            foreach (var c in listSearched)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                int row = c.y;
                int col = c.x;
                var oldColor = dataGridView1[c.x, c.y].Style.BackColor;
                colorCell(row, col, Color.Blue);
                cnt++;
                worker.ReportProgress((int)(cnt / (double)listSearched.Count * 100));
                Thread.Sleep(interval);
                if (oldColor == Color.White)
                {
                    colorCell(row, col, Color.FromArgb(255, 255, 128));
                }
                else if (oldColor == Color.FromArgb(255, 255, 128))
                {
                    colorCell(row, col, Color.FromArgb(255, 255, 0));
                }
                else
                {
                    colorCell(row, col, Color.FromArgb(204, 204, 0));
                }
            }
            e.Result = listPath;
        }

        private void switchButtonStartAndStop()
        {
            if (isButtonStart())
                button_start.Text = "Stop";
            else
                button_start.Text = "Start";

        }
        private bool isButtonStart()
        {
            return button_start.Text == "Start";
        }

        private void backgroundWorkerColoring_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // handle the error
            }
            else if (e.Cancelled == true)
            {

            }
            else
            {
                var listPath = (List<Coordinate>)e.Result;
                colorPath(listPath);


            }
            buttonVisualize.Enabled = true;
            switchButtonStartAndStop();
            progressBar1.Visible = false;
            label_progress.Visible = false;
        }

        private void backgroundWorkerColoring_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void trackProgress_ValueChanged(object sender, EventArgs e)
        {
            label_interval.Text = "Interval : " + trackProgress.Value + " ms";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void trackProgress_Scroll(object sender, EventArgs e)
        {

        }
    }
}