using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroAlunos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno(nome:"Jose Gabriel", idade:20, curso:"Big Data");

            Console.WriteLine($"Nome: {aluno1.Nome}");
            Console.WriteLine($"Idade: {aluno1.Idade}");
            Console.WriteLine($"Curso: {aluno1.Curso}");
           
            Console.WriteLine("-------------------------------");

            aluno1.Curso = "Sistemas Inteligentes";

            Console.WriteLine($"Curso: {aluno1.Curso}");


        }
    }
}
