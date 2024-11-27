using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente (int numConta, decimal saldoInicial){

            NumConta = numConta;
            Saldo = saldoInicial;
        }
        public int NumConta { get; set; }

        private decimal Saldo;

        public void Sacar(decimal valor) {     
            if(Saldo >= valor){

                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            } else {
                Console.WriteLine("O valor a ser sacado é maior que o saldo disponivel.");
            }
        }

        public void ExibirSaldo(){
            Console.WriteLine($"Seu saldo é de {Saldo}");
        }
    }
}