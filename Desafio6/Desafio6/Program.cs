using Desafio6.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            List<Aluno> alunos = new List<Aluno>();
            Console.WriteLine("Bem Vindo Ao Console Mil Grau do CSV\n");

            #region Aluno1
            Console.WriteLine("Começa digitando o nome do primeiro Aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("\nAgora Digita a Idade do pilanta:");
            aluno.Idade = Console.ReadLine();
            Console.WriteLine("\nDigite a Nota do sem vergonha(reprova ele :c)");
            aluno.Nota = Console.ReadLine();

            alunos.Add(aluno);
            aluno = new Aluno();
            #endregion

            #region Aluno2
            Console.WriteLine("\nComeça digitando o nome do segundo Aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("\nAgora Digita a Idade do pilanta:");
            aluno.Idade = Console.ReadLine();
            Console.WriteLine("\nDigite a Nota do sem vergonha(reprova ele :c)");
            aluno.Nota = Console.ReadLine();

            alunos.Add(aluno);
            aluno = new Aluno();
            #endregion

            #region Aluno3
            Console.WriteLine("\nComeça digitando o nome do terceiro Aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("\nAgora Digita a Idade do pilanta:");
            aluno.Idade = Console.ReadLine();
            Console.WriteLine("\nDigite a Nota do sem vergonha(reprova ele :c)");
            aluno.Nota = Console.ReadLine();

            alunos.Add(aluno);
            #endregion

            alunos = PreparaAlunoExport(alunos);

            try
            {
                int count = 1;
                foreach (var aluninho in alunos)
                {
                    
                    string path = $@"C:\Users\gusta\Documents\alunos{count}.csv";
                    ExportToCSVFile(aluninho, path);
                    count++;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            Console.WriteLine("Dados salvos com Sucesso");
            Console.ReadKey();

        }
        private static List<Aluno> PreparaAlunoExport(List<Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                aluno.Nome = aluno.Nome + ";";
                aluno.Idade = aluno.Idade + ";";
                aluno.Nota = aluno.Nota + ";";
            }
            return alunos;
        }
        private static void ExportToCSVFile(Aluno aluno, string path)
        {
            string data = "Nome;Idade;Nota\r\n";
 
            data += aluno.Nome + aluno.Idade + aluno.Nota + "\r\n";
            
            File.AppendAllText(path, data);
        }
    }
}
