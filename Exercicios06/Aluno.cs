using System;

namespace Exercicio02
{
    class Aluno
    { 
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;


        public double NotaFinal(){
            return (Nota1+Nota2+Nota3);
        }

        public override string ToString()
        {
            if(NotaFinal() >= 60){
                return "NOTA FINAL = "
                + NotaFinal()
                +"\nAPROVADO";
            }else{
                
                return "NOTA FINAL = "
                + NotaFinal()
                +"\nREPROVADO \nFALTAM "
                +(60 - NotaFinal()).ToString("F2")
                +" PONTOS";
            }
        }
    }
}