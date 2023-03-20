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

        private void visualizeMap(object sender, EventArgs e)
        {
            labelLoadSuccess.Show();
            timer1.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFileName.Text))
            {
                textBoxFileName.Text = emptyInputString;
                textBoxFileName.ForeColor = Color.Gray;
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
    }
}