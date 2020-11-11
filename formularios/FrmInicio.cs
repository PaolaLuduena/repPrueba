using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codigos;

namespace formularios
{
   

    public partial class FrmInicio : Form
    {


        #region Constructor
        public FrmInicio()
        {
            InitializeComponent();
            

        }
        #endregion

        #region Evento
        private void facturasACreditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario= new FormfacturasACreditos(); //LLamos los formulario e oculo el frm inicio
            formulario.Visible = true;
            Visible =false;
        }

        private void registrodeAmbosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formulario = new RegistrosdeAmbos();//LLamos los formulario e oculo el frm inicio
            formulario.Visible = true;
            Visible = false;
           
        }

        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//salimos
        }


        #endregion

       
    }
}
