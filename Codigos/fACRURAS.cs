using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigos
{

    public class fACRURAS
    {
        #region Propiedades
        //nombramos las vaibles , los inicializamos
        public DateTime FECHA;
        public string fecha = "";
        public decimal Subtotal = 0;
        public decimal iva = 21;
        public decimal ValorFinal = 0;
        public decimal cantida4 = 0;
        public decimal Valor4 = 0;
        int indice = 0;
        int I = 0;
        #endregion

       
        public fACRURAS()
        {
            FECHA = DateTime.Now;

        }

        #region Metodos
        public decimal Subtotales()
        {
            return Subtotal = cantida4 * Valor4; //calculamos el subtotal

        }


        public decimal totales()
        {

            return ValorFinal = Subtotales() + Ivaa(); //sumamos el valor del subtotal con el iva sacado

        }

        public decimal Ivaa()

        {
           return iva= Subtotal * 21/100; //calculamos iva

        }
        #endregion



    }
}
