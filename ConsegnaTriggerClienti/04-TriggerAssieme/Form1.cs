using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_TriggerAssieme
{
    public partial class Form1 : Form
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\Clienti.mdf;Integrated Security=True;Connect Timeout=30";

        private BindingSource bsClienti = new BindingSource();
        private BindingSource bsStoricoCanc = new BindingSource();
        private BindingSource bsStoricoUpd = new BindingSource();
        private SqlDataAdapter daClienti, daStoricoCancellazioni, daStoricoAggiornamenti;
        private DataTable dtClienti, dtStoricoCancellazioni, dtStoricoAggiornamenti;



        public Form1()
        {
            InitializeComponent();
            PopulateDgv(0);
        }

        private void btnRicaricaTabelle_Click(object sender, EventArgs e)
        {
            dgvClienti.DataSource = null;
            dgvStoricoAggiornamenti.DataSource = null;
            dgvStoricoCancellazioni.DataSource = null;
            PopulateDgv(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PopulateDgv(int table)
        {
            switch (table)
            {
                case 0://carico tutte e 3 le tabelle
                    // Clienti
                    dgvClienti.DataSource = null;
                    dgvClienti.DataSource = bsClienti;
                    daClienti = null;
                    Queryable("SELECT * FROM Clienti", out daClienti);

                    if (daClienti != null)
                    {
                        dtClienti = new DataTable();
                        daClienti.Fill(dtClienti);
                        bsClienti.DataSource = dtClienti;
                    }
                    dgvClienti.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    //Cancellazioni
                    dgvStoricoCancellazioni.DataSource = null;
                    dgvStoricoCancellazioni.DataSource = bsStoricoCanc;
                    daStoricoCancellazioni = null;
                    Queryable("SELECT * FROM StoricoCancellazioni", out daStoricoCancellazioni);

                    if (daStoricoCancellazioni != null)
                    {
                        dtStoricoCancellazioni = new DataTable();
                        daStoricoCancellazioni.Fill(dtStoricoCancellazioni);
                        bsStoricoCanc.DataSource = dtStoricoCancellazioni;
                    }
                    dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    //Aggiornamenti
                    dgvStoricoAggiornamenti.DataSource = null;
                    dgvStoricoAggiornamenti.DataSource = bsStoricoUpd;
                    daStoricoAggiornamenti = null;
                    Queryable("SELECT * FROM StoricoAggiornamenti", out daStoricoAggiornamenti);

                    if (daStoricoAggiornamenti != null)
                    {
                        dtStoricoAggiornamenti = new DataTable();
                        daStoricoAggiornamenti.Fill(dtStoricoAggiornamenti);
                        bsStoricoUpd.DataSource = dtStoricoAggiornamenti;
                    }
                    dgvStoricoAggiornamenti.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    break;

                case 1://carico solo clienti
                    dgvClienti.DataSource = null;
                    dgvClienti.DataSource = bsClienti;
                    daClienti = null;
                    Queryable("SELECT * FROM Clienti", out daClienti);

                    if (daClienti != null)
                    {
                        dtClienti = new DataTable();
                        daClienti.Fill(dtClienti);
                        bsClienti.DataSource = dtClienti;
                    }
                    dgvClienti.Update();
                    dgvClienti.Refresh();
                    dgvClienti.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    break;

                case 2://carico solo cancellazioni
                    dgvStoricoCancellazioni.DataSource = null;
                    dgvStoricoCancellazioni.DataSource = bsStoricoCanc;
                    daStoricoCancellazioni = null;
                    Queryable("SELECT * FROM StoricoCancellazioni", out daStoricoCancellazioni);

                    if (daStoricoCancellazioni != null)
                    {
                        dtStoricoCancellazioni = new DataTable();
                        daStoricoCancellazioni.Fill(dtStoricoCancellazioni);
                        bsStoricoCanc.DataSource = dtStoricoCancellazioni;
                    }
                    dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    break;

                case 3://carico solo aggiornamenti
                    dgvStoricoAggiornamenti.DataSource = null;
                    dgvStoricoAggiornamenti.DataSource = bsStoricoUpd;
                    daStoricoAggiornamenti = null;
                    Queryable("SELECT * FROM StoricoAggiornamenti", out daStoricoAggiornamenti);

                    if (daStoricoAggiornamenti != null)
                    {
                        dtStoricoAggiornamenti = new DataTable();
                        daStoricoAggiornamenti.Fill(dtStoricoAggiornamenti);
                        bsStoricoUpd.DataSource = dtStoricoAggiornamenti;
                    }
                    dgvStoricoAggiornamenti.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    break;
            }
        }

        private void Queryable(string selectCommand, out SqlDataAdapter da)
        {
            da = null;
            try
            {
                // Crea un nuovo Data Adapter basato su selectCommand
                da = new SqlDataAdapter(selectCommand, CONNECTION_STRING);
                // Creo il command builder per generare update, insert, delete
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvClienti.CurrentCell.RowIndex;//basandomi sulla cella selezionata ricavo index della riga (posso selezionarne una alla volta)
            daClienti = null;
            string query = "UPDATE Clienti SET Nome = '" + dgvClienti.Rows[index].Cells[1].Value.ToString() +
                        "', Cognome = '" + dgvClienti.Rows[index].Cells[2].Value.ToString() +
                        "', IdCarrello = " + dgvClienti.Rows[index].Cells[3].Value.ToString() +
                        " WHERE IdCliente = " + dgvClienti.Rows[index].Cells[0].Value.ToString();
            //MessageBox.Show(query);
            Queryable(query, out daClienti);

            if (daClienti != null)
            {
                PopulateDgv(0);
                //PopulateDgv(3);//aggiorno tabella update
            }
            else
                MessageBox.Show("Errore Update");

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            int index = dgvClienti.CurrentCell.RowIndex;//basandomi sulla cella selezionata ricavo index della riga (posso selezionarne una alla volta)
            daClienti = null;
            string query = "DELETE FROM Clienti WHERE IdCliente = " + dgvClienti.Rows[index].Cells[0].Value.ToString();
            MessageBox.Show(query);
            Queryable(query, out daClienti);
            if (daClienti != null)
            {
                PopulateDgv(0);
                //PopulateDgv(2);//aggiorno tabella cancellazioni
                //PopulateDgv(1);//aggiorno tabella clienti
                //dgvClienti.Rows.RemoveAt(index);
            }
            else
                MessageBox.Show("Errore Elimina");

        }

    }
}