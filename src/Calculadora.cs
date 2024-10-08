using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace src
{
    public class Calculadora
    {
        private List<string> _Historico;

        public Calculadora()
        {
            _Historico = new List<string>();
        }

        public int Somar(int val1, int val2)
        {
            var resultado = val1 + val2;
            AddOperacaoHistorico(OperadoresEnum.Somar, val1, val2, resultado);
            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            var resultado = val1 - val2;
            AddOperacaoHistorico(OperadoresEnum.Subtrair, val1, val2, resultado);
            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            var resultado = val1 * val2;
            AddOperacaoHistorico(OperadoresEnum.Multiplicar, val1, val2, resultado);
            return resultado;
        }

        public int Dividir(int val1, int val2) 
        {
            try
            {
                var resultado = val1 / val2;
                AddOperacaoHistorico(OperadoresEnum.Dividir, val1, val2, resultado);
                return resultado;
            }
            catch(Exception)
            {
                throw new DivideByZeroException($"Não é possível realizar divisão por 0. Operação solicitada: {val1} / {val2}.");
            }
        }

        public List<string> Historico()
        {
            return _Historico;
        }

        private void AddOperacaoHistorico(OperadoresEnum oper, int val1, int val2, int resultado)
        {
            var sinal = "";
            switch (oper)
            {
                case OperadoresEnum.Somar:
                sinal = "+";
                break;
                case OperadoresEnum.Subtrair:
                sinal = "-";
                break;
                case OperadoresEnum.Multiplicar:
                sinal = "*";
                break;
                case OperadoresEnum.Dividir:
                sinal = "/";
                break;
            }

            string msg = $"{oper}: {val1} {sinal} {val2} = {resultado}";
            Console.WriteLine(msg);
            //o histórico armazena só até as 3 últimas operações.
            if(_Historico.Count==3)
            {
                _Historico.RemoveAt(0);
            }
            _Historico.Add(msg);
        }

        public void ExibirHistoricoOperacoes()
        {
            if(_Historico.Count>0)
            {
                Console.WriteLine("Exibindo o histórico das 3 últimas operações:");
                foreach (string oper in _Historico)
                {
                    Console.WriteLine(oper);
                }
            }
        }
    }
}