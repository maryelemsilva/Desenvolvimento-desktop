using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.Gray;
            chkAdulto.Checked = false;
            lblIdade.Text = "Abaixo de 19 anos";
        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.ForeColor = Color.Gray;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
            cmbIdade.Visible = false;
            lblIdade2.Text = "";
        }

        private void chkMasculino_CheckendChanged(object sender, EventArgs e)
        {
            chkMasculino.ForeColor = Color.DarkOrange;
            chkFeminino.ForeColor = Color.Gray;
            chkMasculino.Checked = true;
            chkFeminino.Checked = false;
        }

        private void chkFeminino_CheckendChanged(object sender, EventArgs e)
        {
            chkFeminino.ForeColor = Color.DarkOrange;
            chkMasculino.ForeColor = Color.Gray;
            chkFeminino.Checked = true;
            chkMasculino.Checked = false;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //PRIMEIRO PASSO OBTER VALORES
            var peso  = double.Parse(txtPeso.Text);
            var altura = double.Parse(TxtAltura.Text);

            //FAZ O PROCESSAMENTO
            var imc = peso / (altura * altura);
            var textobase = $@"Meu IMC: {imc:N2} é";

            //EXIBE O RESULTADO
            

            if(imc <= 18.5)
            {
                lblResultado.Text = $@" {textobase}  {imc:N2} é abaixo do normal";
            }
            else if (imc < 24.9)
            {
                lblResultado.Text = $@" {textobase} {imc:N2} é normal";
            }
            else if (imc < 29.9)
            {
                lblResultado.Text = $@" {textobase} {imc:N2} é sobrepeso";
            }
            else if (imc < 34.9)
            {
                lblResultado.Text = $@"{textobase}  {imc:N2} é obesidade grau 1";
            }
            else if (imc < 39.9)
            {
                lblResultado.Text = $@"{textobase} {imc:N2} é obesidade grau 2";
            }
            else
            {
                lblResultado.Text = $@"{textobase}  {imc:N2} é obesidade 3";
            }
        }
    }
}
