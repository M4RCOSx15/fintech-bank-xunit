using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FintechBank.App
{
    public class EmprestimoService
    {
        public float CalcularValorParcela(decimal valorTotal, int parcelas, int scoreCredito)
        {
            if(scoreCredito >= 700)
            {
                return valorTotal * 1.05;
            }
            if(scoreCredito >=500 && scoreCredito <= 699)
            {
                return valorTotal * 1.12;
            }
            return (valorTotal * 1.20) / parcelas;
        }

        public bool AprovarEmprestimo(decimal rendaMensal, decimal valorParcela)
        {
            if(valorParcela <=rendaMensal * 0.30m)
            {
                return true;
            }
        }
    }
}