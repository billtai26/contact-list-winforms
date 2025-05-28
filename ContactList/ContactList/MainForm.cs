namespace ContactList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddContactForm addForm = new AddContactForm();
            addForm.ShowDialog();
        }
    }
}
