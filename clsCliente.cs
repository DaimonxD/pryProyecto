using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProyecto
{
    class clsCliente
    {
        private Int32 cod;
        private String nom;
        private Decimal deu=0;

        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public Decimal Deuda
        {
            get { return deu; }
            set { deu = value; }
        }

        public void Comprar(Decimal importe)
        {
            deu = deu + importe;
        }

        public void Comprar(Int32 importe)
        {
            deu = deu + importe;
        }

        public void Comprar(Decimal importe, Decimal interes)
        {
            deu = deu + importe + interes;
        }

        public void Pagar(Decimal importe)
        {
            deu = deu - importe;
        }

    }
}




//Tarea
//Proyecto (Boton Salir cierra) (Boton Datos del Desarrollador muestra foto, dni, nombre, semestre