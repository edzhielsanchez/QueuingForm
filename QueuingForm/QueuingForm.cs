namespace QueuingForm
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier = new CashierClass();
        public QueuingForm()
        {
            InitializeComponent();
            CashierWindowQueue csh = new CashierWindowQueue();
            csh.Show();
        }

        private void btnCashier_Click_1(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }
    }
}