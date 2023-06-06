public class Battle
{
    public Team batalha(Team timeAtaque, Team timeDefesa)
    {

        List<int> tres = new List<int>();
        List<int> ordenadaAtaque = new List<int>();
        List<int> ordenadaDefesa = new List<int>();
        Random rand = new Random();


        

        while (timeAtaque.qtd_Soldados > 1 && timeDefesa.qtd_Soldados > 0) // condição para parar a guerra
        {
            for (int i = 0; i < timeAtaque.qtd_Soldados; i++) // jogando dados para o time de ataque
            {
                int dadoValue = rand.Next(6) + 1;
                timeAtaque.listaValues.Add(dadoValue);
            }

            for (int j = 0; j < timeDefesa.qtd_Soldados; j++) // jogando dados para o time de defesa
            {
                int dadoValue = rand.Next(6) + 1;
                timeDefesa.listaValues.Add(dadoValue);
            }


            for (int i = 0; i < timeAtaque.listaValues.Count - 4; i += 3) // separando de 3 em 3 e ordenando - ATAQUE
            {
                if (timeAtaque.qtd_Soldados == 2)
                {
                    tres.Add(timeAtaque.listaValues[i]);
                    tres.Add(timeAtaque.listaValues[i + 1]);
                }

                if (timeAtaque.qtd_Soldados == 1)
                {
                    timeDefesa.score++;
                    return timeDefesa;
                    // break;
                }
                else
                {
                    tres.Add(timeAtaque.listaValues[i]);
                    tres.Add(timeAtaque.listaValues[i + 1]);
                    tres.Add(timeAtaque.listaValues[i + 2]);
                }
                tres.OrderByDescending(a => a);
                for (int j = 0; j < tres.Count - 1; j++)
                {
                    ordenadaAtaque.Add(tres[j]);
                }

                tres.Clear();
            }

            for (int i = 0; i < timeDefesa.listaValues.Count - 4; i += 3) // separando de 3 em 3 e ordenando - DEFESA
            {
                if (timeDefesa.qtd_Soldados == 0)
                {
                    timeAtaque.score++;
                    return timeAtaque;
                    // break;
                }
                else if (timeDefesa.qtd_Soldados == 2)
                {
                    tres.Add(timeDefesa.listaValues[i]);
                    tres.Add(timeDefesa.listaValues[i + 1]);
                }

                else
                {
                    tres.Add(timeDefesa.listaValues[i]);
                    tres.Add(timeDefesa.listaValues[i + 1]);
                    tres.Add(timeDefesa.listaValues[i + 2]);
                }

                tres.OrderByDescending(d => d);
                for (int j = 0; j < tres.Count - 1; j++)
                {
                    ordenadaDefesa.Add(tres[j]);
                }

                tres.Clear();
            }

            // troca a lista de todos os valores por ordenados de 3 em 3

            timeAtaque.listaValues = ordenadaAtaque;
            timeDefesa.listaValues = ordenadaDefesa;



            if (timeDefesa.qtd_Soldados > timeAtaque.qtd_Soldados) // se a qtd de defesa for maior q a qtd de ataque
            {
                timeDefesa.score += timeDefesa.qtd_Soldados - timeAtaque.qtd_Soldados; // adiciona ao score os soldados a mais


                if (timeDefesa.qtd_Soldados <= 0)
                {
                    Console.WriteLine("Vitoria do Ataque");
                }

                if (timeAtaque.qtd_Soldados <= 1)
                {
                    Console.WriteLine("Vitoria do Defesa");
                }

                else
                {
                    for (int i = 0; i < timeAtaque.qtd_Soldados; i++) // percorre a lista dos dados e compara valores dos dados
                    {
                        if (timeDefesa.listaValues[i] > timeAtaque.listaValues[i]) //defesa ganha
                        {
                            timeDefesa.score += 1;
                            timeAtaque.qtd_Soldados -= 1;
                            if (timeAtaque.qtd_Soldados <= 0)
                            {
                                break;
                                return timeDefesa;
                            }
                        }

                        else if (timeAtaque.listaValues[i] > timeDefesa.listaValues[i]) //ataque ganha
                        {
                            timeAtaque.score += 1;
                            timeDefesa.qtd_Soldados -= 1;
                            if (timeDefesa.qtd_Soldados <= 0)
                            {
                                return timeAtaque;
                                break;
                            }
                        }

                        else if (timeAtaque.listaValues[i] == timeDefesa.listaValues[i]) // empate
                        {
                            timeDefesa.score += 1;
                            timeAtaque.qtd_Soldados -= 1;
                            if (timeAtaque.qtd_Soldados <= 0)
                            {
                                return timeDefesa;
                                break;
                            }
                        }
                    }
                }
            }

            else if (timeAtaque.qtd_Soldados > timeDefesa.qtd_Soldados) // se a qtd de ataque for maior q a qtd de defesa
            {
                timeAtaque.score += timeAtaque.qtd_Soldados - timeDefesa.qtd_Soldados; // adiciona ao score os soldados a mais


                for (int i = 0; i < timeDefesa.listaValues.Count - 1; i++) // percorre a lista dos dados e compara valores dos dados
                {
                    if (timeDefesa.listaValues[i] > timeAtaque.listaValues[i]) //defesa ganha
                    {
                        timeDefesa.score += 1;
                        timeAtaque.qtd_Soldados -= 1;
                        if (timeAtaque.qtd_Soldados <= 0)
                        {
                            break;
                            return timeDefesa;
                        }
                    }

                    else if (timeAtaque.listaValues[i] > timeDefesa.listaValues[i]) //ataque ganha
                    {
                        timeAtaque.score += 1;
                        timeDefesa.qtd_Soldados -= 1;
                        if (timeDefesa.qtd_Soldados <= 0)
                        {
                            return timeAtaque;
                             break;
                        }
                    }

                    else if (timeAtaque.listaValues[i] == timeDefesa.listaValues[i]) //empate
                    {
                        timeDefesa.score += 1;
                        timeAtaque.qtd_Soldados -= 1;
                        if (timeAtaque.qtd_Soldados <= 0)
                        {
                            return timeDefesa;
                            break;
                        }
                    }
                }
            }

            // Console.WriteLine($"Soldados Ataque: {timeAtaque.qtd_Soldados}");
            // Console.WriteLine($"Soldados Defesa: {timeDefesa.qtd_Soldados}\n\n");

           
        }
        return null;
        
    }
}