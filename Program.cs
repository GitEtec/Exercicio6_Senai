using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercicio 2 Senai
             Efetue o cálculo da quantidade de litros de combustível gasta
             em uma viagem, utilizando 12km por litro.
             Usuario fornece: tempo gasto na viagem(h), velocidade média.
             Obtendo : Distancia = tempo * velocidade, litros usados = distancia/12
             O programa apresenta: Velocidade média,tempo gasto na viagem, distancia
             quant de litros utilizada na viagem.*/

            float qnt_litros, tmp_viagem, vel_md, dist, l_usados;
            Console.Write("Quantidade de litros de combustivel: ");
            qnt_litros = float.Parse(Console.ReadLine());
            Console.Write("Tempo gasto na viagem: ");
            tmp_viagem = float.Parse(Console.ReadLine());
            Console.Write("Velocidade média do veiculo: ");
            vel_md = float.Parse(Console.ReadLine());
            dist = tmp_viagem * vel_md;
            l_usados = dist / 12;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Velocidade Média: " + vel_md + "KM");
            Console.WriteLine("Tempo gasto na viagem: " + tmp_viagem + "h");
            Console.WriteLine("Distância: " + dist+"KM");
            Console.WriteLine("Litros usados: " + l_usados+"L");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine();
            Console.Write("Tecla <enter>");
            Console.ReadLine();
        }
    }
}
