using VanriseWinforms.Models;

namespace VanriseWinforms
{
    public partial class Form1 : Form
    {
        private readonly DummyDataStore _store;
        public Form1()
        {
            InitializeComponent();
            _store = new DummyDataStore(12);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _store.Get();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var studentForm = new AddStudentForm();
            studentForm.SubscribeToStudentAdded(OnStudentAdded);
            studentForm.ShowDialog();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(search_box.Text))
            {
                dataGridView1.DataSource = _store.Get();
                return;
            }

            dataGridView1.DataSource = _store.GetFiltered(search_box.Text);
        }

        private void OnContextMenuClicked(object? sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];
            var student = row.DataBoundItem as Student;
            using var studentForm = new AddStudentForm(student);
            studentForm.SubscribeToStudentEdited(OnStudentEdited);
            studentForm.ShowDialog();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

            // if the click was on a row
            if (currentMouseOverRow >= 0) 
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[currentMouseOverRow].Selected = true;

                var m = CreateContextMenuStrip("Edit");
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }


        private ContextMenuStrip CreateContextMenuStrip(string action)
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            menuStrip.Items.Add(action);
            menuStrip.Items[0].Text = action;
            menuStrip.Items[0].Click += OnContextMenuClicked;
            return menuStrip;
        }


        /* Event Handlers */
        private void OnStudentEdited(object? sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void OnStudentAdded(object? sender, Student e)
        {
            _store.Add(e);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _store.Get();
        }
        /* End Event Handlers */



    }
}
