using System.Collections.Concurrent;

Team timeAtaque = new Team();
timeAtaque.qtd_Soldados = 500;
timeAtaque.ataca = true;


Team timeDefesa = new Team();
timeDefesa.qtd_Soldados = 500;
timeDefesa.ataca = false;


Team vencedor = new Team();


Battle battle = new Battle();
vencedor = battle.batalha(timeAtaque, timeDefesa);
Console.WriteLine(vencedor.qtd_Soldados);


monteCarlo(10000);


void monteCarlo(int n)
{
    int countA = 0;
    for (int i = 0; i < n; i++)
    {
        Team timeAtaque = new Team();
        timeAtaque.qtd_Soldados = 1000;
        timeAtaque.ataca = true;

        Team timeDefesa = new Team();
        timeDefesa.qtd_Soldados = 500;
        timeDefesa.ataca = false;

        Team vencedor = new Team();

        vencedor = battle.batalha(timeAtaque, timeDefesa);
        if (vencedor.ataca == true)
        {
            Console.WriteLine("Ataque: " + vencedor.qtd_Soldados);
            Console.WriteLine("Defesa: " + timeDefesa.qtd_Soldados + "\n\n");
            countA++;
        }

        else if(vencedor.ataca == false)
        {
            Console.WriteLine("Defesa: " + vencedor.qtd_Soldados);
            Console.WriteLine("Ataque: " + timeAtaque.qtd_Soldados + "\n\n");
        }
    }
    
    Console.WriteLine(countA / (float)n);
}