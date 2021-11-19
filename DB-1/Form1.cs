using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace DB_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cl = new List<Client>();
            cs = new List<Case>();
        }

        class Client
        {
            public int Id { set; get; }
            public string FIO { set; get; }
            public string PassportNumber { set; get; }
            public string PhoneNumber { set; get; }
            public Client(int ClientId, string fio, string passport, string number)
            {
                Id = ClientId;
                FIO = fio;
                PassportNumber = passport;
                PhoneNumber = number;
            }
            public override string ToString()
            {
                return String.Format("{0} {1} {2} {3}", Id, FIO, PassportNumber, PhoneNumber);
            }
        }

        class Case
        {
            public int Id { set; get; }
            public DateTime Date { set; get; }
            public int MaxPunishment { set; get; }
            public int Client { set; get; }
            public Case(int CaseId, DateTime date, int punishment, int client)
            {
                Id = CaseId;
                Date = date;
                MaxPunishment = punishment;
                Client = client;
            }
        }
        List<Client> cl = null;
        List<Case> cs = null;
        public void readClients (string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                string[] fields;
                while ((line = sr.ReadLine()) != null)
                {
                    fields = line.Split(new char[] { ',' },
                        StringSplitOptions.RemoveEmptyEntries);
                    Client wr = new Client(int.Parse(fields[0]), fields[1].Trim(), fields[2].Trim(), fields[3].Trim());
                    cl.Add(wr);
                }
                dgClients.DataSource = cl;
            }
        }

        public void readCases(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                string[] fields;
                while ((line = sr.ReadLine()) != null)
                {
                    fields = line.Split(new char[] { ',' },
                        StringSplitOptions.RemoveEmptyEntries);
                    Case wr = new Case(int.Parse(fields[0]), DateTime.Parse(fields[1]), int.Parse(fields[2]), int.Parse(fields[3]));
                    cs.Add(wr);
                }
                dgCases.DataSource = cs;
            }
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                readClients(fileName);
            }
        }

        private void caseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                readCases(fileName);
            }
        }

        private void ClientWithOutCase_Click(object sender, EventArgs e)
        {
            var clients = (from client in cl
                           where !(from _cases in cs select _cases.Client)
                           .Contains(client.Id) select new { Id = client.Id, FIO = client.FIO}).ToList();
            dgWOCases.DataSource = clients;
        }

        private void PunishmentMoreThen5_Click(object sender, EventArgs e)
        {
            var Cases = from _case in cs
                       where _case.MaxPunishment >= 5
                       select new { Id = _case.Id, client = _case.Client };
            dgPunishmentMore5.DataSource = Cases.ToList();
        }

        private void ClientsMoreThen1Case_Click(object sender, EventArgs e)
        {
            var number = (from _cases in cs
                          group _cases by _cases.Client into cnt
                          select new { name = cnt.Key, count = cnt.Count() }).ToList();
            dgMoreThen1Case.DataSource = number;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var clients = (from client in cl
                           orderby client.FIO
                           select new { ClientName = client.FIO }).ToList();
            dgSorted.DataSource = clients;
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            var avg = (from _case in cs
                       join client in cl on _case.Client equals client.Id
                       where _case.MaxPunishment != 0
                       select _case.MaxPunishment).Average();
            tbAvg.Text = avg.ToString();
        }
    }
}
