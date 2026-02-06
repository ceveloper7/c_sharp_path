using System;
using System.Collections.Generic;
using System.Text;

namespace Overriden
{
    public class Sale
    {
        // amounts of sales
        private decimal[] _amount;
        // nro de amount sales
        private int _n;
        // nro max amount sales
        private int _end;

        // n -> numero del array de cantidades
        public Sale(int n) {
            this._n = n;
            _amount = new decimal[n];
            _end = 0;
        }

        // agregar elementos
        public void Add(decimal amount) {
            if (_end < _n) {
                _amount[_end] = amount;
                _end++;
            }
        }

        // metodo retorna el total de las ventas y que se puede sobrescribir
        public virtual decimal GetTotal() {
            decimal result = 0;
            int i = 0;
            while (i < _amount.Length) {
                result += _amount[i];
                i++;
            }

            return result;
        }
    }
}
