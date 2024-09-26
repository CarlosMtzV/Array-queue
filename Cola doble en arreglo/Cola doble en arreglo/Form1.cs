namespace Cola_doble_en_arreglo
{
    public partial class Form1 : Form
    {
        private Deque deque;
        public Form1()
        {
            InitializeComponent();
            deque = new Deque();
        }


        private void DisplayDeque()
        {
            txtDeque.Text = deque.Display();
        }

        private void btnInsertFront_Click_1(object sender, EventArgs e)
        {
            try
            {
                int data = int.Parse(txtInput.Text);
                deque.InsertFront(data);
                DisplayDeque();
                txtInput.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertRear_Click(object sender, EventArgs e)
        {
            try
            {
                int data = int.Parse(txtInput.Text);
                deque.InsertRear(data);
                DisplayDeque();
                txtInput.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteFront_Click(object sender, EventArgs e)
        {
            try
            {
                deque.DeleteFront();
                DisplayDeque();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteRear_Click(object sender, EventArgs e)
        {
            try
            {
                deque.DeleteRear();
                DisplayDeque();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
