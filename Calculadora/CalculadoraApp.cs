using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraApp
    {

        
        private List<string> historico;
        private string data;

        public CalculadoraApp(string data){
            historico = new List<string>();
            this.data = data; 
        }
        
        public int Somar(int num1, int num2){
            historico.Insert(0, "Resultado: " + (num1 + num2) + " Data: " + data);
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2){
            historico.Insert(0, "Resultado: " + (num1 - num2) + " Data: " + data);
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2){
            historico.Insert(0, "Resultado: " + (num1 * num2) + " Data: " + data);
            return num1 * num2;
        }

        public int Dividir(int num1, int num2){
            historico.Insert(0, "Resultado: " + (num1 / num2) + " Data: " + data);
            return num1 / num2;
        }

        public List<String> Historico(){
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }

    }
}