using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Codigos;




namespace formularios
{


    public partial class RegistrosdeAmbos : Form
    {
       #region propiedades
        //creamos objeto de tipo DataTable la cual usaremos para crear las columnas
        DataTable LisS = new DataTable();
        DataTable LMN = new DataTable();

        //declaramos variables
        int i = 0;
        int pocicion;
        int poc;

        #endregion

        #region Constructor
        public RegistrosdeAmbos()

        {
            InitializeComponent();
           
        }
        #endregion
       
        #region Metodos

       private void limpiar()
        {

            texNombreClien.Text = ""; //limpiamos los texbox
            texApellidoClien.Text ="" ;
            texDireccionClien.Text = "";
            texCuitClien.Text = "";

            texCodigoProdu.Text = "";
            texNombreProduc.Text = "";
            texCanidadProduc.Text = "";
            texValorProduc.Text = "";

            buModif.Enabled = false;
            buEliminar.Enabled = false;
            buModif2.Enabled = false;
            buEliminar1.Enabled = false;
        }

         private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Celdas(DGV);

            poc = DGV.CurrentRow.Index;// obtenemos fila que contiene la celda
         
            texNombreClien.Text = DGV[0, poc].Value.ToString();
            texApellidoClien.Text = DGV[1, poc].Value.ToString();
            texDireccionClien.Text = DGV[2, poc].Value.ToString();
            texCuitClien.Text = DGV[3, poc].Value.ToString();

            buNuevo.Enabled = false;
            buModif.Enabled = true;
            buEliminar1.Enabled = true; 
        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            colorceldas(DGV1);

            pocicion = DGV1.CurrentRow.Index;

             //obtenemos fila que contiene la celda
            texCodigoProdu.Text = DGV1[0, pocicion].Value.ToString();
            texNombreProduc.Text = DGV1[1, pocicion].Value.ToString();
            texCanidadProduc.Text = DGV1[2, pocicion].Value.ToString();
            texValorProduc.Text = DGV1[3, pocicion].Value.ToString();



            buNuevo.Enabled = false;
            buModif2.Enabled = true;
            buEliminar.Enabled = true;


        }

        public void colorceldas(DataGridView DGV1)
        {

            DGV1.RowsDefaultCellStyle.BackColor = Color.Aquamarine; //cambiamos color de las celdas al seleccionar
            DGV1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        
        }

        public void Celdas(DataGridView DGV) 
        {
            DGV.RowsDefaultCellStyle.BackColor = Color.Aquamarine;
            DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
        #endregion
   
        #region Evento
    private void buEnviar_Click_1(object sender, EventArgs e)
    {
        FormfacturasACreditos formfacturasACreditos = new FormfacturasACreditos();
        formfacturasACreditos.texCodigo4.Text = texCodigoProdu.Text;
        formfacturasACreditos.texProducto4.Text = texNombreProduc.Text;
        formfacturasACreditos.texcantida4.Text = texCanidadProduc.Text;
        formfacturasACreditos.texValor4.Text = texValorProduc.Text;

        formfacturasACreditos.texNombre4.Text = texNombreClien.Text;     // Nombre del texbos del factura , Nombre del texbox DatosClientes
        formfacturasACreditos.texApellido4.Text = texApellidoClien.Text;
        formfacturasACreditos.texDomicilio4.Text = texDireccionClien.Text;
        formfacturasACreditos.texCuit4.Text = texCuitClien.Text;


            
            this.Hide();
            formfacturasACreditos.ShowDialog();
            this.Close();
        


    }



    private void buCrear_Click(object sender, EventArgs e)
    {
        LisS.TableName = "Lista";  //creamos las columnas de arriba
        LisS.Columns.Add("Nombre", typeof(string));
        LisS.Columns.Add("Apellido", typeof(string));
        LisS.Columns.Add("Direccion", typeof(string));
        LisS.Columns.Add("cuit", typeof(double));

        DGV.DataSource = LisS;


        LMN.TableName = "Ordena";
        LMN.Columns.Add("Codigo", typeof(int));
        LMN.Columns.Add("Producto", typeof(string));
        LMN.Columns.Add("Cantidad", typeof(int));
        LMN.Columns.Add("Precio", typeof(int));

        DGV1.DataSource = LMN;



    }

    private void buNuevo_Click(object sender, EventArgs e)
        {    // agregamos a las celdas el valor de cada texbox en la posicion requerida

            try

        {
            LisS.Rows.Add();
            LisS.Rows[LisS.Rows.Count - 1]["Nombre"] = texNombreClien.Text;
            LisS.Rows[LisS.Rows.Count - 1]["Apellido"] = texApellidoClien.Text;
            LisS.Rows[LisS.Rows.Count - 1]["Direccion"] = texDireccionClien.Text;
            LisS.Rows[LisS.Rows.Count - 1]["cuit"] = texCuitClien.Text;

                texNombreClien.Focus();
                


                LMN.Rows.Add();

            LMN.Rows[LMN.Rows.Count - 1]["Codigo"] = texCodigoProdu.Text;
            LMN.Rows[LMN.Rows.Count - 1]["Producto"] = texNombreProduc.Text;
            LMN.Rows[LMN.Rows.Count - 1]["Cantidad"] = texCanidadProduc.Text;
            LMN.Rows[LMN.Rows.Count - 1]["Precio"] = texValorProduc.Text;

                texCodigoProdu.Focus();
               


            }
        catch (Exception ee)
        {
            MessageBox.Show("Error Overflow" + ee.Message); //mensaje de error
        }


            limpiar();

         
          
        }


    private void buGrabar_Click(object sender, EventArgs e)
    {
            //guardamos en un archivo xml los valors del texbox
        LisS.WriteXml(@"Lista.Xml");
        LMN.WriteXml(@"Ordena.Xml");

    }

    private void buLeer_Click(object sender, EventArgs e)
    {
            //una vez guardados se pude acceder a ellos ,leer los datos del datatable del archivo espesificado
        LisS.ReadXml(@"Lista.Xml");
        LMN.ReadXml(@"Ordena.Xml");

        DGV.DataSource = LisS;
        DGV1.DataSource = LMN;
    }

    private void buModif_Click(object sender, EventArgs e)
    {
        string N, A, D, C; //captura los campos ,se crean los variables en string.
         N = texNombreClien.Text;
        A = texApellidoClien.Text;
        D = texDireccionClien.Text;
        C = texCuitClien.Text;

       
         DGV[0, poc].Value = texNombreClien.Text;
        DGV[1, poc].Value = texApellidoClien.Text;
        DGV[2, poc].Value = texDireccionClien.Text;
        DGV[3, poc].Value = texCuitClien.Text;

            buNuevo.Enabled = true;
            limpiar();
        }

    private void buModif2_Click(object sender, EventArgs e)
    {
        string c, P, Cc, V;     // captura los campos ,se crean los variables en string.
        c = texCodigoProdu.Text;
        P = texNombreProduc.Text;
        Cc = texCanidadProduc.Text;
        V = texValorProduc.Text;

        DGV1[0, pocicion].Value = texCodigoProdu.Text;
        DGV1[1, pocicion].Value = texNombreProduc.Text;
        DGV1[2, pocicion].Value = texCanidadProduc.Text;
        DGV1[3, pocicion].Value = texValorProduc.Text;

            buNuevo.Enabled = true;
            limpiar();
        }

    private void buSalir_Click(object sender, EventArgs e)
    {
            FrmInicio formulario = new FrmInicio();
            formulario.Visible = true;
            Visible = false;
    }

    private void RegistrosdeAmbos_Load(object sender, EventArgs e)
    {

    }

        private void button1_Click(object sender, EventArgs e)
        {
            //eliminar las celdas de producto
            DGV1.Rows.RemoveAt(pocicion);
            limpiar();
            buNuevo.Enabled = true;
        }

      

        private void buEliminar1_Click(object sender, EventArgs e)
        {
            DGV.Rows.RemoveAt(poc); //eliminaamos la celda elegida de los clientes
            buNuevo.Enabled = true;
            limpiar();
        }


        #endregion

        
        
    }





}
