// See https://aka.ms/new-console-template for more information
using src;


        Calculadora c = new Calculadora();
        
        c.ExibirHistoricoOperacoes();

        c.Somar(1,2);
        c.Subtrair(1,2);
        c.Somar(2,2);
        c.ExibirHistoricoOperacoes();

        c.Multiplicar(1,2);
        c.Dividir(10,5);

        c.ExibirHistoricoOperacoes();
        c.Subtrair(1,2);
        c.ExibirHistoricoOperacoes();

        try
        {
            c.Dividir(10,0);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        c.ExibirHistoricoOperacoes();