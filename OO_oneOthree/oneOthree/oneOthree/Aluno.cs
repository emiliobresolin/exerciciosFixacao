using System;
using System.Globalization;

namespace oneOthree
{
    class Aluno
    {
        public string Nome;
        public double NotaA, NotaB, NotaC;
        public double Media()
        {
            return  NotaA + NotaB + NotaC;
        }
        public double Falta()
        {
            double pontos = (NotaA + NotaB + NotaC) - 60;
            return Math.Abs(pontos);
        }
        public bool Aprovado()
        {
            
            if (Media() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
    }
}
