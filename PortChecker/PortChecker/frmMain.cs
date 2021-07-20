using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace MatthiWare.PortChecker
{
    public partial class frmMain : Form
    {
        SettingsDialog sd = new SettingsDialog();
        CheckPortDialog cpd = new CheckPortDialog();
        PortChecker portChecker;


        delegate void PortAdderDelegate(Object o);

        public frmMain()
        {
            InitializeComponent();
        }

        void portChecker_PortCheckCompleted(object sender, PortEventArgs e)
        {
            if (e.Open)
                AddOpenPort(String.Format("{0}", e.Port));
        }

        void AddOpenPort(Object obj)
        {
            if (lbPortsOpen.InvokeRequired)
                lbPortsOpen.Invoke(new PortAdderDelegate(AddOpenPort), obj);
            else
            {
                lbPortsOpen.Items.Add(obj);

                lbPortsOpen.SelectedIndex = lbPortsOpen.Items.Count - 1;
            }
        }


        private void checkPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cpd.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseHandler();
        }

        private void CloseHandler()
        {
            if (portChecker != null)
            {
                bool wasRunning = portChecker._running;

                portChecker.End();

                if (wasRunning)
                {
                    MessageBox.Show("Все ожидающие проверки портов отменены\nПроцесс может продолжаться, пока все задачи не будут выполнены.", "ПРЕДУПРЕЖДЕНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sd.ShowDialog();
            cpd.SetIp(sd.GetStrIp());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cpd.SetIp(sd.GetStrIp());
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void lblPortsOpen_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPortRange_Click(object sender, EventArgs e)
        {

        }


        [Serializable]
        public struct SAVE_REPORT
        {
            public ListBox.ObjectCollection Open;
            public ListBox.ObjectCollection Closed;

            public SAVE_REPORT(ListBox.ObjectCollection open, ListBox.ObjectCollection closed)
            {
                Open = open;
                Closed = closed;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            sd.ShowDialog();
            cpd.SetIp(sd.GetStrIp());
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
                ushort minPortRange, maxPortRange = 50000;

                bool parse1 = !UInt16.TryParse(txtPortRange1.Text, out minPortRange);
                bool parse2 = !UInt16.TryParse(txtPortRange2.Text, out maxPortRange);

                if (parse1 || parse2)
                {
                    MessageBox.Show(String.Format("Невозможно проанализировать номера портов\nЗначение должно быть между {0}-{1}", UInt16.MinValue, UInt16.MaxValue), "Parsing error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (minPortRange > maxPortRange)
                {
                    MessageBox.Show("Минимальный диапазон портов не может быть выше максимального диапазона портов (50k).", "Максимальный порт меньше минимального порта", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                lbPortsOpen.Items.Clear();

                portChecker = new PortChecker(minPortRange, maxPortRange, sd.GetNewIp());

                portChecker.PortCheckCompleted += new EventHandler<PortEventArgs>(portChecker_PortCheckCompleted);
                portChecker.StartChecking();
            }

        private void lbPortsOpen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpd.ShowDialog();
        }

        private void text1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            sd.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cpd.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            cpd.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запускаю проверку портов.\nЕсли найдутся открытые порты,\nто они появятся в вкладке\n'Открытые порты");
            ushort minPortRange, maxPortRange = 50000;

            bool parse1 = !UInt16.TryParse(txtPortRange1.Text, out minPortRange);
            bool parse2 = !UInt16.TryParse(txtPortRange2.Text, out maxPortRange);

            if (parse1 || parse2)
            {
                MessageBox.Show(String.Format("Невозможно проанализировать номера портов\nЗначение должно быть между {0}-{1}", UInt16.MinValue, UInt16.MaxValue), "Ошибка в парсинге", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (minPortRange > maxPortRange)
            {
                MessageBox.Show("Минимальный диапазон портов не может быть выше максимального диапазона портов (50k).", "Максимальный порт меньше минимального порта", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            lbPortsOpen.Items.Clear();

            portChecker = new PortChecker(minPortRange, maxPortRange, sd.GetNewIp());

            portChecker.PortCheckCompleted += new EventHandler<PortEventArgs>(portChecker_PortCheckCompleted);
            portChecker.StartChecking();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
        }

