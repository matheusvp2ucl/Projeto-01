using System;

class MainClass
{
    public static void Main(string[] args) {

        Console.Clear();

        while (true) {
            int valor = MSG.Menu();

            if (valor == 0) {
                break;
            }

            switch (valor) {
                case 1:
                    // Cadastra Dispesa
                    Dispesa cDispesa = MSG.MenuCadastroDispesa();
                    cDispesa.CadastraDispesa(cDispesa);
                    break;
                
                case 2:
                    // Cadastra nova Tag
                    Tag cTag = MSG.MenuCadastroTag();
                    cTag.CadastraTag(cTag);
                    break;
                
                case 3:
                    // Relatorios
                    Relatorio.RelatorioTotalTags();

                    Console.ReadLine();
                    break;

            }

        }

        

    }
}
