using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDesafioDioLatest
{
    public class Calculadora
    {
        private  List<String> Listahistorico;
        private string data; 

        public Calculadora(string data)
        {

            Listahistorico = new List<String>();
            this.data = data; 

        }

        public int somar(int num1, int num2)
        {

            int res =  num1 + num2;
            Listahistorico.Insert(0,"Res: " + res + " Data: " + data);
            return res; 
            
        }

        public int  multiplicar(int num1, int num2)
        {

            int res = num1 * num2;
            Listahistorico.Insert(0, "Res: " + res + " Data: " + data);
            return res;


        }

        public int dividir(int num1, int num2)
        {
            int res = num1 / num2;
            Listahistorico.Insert(0, "Res: " + res + " Data: " + data);
            return res;


        }

        public List<String> historico()
        {
            List<string> res;
            Listahistorico.RemoveRange(3,Listahistorico.Count - 3);
            return Listahistorico;
        }


    }
}
