using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flouro
{
    public class Persona
    {
        //propiedades
        private string nombre;
        private int edad;
        private string sexo;
        private int num_cedula;
        private int num_pasaporte;
        private string estado_civil;
        private Double estatura;
        private string sangre;

        //constructor por parametros
public Persona(string nombre, int edad, string sexo,int num_cedula, int num_pasaporte,string estado_civil, Double estatura,string sangre)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.num_cedula = num_cedula;
            this.num_pasaporte = num_pasaporte;
            this.estado_civil = estado_civil;
            this.estatura = estatura;
            this.sangre = sangre;
        }
        //getters y setters
public string Nombre { get { return nombre;
            
            
        }
        
            set { nombre = value; }

        }
        public  int Edad { get { return edad; } }

    }
}
