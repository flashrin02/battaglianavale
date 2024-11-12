namespace battaglianavale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool turno; // true - giocatore 1; false - giocatore 2;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.SelectionChanged += SelectionChanged;
            dataGridView1.ClearSelection();

            foreach (DataGridViewTextBoxColumn column in dataGridView1.Columns) 
            {
                column.Width = 40;
            }
            foreach(DataGridViewRow row in dataGridView1.Rows) 
            {
                row.Height = 40;
            }

            dataGridView2.MultiSelect = false;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowCount = 10;
            dataGridView2.ColumnCount = 10;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.ScrollBars = ScrollBars.None;
            dataGridView2.SelectionChanged += SelectionChanged;
            dataGridView2.ClearSelection();

            foreach (DataGridViewTextBoxColumn column in dataGridView2.Columns)
            {
                column.Width = 20;
            }
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Height = 20;
            }
        }

        private void SelectionChanged(object? sender, EventArgs e) 
        {
            (sender as DataGridView).ClearSelection();
        }
    }
}
