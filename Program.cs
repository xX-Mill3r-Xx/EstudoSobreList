using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoSobreList
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Maneira para se instanciar uma lista em c#
             Obs.: devo incluir o using System.Collections.Generic caso não esteja incluso*/

            List<string> lista = new List<string>();// Aqui uma lista vazia;

            //Como add os elementos em uma lista;
            /*Para add um elemento a lista usamos a operação .Add()*/
            Console.WriteLine("Add elementos a lista");
            lista.Add("Miller");
            lista.Add("Mateus");
            lista.Add("Juninho");

            //Imprimindo os elementos da lista;
            //Console.WriteLine(lista[0]);

            //Imprimindo todos os elementos de uma lista usando o foreach;
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }

            //Metodo Insert;
            /*O Metodo Insert serve para inserir um obj a lista em uma determinada posição;
             Note que, após usarmos o metodo Insert neste caso, ele assume o lugar da 
            posição 2 da nossa lista; */
            Console.WriteLine("Inserindo elementos na lista usando o metodo Insert");
            lista.Insert(2, "New Position, 'Assumindo a antiga posição 2'");
            Console.WriteLine("--------------------------");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------");
            //Propiedade Count();
            /*A propiedade Count() serve para mostrar quantos obj estão contidos na lista;*/
            Console.WriteLine("Propiedade Count()");
            Console.WriteLine($"Objetos na lista {lista.Count()}");

            Console.WriteLine("--------------------------");
            //Função .Find() e .FindLast();
            /* .Find Serve para encontrar a primeira determinada Ocorrencia na lista;*/
            Console.WriteLine("Função Find()");
            string s = lista.Find(Teste);
            Console.WriteLine($"Primeiro com a Letra 'N' = {s}");
            /*Aqui declaramos uma função boleana que retornara verdadeira
             caso s1 encontre a primeira ocorrencia da letra N*/
            bool Teste(string s1)
            {
                return s1[0] == 'N';
            }

            /*Obs.: é possivel trocar a função Bool que criamos por uma expressão Lambida 
             * que fica da seguinte forma; */
            string exemploLambida = lista.Find(x => x[0] == 'M');
            Console.WriteLine($"Primeiro com a Letra 'M' = {exemploLambida}");
            Console.WriteLine("--------------------------");

            //Usando a função .FindLast()
            /*.FindLast() encontra a ultima determinada ocorrencia na lista; */
            string exemploLambida2 = lista.FindLast(x => x[0] == 'M');
            Console.WriteLine($"Ultima Ocorrencia de 'M' = {exemploLambida2}");
            Console.WriteLine("--------------------------");

            //Função .FindIndex() e .FindLastIndex();
            /*Encontrar a primeira e a ultima posição de um elemento na lista*/
            int exemploLambida3 = lista.FindIndex(x => x[0] == 'M'); //Obs.: int por se tratar de uma posição;
            Console.WriteLine($"Primeira posição da letra M = {exemploLambida3} que corresponde a: {exemploLambida}");
            // .FindLastIndex();
            int exemploLambida4 = lista.FindLastIndex(x => x[0] == 'J');
            Console.WriteLine($"Ultima posição da letra J = {exemploLambida4} " +
                $"que corresponde a: {lista.FindLast(x1 => x1[0] == 'J')}");
            Console.WriteLine("--------------------------");

            //Função .FindAll();
            /*Filtrar a Lista com base em um predicato; */
            List<string> lista2 = lista.FindAll(x => x.Length <= 6);
            foreach(string obj in lista2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------------------");

            //Função .Remove();
            Console.WriteLine("Função Remove()");
            lista.Remove("Miller");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------------------");

            //Função .RemoveAll();
            Console.WriteLine("Função RemoveAll()");
            lista.RemoveAll(x => x[0] == 'M');
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------------------");

            //RemoveAt()
            Console.WriteLine("RemoveAt");
            lista.RemoveAt(1);
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
