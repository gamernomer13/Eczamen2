using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace ArendaAvto
{
    public partial class Form1 : Form
    {
        public string CmdText;
        public string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\ArendaAvto.mdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CmdText = "SELECT * FROM Clients";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Clients]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void fioPoiskButton_Click(object sender, EventArgs e)
        {
            if (fioPoisk.Text != "")
            {
                CmdText = "SELECT * FROM Clients WHERE (((Clients.ФИО)='" + fioPoisk.Text + "'));";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "[Clients]");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void phonePoiskButton_Click(object sender, EventArgs e)
        {
            if (phonePoisk.Text != "")
            {
                CmdText = "SELECT * FROM Clients WHERE (((Clients.Телефон)='" + phonePoisk.Text + "'));";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "[Clients]");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void nomerPoiskButton_Click(object sender, EventArgs e)
        {
            if (nomerPravPoisk.Text != "")
            {
                CmdText = "SELECT * FROM Clients WHERE ((([Clients.Номер прав])=" + nomerPravPoisk.Text + "));";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "[Clients]");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void dataPoiskButton_Click(object sender, EventArgs e)
        {
            string dateOt = dateTimePicker3.Value.Date.Month + "/" + dateTimePicker3.Value.Date.Day + "/" + dateTimePicker3.Value.Date.Year;
            CmdText = "SELECT * FROM Clients WHERE ((([Clients.Дата получения прав])=#" + dateOt + "#));";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Clients]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void mestoPoiskButton_Click(object sender, EventArgs e)
        {
            if (mestoPravPoisk.Text != "")
            {
                CmdText = "SELECT * FROM Clients WHERE ((([Clients.Место выдачи прав])='" + mestoPravPoisk.Text + "'));";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "[Clients]");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fioPoisk.Text = "";
            mestoPravPoisk.Text = "";
            nomerPravPoisk.Text = "";
            phonePoisk.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dateOt = dateTimePicker1.Value.Date.Month + "/" + dateTimePicker1.Value.Date.Day + "/" + dateTimePicker1.Value.Date.Year;
            string dateDo = dateTimePicker2.Value.Date.Month + "/" + dateTimePicker2.Value.Date.Day + "/" + dateTimePicker2.Value.Date.Year;
            MessageBox.Show(dateOt + " " + dateDo);
            string CmdText = "SELECT Clients.* FROM Clients INNER JOIN Rent ON Clients.[Код клиента] = Rent.Клиент WHERE(((Rent.Дата)>#" + dateOt + "#) AND ((Rent.Дата)<#" + dateDo + "#));";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Clients]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form dogovorForm = new DogovorForm();
            dogovorForm.ShowDialog();
        }
    }
}
