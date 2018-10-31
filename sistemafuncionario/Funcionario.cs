using System;
namespace sistemafuncionario
{
    public class Funcionario
    {
        public String Nome { get; set; }
        public double Salario { get; set; }


        string nome;

        public void setNome(string nome){
            this.nome = nome;
        }


        public double novoSalario(){
            if(Salario <= 1000){
                Salario += Salario * 0.3;
            }else if (Salario <= 1500){
                Salario += Salario * 0.2;
            }else if (Salario > 1500){
                Salario += Salario * 0.1;
            }
            return Salario;
        }

        public Funcionario()
        {
        }
    }
}
