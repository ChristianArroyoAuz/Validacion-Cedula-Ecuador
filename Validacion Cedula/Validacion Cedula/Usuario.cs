using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validacion_Cedula
{
    class Usuario
    {
        int id;
        string nombre;
        long cedula;
        string aprobacion;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public long Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Aprobacion
        {
            get { return aprobacion; }
            set { aprobacion = value; }
        }

        public Usuario(int id, string nombre, long cedula, string aprobacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.cedula = cedula;
            this.aprobacion = aprobacion;
        }

        public override string ToString()
        {
            return this.id + "\t\t" + this.nombre + "\t\t" + this.cedula + "\t\t" + this.aprobacion;
        }
    }
}
