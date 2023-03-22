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


        private void colorCell(int i, int j, Color c)
        {
            dataGridView1[j, i].Style.BackColor = c;
        }

        private void visualizeMap(object sender, EventArgs e)
        {
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
                    throw new Exception("File tidak valid");
                }
                int colLen = (lines[0].Length + 1) / 2;
                foreach (var line in lines)
                {
                    System.Diagnostics.Debug.WriteLine(line.Length);
                    if (line.Length != lines[0].Length)
                    {
                        throw new Exception("File tidak valid");
                    }
                }
                char[,] matrix = new char[rowLen, colLen];
                for (int i = 0; i < rowLen; i++)
                {
                    for (int j = 0; j < colLen; j++)
                    {
                        matrix[i, j] = lines[i][j * 2];
                    }
                    i++;
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
                labelLoadSuccess.Text = "Load successfull";
                labelLoadSuccess.ForeColor = Color.Green;
                isLoaded = true;

            }
            catch (FileNotFoundException ex)
            {
                labelLoadSuccess.Text = "Load failed";
                labelLoadSuccess.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                labelLoadSuccess.Text = "File is not valid";
                labelLoadSuccess.ForeColor = Color.Red;
            }
            labelLoadSuccess.Show();
            timer1.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelLoadSuccess.Hide();
            timer1.Stop();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (dfsButton.Enabled)
            {
                solver.solveByDFS();
            }
            else
            {
                solver.solveByBFS();
            }
        }
    }
}