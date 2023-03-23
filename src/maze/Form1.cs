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


        public void colorCell(int i, int j, Color c)
        {
            dataGridView1[j, i].Style.BackColor = c;
        }

        public void clearCellColor()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j, i].Style.BackColor = Color.White;
                }
            }
        }

        private void visualizeMap(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
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
                dataGridView1.RowCount = rowLen;
                dataGridView1.ColumnCount = colLen;
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
            catch (FileNotFoundException)
            {
                labelLoadSuccess.Text = "Load failed";
                labelLoadSuccess.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                labelLoadSuccess.Text = "File is not valid";
                labelLoadSuccess.ForeColor = Color.Red;
            }
            labelLoadSuccess.Show();
            timerLoadDialogue.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            }
            else
            {
                trackProgress.Enabled = true;
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
            textBox_route.Text = "";
            textBox_nodes.Text = "";
            textBox_steps.Text = "";
            textBox_exec_time.Text = "";
            System.Diagnostics.Debug.WriteLine(dfsButton.Checked);
            System.Diagnostics.Debug.WriteLine(bfsButton.Checked);
            PathResult result;
            if (dfsButton.Checked)
            {
                result = solver.solveByDFS(checkTSP.Checked);
            }
            else if (bfsButton.Checked)
            {
                System.Diagnostics.Debug.WriteLine("BFS");
                result = solver.solveByBFS(checkTSP.Checked);
            }
            else
            {
                return;
            }
            System.Diagnostics.Debug.WriteLine(result.path[0]);

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
            System.Diagnostics.Debug.WriteLine("---------------");

            foreach (var c in result.searchOrder)
            {
                System.Diagnostics.Debug.WriteLine(c);
            }
        }

        private void label_rute_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}