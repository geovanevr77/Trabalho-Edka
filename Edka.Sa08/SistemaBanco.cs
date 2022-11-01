using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema
    {
    class SistemaBanco {

        public enum TipoConta { ContaCorrente, ContaPoupanca };
        public class conta {

            public string Num;
            private double _saldo;
            public TipoConta Tipo;


            public conta(TipoConta tipo, string num) {

                this.Num = num;
                this.Tipo = tipo;
                _saldo = 0;

            }
            public void Sacar(double valor) {
                _saldo = _saldo - valor;
            }

            public void Depositar(double valor) {
                _saldo = _saldo + valor;
            }
            public double GetSaldo() {
                return _saldo;
            }
        }
    }
}
