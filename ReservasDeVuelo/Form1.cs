using GestionDeVuelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasDeVuelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboOrigen.Items.Add("Medellín");
            cboOrigen.Items.Add("Cali");
            cboOrigen.Items.Add("Barranquilla");
            cboOrigen.Items.Add("Manizales");

            cboDestino.Items.Add("Buenos Aires");
            cboDestino.Items.Add("Lima");
            cboDestino.Items.Add("Quito");
            cboDestino.Items.Add("Santiago de Chile");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnReservar_Click_1(object sender, EventArgs e)
        {
            string origen = cboOrigen.Text;
            string destino = cboDestino.Text;
            DateTime fechaSalida = dtpFecha.Value;




            string preferenciaAsiento = "";
            if (rdoPasillo.Checked)
            {
                preferenciaAsiento = "Pasillo";
            }
            else if (rdoCentro.Checked)
            {
                preferenciaAsiento = "Centro";
            }
            else if (rdoVentana.Checked)
            {
                preferenciaAsiento = "Ventana";
            }

            if (!string.IsNullOrEmpty(origen) && !string.IsNullOrEmpty(destino) && !string.IsNullOrEmpty(preferenciaAsiento))
            {
                Vuelo vuelo = new Vuelo(origen, destino, fechaSalida, preferenciaAsiento);
                MessageBox.Show($"Información del vuelo:\n\n{vuelo}");
            }
            else

                MessageBox.Show("Por favor, complete todos los campos.");
        }

    }
    }


