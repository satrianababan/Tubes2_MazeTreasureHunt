namespace maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selisih = 3;
            dataGridView1.Columns.Add("","");
            dataGridView1.Rows.Add(new DataGridViewRow());
            int height = (dataGridView1.Size.Height -selisih) / dataGridView1.RowCount;
            int width = (dataGridView1.Size.Width - selisih) / dataGridView1.ColumnCount;
            int sisaH = (dataGridView1.Size.Height- selisih) % dataGridView1.RowCount;
            int sisaW = (dataGridView1.Size.Width - selisih) % dataGridView1.RowCount;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (sisaH > 0)
                {
                    row.Height = height + 1;
                    sisaH--;
                } else
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
    }
}