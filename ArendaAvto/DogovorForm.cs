using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArendaAvto
{
    public partial class DogovorForm : Form
    {
        public string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ArendaAvto.mdb";

        public DogovorForm()
        {
            InitializeComponent();
        }

        private void DogovorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "arendaAvtoDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.arendaAvtoDataSet.Clients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex + 1;
            string CmdText = "SELECT Rent.[Номер договора], Rent.Дата, Auto.Модель, Rent.[Срок аренды], Clients.[Код клиента] FROM Auto INNER JOIN(Clients INNER JOIN Rent ON Clients.[Код клиента] = Rent.Клиент) ON Auto.[Код автомобиля] = Rent.Автомобиль WHERE(((Clients.[Код клиента])= " + index.ToString() + "));";

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Clients]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
