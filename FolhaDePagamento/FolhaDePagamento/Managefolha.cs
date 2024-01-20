using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using static FolhaDePagamento.FolhaPGTO;
using static FolhaDePagamento.managcad;


namespace FolhaDePagamento
{
    internal class Managefolha
    {
        FolhaPGTO calcul = new FolhaPGTO();


        public class Folha
        {            
            public double vr = 0;
            public double va = 0;
            public double vt = 0;
            public double salario = 0;
            public double inss = 0;
            public double irrf = 0;
                        
        }
        public class DMF
        {

            public Folha CalculoINSS(double salario)
            {
                Folha calc = new Folha();
                double inss = 0;

                if (salario<= 1302.00)
                {
                    inss = salario * 0.75;
                }
                else if(salario <= 2571.29)
                {
                    inss = salario * 0.9;
                }
                else if(salario <= 3856.94)
                {
                    inss = salario * 0.12;
                }
                else if (salario <= 7507.49)
                {
                    inss = salario * 0.14;
                }
                else
                {
                    inss = 1051.05;
                }
                return calc;
            }
            public void CalculoIRRF(double salario)
            {
                Folha calc = new Folha();
                double irrf = 0;

                if (salario <= 1903.98)
                {
                    irrf = 0;
                }
                else if(salario <= 2826.65)
                {
                    irrf = (salario * 0.075) - 142.80;
                }
                else if(salario <= 3751.05)
                {
                    irrf = (salario * 0.15) - 354.080;
                }
                else if (salario <= 4664.68)
                {
                    irrf = (salario * 0.225) - 636.13;
                }
                else
                {
                    irrf = (salario * 0.275) - 869.36;
                }
            }
            public void Beneficios(double vr, double va, double vt)
            {
                FolhaPGTO benef = new FolhaPGTO();

                

            }
        }
    }
}
