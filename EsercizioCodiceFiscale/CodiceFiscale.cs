using EsercizioCodiceFiscale.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsercizioCodiceFiscale
{
    public partial class CodiceFiscale : Form
    {
        public CodiceFiscale()
        {
            InitializeComponent();
        }

        private void Btn_calcola_Click(object sender, EventArgs e)
        {
            var nome = tbx_nome.Text;
            var cognome = tbx_cognome.Text;
            var data = dataDiNascita.Value;
            var sesso = rbtn_Maschio.Checked ? "m" : "f";
            var comuneScelto = cmbx_comune.SelectedItem.ToString();
            var codiceCatastale = HelperCodiceFiscale.GetCodiceCatastale(comuneScelto);
            var cfCalculator = new Tecnosoftware.CodiceFiscale.CodiceFiscale();
            lbl_codice.Text = cfCalculator.calcolaCF(cognome, nome, data, sesso, codiceCatastale);

        }

    }
}
