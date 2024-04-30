using atv_senai.classes;
using System;

namespace atv_senai
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar o Nome: ");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar o Endereço: ");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou jurídica (j): ");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Jurídica --------");
                Console.WriteLine("Nome ..........: " + pj.nome);
                Console.WriteLine("Endereco ......: " + pj.endereco);
                Console.WriteLine("CNPJ ..........: " + pj.cnpj);
                Console.WriteLine("RG ............: " + pj.ie);
                Console.WriteLine("Valor de Compra: " + pj.valor);
                Console.WriteLine("Imposto .......: " + pj.valor_imposto);
                Console.WriteLine("Total a Pagar..: " + pj.total);
                Console.WriteLine("---------------------------------"); 
            } else if (var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("Nome ..........: " + pf.nome);
                Console.WriteLine("Endereco ......: " + pf.endereco);
                Console.WriteLine("CPF ...........: " + pf.cpf);
                Console.WriteLine("RG ............: " + pf.rg);
                Console.WriteLine("Valor de Compra: " + pf.valor);
                Console.WriteLine("Imposto .......: " + pf.valor_imposto);
                Console.WriteLine("Total a Pagar..: " + pf.total);
                Console.WriteLine("-------------------------------");
            } else
            {
                Console.WriteLine("Foi informado um dado errado, tente novamente! ;)");
            }
        }
    }
}