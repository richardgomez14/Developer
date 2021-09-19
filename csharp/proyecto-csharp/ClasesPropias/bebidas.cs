using System;

namespace ClasesPropias
{

    public class bebidas
    {
        public string Marca  { get ; set ; }
        public int Cantidad  { get ; set ; }
        public string Medida    { get ; set ;  }

        public bebidas( string marca, int cantidad)
        {

         this.Marca  = marca;
         this.Cantidad = cantidad;  
                 
        }

        public string ImprimirMarca(string marca)
        {
            string resultado;
            this.Marca = marca;

            if (marca == "Polarcita")
            {
                
                 resultado = "Excelente Cerveza"; 

            }    
            else 
            {
                 resultado = " Verifique la Cerveza";    

            }
            
            return resultado ;                

        }
    
        public string SeleccionarMedida(string lnop)
        {

                switch (lnop)
                {   
                    case "Polarcita":
                    this.Medida = "250 ML";
                    break;
                    case "Tercio":
                    this.Medida = "350 ML";
                    break;
                    default:
                    Console.WriteLine("Opcion No Valida");
                    break;
               }
               
               return this.Medida; 

        }
    

    }
}