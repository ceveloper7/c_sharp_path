using System;
using System.Collections.Generic;
using System.Text;

namespace POOSample
{
    /**
     * En una clase abstracta se definen metodos y propiedades DEBEN estar presente en toda clase hijas
     * Por ejemplo: Encapsulamos el calculo de impuesto en una clase abstracta TaxCalculator
     * Todo TaxCalculator debe tener una Taza, un metodo para calcular el impuesto y un metodo para validar
     */
    public abstract class TaxCalculator
    {
        protected decimal TaxRate;
        protected TaxCalculator(decimal taxRate) {
            this.TaxRate = taxRate;
        }

        public decimal CalculateTax(decimal amount) {
            ValidateAmount(amount);
            return ApplyTax(amount);
        }

        protected virtual void ValidateAmount(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero");
        }

        protected abstract decimal ApplyTax(decimal amount);
    }
}
