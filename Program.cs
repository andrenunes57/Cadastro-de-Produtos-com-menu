using System;
using System.Globalization;

namespace Program112
{
    class Program
    {
        static Produto p = new Produto();

        static void Main(string[] args)
        {
            string opcaousuario = ObterOpcaoUsuario();

            while (opcaousuario.ToUpper() != "X")
            {
                switch (opcaousuario)
                {
                    case "1":
                        CadastrarProduto();
                        break;
                    case "2":
                        AdicionarProdutos();
                        break;
                    case "3":
                        RemoverProdutos();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("DIGITE UMA DAS OPÇÕES DISPONÍVEIS!");
                }

                opcaousuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void CadastrarProduto()
        {
            Console.WriteLine();
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("PRODUTO CADASTRADO COM SUCESSO!");
            Console.WriteLine("Dados do produto: " + p);
        }

        private static void AdicionarProdutos()
        {
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("PRODUTOS ADICIONADOS COM SUCESSO!");
            Console.WriteLine("Dados atualizados: " + p);
        }

        private static void RemoverProdutos()
        {
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("PRODUTOS REMOVIDOS COM SUCESSO!");
            Console.WriteLine("Dados atualizados: " + p);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.WriteLine("1- Cadastrar Produto");
            Console.WriteLine("2- Adicionar Produtos");
            Console.WriteLine("3- Remover Produtos");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
