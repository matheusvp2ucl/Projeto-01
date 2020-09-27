using System;
using System.Collections.Generic;
using System.Threading;

[Serializable]
class Dispesa
{

    private List<Dispesa> listaDispesa;
    private string nome;
    private string tag;
    private double valor;

    public string Nome {
        get { return nome; }
        set { nome = value; }
    }

    public string Tag {
        get { return tag; }
        set { tag = value; }
    }

    public double Valor {
        get { return valor; }
        set { valor = value; }
    }

    public void CadastraDispesa(Dispesa obj) {
        // Verifica o null no Nome, para não cadastrar !
        if (!String.IsNullOrEmpty(obj.Nome)) {
            listaDispesa = DaoDispesas.SelectAllDispesas();
            listaDispesa.Add(obj);
            DaoDispesas.InsertDispesas(listaDispesa);
            Console.WriteLine("\nDispesa Cadastrada!");
            Thread.Sleep(2500);
        } else {
            Console.WriteLine("\nDispesa não Cadastrada!");
            Thread.Sleep(2500);
        }
    }

}

[Serializable]
class Tag
{

    private List<Tag> listaTags;
    private string nomeTag;

    public string NomeTag {
        get { return nomeTag; }
        set { nomeTag = value; }
    }

    public void CadastraTag(Tag obj) {

        if (!String.IsNullOrEmpty(obj.NomeTag)) {
            listaTags = DaoTags.SelectAllTags();
            listaTags.Add(obj);
            DaoTags.InsertTags(listaTags);
            Console.WriteLine("\nTag Cadastrada!");
            Thread.Sleep(2000);
        } else {
            Console.WriteLine("\nTag não Cadastrada!");
            Thread.Sleep(2000);
        }
    }

    public void ListaTags() {
        listaTags = DaoTags.SelectAllTags();
        for (int i = 0; i < listaTags.Count; i++) {
            int pos = i + 1;
            Console.WriteLine(pos + " - " + listaTags[i].NomeTag);
        }
    }

    public string TagEscolhida(int pos) {
        listaTags = DaoTags.SelectAllTags();
        return listaTags[pos - 1].NomeTag;
    }

}


[Serializable]
class Relatorio
{
    public static void RelatorioTotal() {
        List<Dispesa> listaDispesas = DaoDispesas.SelectAllDispesas();
        foreach (Dispesa cDispesa in listaDispesas) {
            Console.WriteLine("Valor: {0}", cDispesa.Valor);
        }
    }

    public static void RelatorioTotalTags() {
        List<Tag> listaTags = DaoTags.SelectAllTags();
        List<Dispesa> listaDispesas = DaoDispesas.SelectAllDispesas();

        Console.Clear();
        Console.WriteLine("### Relatorio por Tags ###\n");

        foreach ( Tag cTag in listaTags ) {
            double soma = 0;

            foreach ( Dispesa cDispesa in listaDispesas ) {
                if ( cTag.NomeTag == cDispesa.Tag ) {
                    soma += cDispesa.Valor;
                }
            }
            Console.WriteLine("Tag: {0} - Total: {1}", cTag.NomeTag, soma);
        }

        Console.WriteLine("");
    }

}

