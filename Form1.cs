namespace _02.MarketDesktopApp
{
    public partial class Form1 : Form
    {
        decimal total = 0; // Rakamımı tutacağım bir değişken oluşturuyorum.
        decimal remaning = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //MessageBox.Show(txtBarcode.Text);     //input değerini elde ederim.
                dgList.Rows.Add();
                int count = dgList.Rows.Count - 1;

                string code = txtBarcode.Text; //textbox'ın içindekini bir değişkene aldım.

                dgList.Rows[count].Cells[0].Value = count + 1; //#
                dgList.Rows[count].Cells[1].Value = code; // Name
                dgList.Rows[count].Cells[2].Value = 10; // Quantity
                dgList.Rows[count].Cells[3].Value = 5000.22; //Price
                dgList.Rows[count].Cells[4].Value = (10 * 5000.22).ToString("#,##0.00") + "₺"; //Total Price

                txtBarcode.Text = "";
                total = 0;

                for (int i = 0; i < dgList.Rows.Count; i++)
                {
                    total += Convert.ToDecimal(dgList.Rows[i].Cells[2].Value) * (Convert.ToDecimal(dgList.Rows[i].Cells[3].Value));
                }

                lbTotal.Text = total.ToString("#,##0.00") + "₺"; // Burada atayacağım rakamı lazım olabileceğinden üstte değişkende tutuyorum. 

                decimal totalPayment = 0;
                for (int i = 0; i < dgPayment.Rows.Count; i++)
                {
                    totalPayment += Convert.ToDecimal(dgPayment.Rows[i].Cells[1].Value);
                }

                remaning = total - totalPayment;
                lbRemaining.Text = remaning.ToString("#,##0.00") + "₺";
                txtPayment.Text = remaning.ToString();


            }
        }

        private void btnKK_Click(object sender, EventArgs e)
        {
            string payment = txtPayment.Text;
            dgPayment.Rows.Add("Credit Card", payment);
            txtPayment.Text = "0";


            remaning -= Convert.ToDecimal(payment);
            lbRemaining.Text = remaning.ToString("#,##0.00") + "₺";
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            string payment = txtPayment.Text;
            dgPayment.Rows.Add("Cash", payment);
            txtPayment.Text = "0";

            remaning -= Convert.ToDecimal(payment);

            if (remaning < 0) gbPayment.Enabled = false;
            lbRemaining.Text = remaning.ToString("#,##0.00") + "₺";
        }

       
    }
}