using System;
using System.Globalization;

namespace ExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A expressão condicional ternária é uma estrutura opcional ao if-else quando se deseja decidir um
             VALOR com base em uma condição
            
             SINTAXE: (condição) ? valor_se_verdadeiro : valor_se_falso
            
             EXEMPLOS:
            
             (2>4) ? 50 : 80
            No exemplo acima a condição da como falso pois 2 não é maior do que 4 então o valor 80 será o resultado
            (10 != 3) ? "Maria" : "Alex"
            No exemplo acima a condição da como verdadeira pois 10 é diferente de 3 então o valor "Maria" será o resultado*/

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            if (preco < 20.0) /*Estrutura if-else padrão para calcular um desconto baseado no preco*/
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));

            /*No caso do exemplo acima temos como alternativa utilizar a expreção condicional ternária ficando:*/
            Console.Write("Novo Preço: ");
            double preco1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto1 = (preco1 < 20.0) ? preco1 * 0.1 : preco1 * 0.05; /*Estrutura condicional ternário que substitui
            a estrutura if-else tornando o código mais legivel e simples cumprindo o mesmo papel da estrutura if-else.*/

            Console.WriteLine(desconto1.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
