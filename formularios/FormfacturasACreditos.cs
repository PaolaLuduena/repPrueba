using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Media;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codigos;
using Microsoft.SqlServer.Server;

namespace formularios
{
    public partial class FormfacturasACreditos : Form
    {
        #region Propiedades
        //NOMBRAMOS OBJ DE LA CLASE FACtURA PARA LUEGO USARLO
        fACRURAS FACRURASOBJ = new fACRURAS();
       //NOMBRAMOS VARIABLES LOS INICIALIZAMOS
        public decimal Subtotal = 0;
        public decimal iva = 0;
        public decimal ValorFinal = 0;
        public decimal cantida4 = 0;
        public decimal Valor4 = 0;
        #endregion

        #region Constructor
        public FormfacturasACreditos()
        {
            InitializeComponent();
            
        }
        #endregion

        #region Metodo
        private void Nuevafac()
        {
           // fecha de la factura
            FACRURASOBJ = new fACRURAS();
            texfecha.Text = FACRURASOBJ.FECHA.ToString("dd/MM/yyyy");
            texfecha.Focus();



        }
        #endregion

        #region Eventos

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInicio formulario = new FrmInicio(); // ocultamos el formulario inicio
            formulario.Visible = true;
            Visible = false;
           
        }

        private void bufac_Click(object sender, EventArgs e)
        {
            Nuevafac(); //metodo de la clase factura
        }

        private void button3_Click(object sender, EventArgs e)

        {
            FACRURASOBJ.cantida4 = Convert.ToDecimal(texcantida4.Text);//cantidad4 va a tomar el valor que se encuentra en el texcantida4 de la factura
            FACRURASOBJ.Valor4 = Convert.ToDecimal(texValor4.Text);


            labSubtotal.Text = FACRURASOBJ.Subtotales().ToString("#,##0.00");//el metodo subtotales del obj FACRURASOBj de la clase factura se le asigan, el valor calculado al labSubtotal
            FACRURASOBJ.Subtotal = System.Convert.ToDecimal(labSubtotal.Text);

            labIva.Text = FACRURASOBJ.Ivaa().ToString("#,##0.00");//el metodo subtotales del obj FACRURASOBj de la clase factura se le asigan, el valor calculado al labIva
            FACRURASOBJ.iva= System.Convert.ToDecimal(labIva.Text);

            labValorFinal.Text = FACRURASOBJ.totales().ToString("#,##0.00");//el metodo subtotales del obj FACRURASOBj de la clase factura, se le asigan el valor calculado al labValorFinal
            FACRURASOBJ.ValorFinal = System.Convert.ToDecimal(labValorFinal.Text);

         
               



        }

        private void buEnviar_Click(object sender, EventArgs e)
        {
            suma form = new suma(); //envio a los texbox del formulario suma,los valores que se encuentran en los tex de la factura
            form.texProdu.Text = texProducto4.Text;
            form.texVendido.Text = texcantida4.Text;
            form.texValor.Text = labValorFinal.Text;

            this.Hide();
            form.ShowDialog();
            this.Close();

        }
        #endregion
      

      


        
    }
}
