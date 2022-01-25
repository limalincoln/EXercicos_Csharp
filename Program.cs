using System;
namespace Media_nota
{
    class program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, Media;

            string Aluno;


            Console.WriteLine("Digite o Nome do Aluno: ");
            Aluno = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Segunda nota : ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota : ");
            nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota : ");
            nota4 = float.Parse(Console.ReadLine());    

            Console.WriteLine("Sua Média é de :");
            Media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine(Media);

            if(Media == 6)
            {
                Console.WriteLine( "Parabéns " +Aluno+ "! Você foi aprovado!! Mas se esforce mais no próximo ano!!");
            }

            else if(Media == 5)
            {
                Console.WriteLine(Aluno+ " Você está de recuperação!! "  );
               
            }
              
            else if(Media >= 7)
            {
                Console.WriteLine("Parabens " +Aluno+ " o seu ano foi incrivel! Você foi Aprovado!!");

            }
            else
            {
                Console.WriteLine(Aluno+ " Infelizmente você foi reprovado!");
            }
        }
    }
}
