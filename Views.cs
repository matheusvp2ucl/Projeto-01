using System;
using System.Threading;

class MSG
{

    public static int Menu() {
        Console.Clear();

        Console.WriteLine("#### Controle de Gasto ####\n");
        Console.WriteLine("1 - Cadastrar Dispesa");
        Console.WriteLine("2 - Cadastrar Nova Tag");
        Console.WriteLine("3 - Relatorios");
        Console.WriteLine("0 - Sair do Programa\n");

        Console.Write("Informe sua opção: ");
        int valor = int.Parse(Console.ReadLine());

        if (valor >= 0 && valor <= 3) {
            return valor;
        } else {
            Console.WriteLine("Opção Incorreta ! Informe novamente !");
            Thread.Sleep(1500);
            return MSG.Menu();
        }
    }

    public static Dispesa MenuCadastroDispesa() {
        Console.Clear();
        // Instacia as Classes Necessarias 
        Dispesa cDispesa = new Dispesa();
        Tag cTag = new Tag();

        // Nome da Dispesa
        Console.WriteLine("### Cadastro da Dispesa ###\n");
        Console.Write("Nome da Dispesa: ");
        string nome = Console.ReadLine();

        // Lista-Escolhe a Tag da Dispesa
        Console.WriteLine();
        cTag.ListaTags();
        Console.WriteLine();

        Console.Write("Informe qual Tag: ");
        int opx = int.Parse(Console.ReadLine());
        string tag = cTag.TagEscolhida(opx);


        // Valor da Dispesa
        Console.WriteLine();
        Console.Write("Valor da Dispesa: ");
        double valor = double.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("### Resumo da Dispesa ###");
        Console.WriteLine();
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Tag: " + tag);
        Console.WriteLine("Valor: " + valor);

        Console.Write("\nDeseja Confirma Gravação da Dispesa? [s/n]: ");
        string ok = Console.ReadLine().ToLower();

        if (ok != "s") {
            cDispesa.Nome = null;
        } else {
            cDispesa.Nome = nome;
            cDispesa.Tag = tag;
            cDispesa.Valor = valor;
        }

        return cDispesa;

    }


    public static Tag MenuCadastroTag() {
        Console.Clear();
        Tag cTag = new Tag();

        Console.WriteLine("### Cadastro da Tag ###\n");
        Console.Write("Nome da Tag: ");
        string nome = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("### Resumo da Tag ###");
        Console.WriteLine();
        Console.WriteLine("Nome: " + nome);

        Console.Write("\nDeseja Confirma Gravação da Dispesa? [s/n]: ");
        string ok = Console.ReadLine().ToLower();

        if (ok != "s") {
            cTag.NomeTag = null;
        } else {
            cTag.NomeTag = nome;
        }

        return cTag;
    }


} //  FIM CLASSE MSG