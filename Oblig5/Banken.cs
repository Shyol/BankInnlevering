using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oblig5
{
    public interface IBankOperasjon
    {
        bool Autentifisere(); //fjernet string
        void LoggeUt();
        void SettInnPenger(double beløp);
        bool TaUtPenger(double beløp);
        double Saldo();
    }
    public partial class Banken : Form, IBankOperasjon
    {
        public static Banken instance;
        public Dictionary<string, Kunder> Kundeliste = new Dictionary<string, Kunder>();
        private string currentKey;
        private Timer timer = new Timer();


        public Banken()
        {
            InitializeComponent();
        }


        private void Banken_Load(object sender, EventArgs e)
        {
            //singleton, kun en bank
            if (instance == null)
            {
                instance = this;
            }

            timer.Interval = 40;
            timer.Tick += new EventHandler(timedEvent);

            Kundeliste.Add("07128912345", new Kunder("Freidrich Kemolars", "1234"));
            
        }

        private void timedEvent(object sender, EventArgs e)
        {
            tSaldo.Text = Saldo().ToString();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            pLogin.Show();
            bLogin.Enabled = false;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bLoginDetails_Click(object sender, EventArgs e)
        {
            lFeilPW.Hide();
            if (Autentifisere())
            {
                tUserdisplay.Text = Kundeliste[currentKey].Navn;
                pLogin.Hide();
                bLogout.Enabled = true;
                timer.Start();
                pAccount.Show();

            }
        }
        private void bSettInn_Click(object sender, EventArgs e)
        {
            SettInnPenger(HentBeløpFraTekstBoks(tSettInn));
        }
        private void bUttakPeng_Click(object sender, EventArgs e)
        {
            double beløp = HentBeløpFraTekstBoks(tTaUt);
            if (TaUtPenger(beløp))
            {
                Kundeliste[currentKey].Saldo -= beløp;
            }
            else
            {
                ErrorBox("Beløpet du prøver å ta ut er større en du har på konto","Error");
            }
        }
        private void bLogout_Click(object sender, EventArgs e)
        {
            LoggeUt();
        }
        public bool Autentifisere()
        {
            Kunder kunde = FindCustomer(tUser.Text);
            if (kunde != null)
            {
                if (kunde.Password == tPw.Text)
                {
                    currentKey = tUser.Text;
                    return true;
                }
                else
                {
                    lFeilPW.Show();
                }
            }
            return false;
        }

        private Kunder FindCustomer(string customer)
        {
            try
            {
                return Kundeliste[customer];
            }
            catch (Exception)
            {
                lFeilPW.Show();
            }
            return null;
        }

        public void LoggeUt()
        {
            if (MessageBox("Sikker på at du ønsker å logge ut?", "Warning"))
            {
                timer.Stop();
                ClearAllTextBoxes();
                currentKey = null;
                pAccount.Hide();
                pLogin.Show();
                bLogout.Enabled = false;
            }
        }

        private void ClearAllTextBoxes()
        {
            tUserdisplay.Text = string.Empty;
            tSettInn.Text = string.Empty;
            tTaUt.Text = string.Empty;
        }

        public void SettInnPenger(double beløp)
        {
            Kundeliste[currentKey].Saldo += beløp;
        }

        public bool TaUtPenger(double beløp)
        {
            if (Kundeliste[currentKey].Saldo < beløp)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double Saldo()
        {
            return Kundeliste[currentKey].Saldo;
        }
        private bool MessageBox(string message, string title)
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ErrorBox(string message, string title)
        {
            System.Windows.Forms.MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void NumericChecker(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private double HentBeløpFraTekstBoks(TextBox a)
        {
            double temp;
            double.TryParse(a.Text, out temp);
            return temp;
        }


    }
}
