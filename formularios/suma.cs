using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace formularios
{
    public partial class suma : Form
        #region propiedades
    {
        //creamos objeto de tipo DataTable la cual usaremos para crear las columnas
        DataTable ANL = new DataTable();
        
        //declaramos variables
        int i = 0;
        int poci;
        //variable donde se acumulara lo que agregamos en texValor
        double Total =0;
        #endregion

        #region Constructor
        public suma()
        {
            InitializeComponent();
        }
        #endregion
     
        #region Metodos
        private void limpiar()
        {

            texProdu.Text = "";//limpiamos los texbox
            texVendido.Text = "";
            texValor.Text = "";

        }

         public void colorceldas(DataGridView DGV2)
        {

            DGV2.RowsDefaultCellStyle.BackColor = Color.Aquamarine;//cambiamos color de las celdas al seleccionar
            DGV2.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

        }

        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            colorceldas(DGV2);
            //MessageBox.Show(poci + "");
            poci = DGV2.CurrentRow.Index; //obtenemos fila que contiene la celda
            texProdu.Text = DGV2[0, poci].Value.ToString();
            texVendido.Text = DGV2[1, poci].Value.ToString();
            texValor.Text = DGV2[2, poci].Value.ToString();
        }
        
        
        private void texBUSCAR_TextChanged(object sender, EventArgs e)
        {

            BindingSource Ad = new BindingSource();
            Ad.DataSource = DGV2.DataSource;
            Ad.Filter = "Pagado like '%" + texBUSCAR.Text + "%'";
            DGV2.DataSource = Ad;

        }
        #endregion

        #region Evento
        private void buGuardar_Click(object sender, EventArgs e)
        {
            //guardamos en un archivo xml los valors del texbox
            ANL.WriteXml(@"REGIStRO.Xml");
        }

        private void buLeer_Click(object sender, EventArgs e)
        {//una vez guardados se pude acceder a ellos ,leer los datos del datatable del archivo espesificado
            ANL.ReadXml(@"REGIStRO.Xml");
            DGV2.DataSource = ANL;
        }

        private void buCrear_Click(object sender, EventArgs e)
        {
            ANL.TableName = "REGIStRO";//creamos las columnas de arriba
            ANL.Columns.Add("Producto", typeof(string));
            ANL.Columns.Add("Vendido", typeof(int));
            ANL.Columns.Add("Pagado");
            DGV2.DataSource = ANL;
        }

        private void buNuevo_Click(object sender, EventArgs e)
        { // agregamos a las celdas el valor de cada texbox en la posicion requerida

            try

            {




                ANL.Rows.Add();

                ANL.Rows[ANL.Rows.Count - 1]["Producto"] = texProdu.Text;
                ANL.Rows[ANL.Rows.Count - 1]["Vendido"] = texVendido.Text;
                ANL.Rows[ANL.Rows.Count - 1]["Pagado"] = texValor.Text;

                texProdu.Focus();



            }
            catch (Exception ee)
            {
                MessageBox.Show("Error Overflow" + ee.Message);
            }
            limpiar();
        }

       

        private void buAtras_Click(object sender, EventArgs e)
        {
            FrmInicio formulario = new FrmInicio();
            formulario.Visible = true;
            Visible = false;
        }



        private void buSumar_Click(object sender, EventArgs e)
        {
            Total = Total + Convert.ToDouble(texValor.Text);//lo que tenemos en texvalor  se le va ir agregando , se guardara en varible total

            texSumado.Text = Convert.ToString(Total);//lo que guarda la variable Total se lo muesra en Sumado

        }
        #endregion
        
        


        
    }
}


        
    
