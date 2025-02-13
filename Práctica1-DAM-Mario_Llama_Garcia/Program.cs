using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Práctica1_DAM_Mario_Llama_Garcia
{
    /// <summary>
    /// Clase de ejemplo 1
    /// </summary>
    internal class Ejemplo1
    {
        /// <summary>
         /// Es el numero
        /// </summary>
        public int numero;
        /// <summary>
        /// Es un texto
        /// </summary>
        public String texto;
        /// <summary>
        /// Este constructo iguala numero a n
        /// </summary>
        /// <param name="n"> n es el valor para numero</param>
        public Ejemplo1(int n)
        {
            this.Funcion3();
            numero = n;
        }
        /// <summary>
        /// Este texto es de ejemplo de la función1
        /// </summary>
        /// <param name="txt"> recibe el texto</param>
        /// 
        public void Funcion1(String txt)
        {
            texto = txt;
        }
        /// <summary>
        /// Texto de ejemplo
        /// </summary>
        /// <param name="n"> retorna un número</param>
        public int Funcion2()
        {
            return numero;
        }
        /// <summary>
        /// Texto de ejemplo
        /// </summary>
        /// <param name="n"> retorna un número</param>
        
        private String Funcion3()
        {
            return texto;
        }

        
    }
}
