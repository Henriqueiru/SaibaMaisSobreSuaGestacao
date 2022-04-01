using System;

namespace NewPrograma
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }
    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("Quer saber mais sobre sua gestação?");
      Console.WriteLine("1 - Saiba se sua gravidez será de risco ou não");
      Console.WriteLine("2 - Lista do que não comer durante o periodo de gravidez");
      Console.WriteLine("3 - Lista de bons alimentos para gestantes");
      Console.WriteLine("4 - Conheça mais sobre a formação do seu bebe");
      Console.WriteLine("5 - Como saber quando começou a gestação?");
      Console.WriteLine("6 - Sair do programa");
      Console.WriteLine("---------------------------------------------------------");
      Console.WriteLine("Escolha uma das opções acima digitando o numero correspondente");
      short res = short.Parse(Console.ReadLine());

      switch (res)
      {
        case 1: Parto(); break;
        case 2: BadList(); break;
        case 3: GoodList(); break;
        case 4: Formacao(); break;
        case 5: InicioGestacao(); break;
        case 6: System.Environment.Exit(0); break;
        default: Menu(); break;
      }
    }

    static void Parto()
    {
      Console.Clear();
      Console.WriteLine("Quantos meses faz que voce esta gravida?");
      int Meses = int.Parse(Console.ReadLine());
      Console.WriteLine("");
      if (Meses >= 9)
      {
        Console.WriteLine("Parto normal");
      }
      else if (Meses >= 7)
      {
        Console.WriteLine("Parto parcialmente de risco");
      }
      else
      {
        Console.WriteLine("Parto de risco");
      }
      Console.ReadKey();
      Menu();
    }

    static void BadList()
    {
      Console.Clear();
      Console.WriteLine("Lista do que não é bom comer na gravidez: ");
      Console.WriteLine("");
      Console.WriteLine("Ovos crus ou mal cozidos; Carne vermelha ou carne de peixe crua ou mal cozida; Peixe cru, ostras, mariscos e outros frutos do mar; Leite e derivados não pasteurizados, como queijos como o brie e o camembert");
      Console.ReadKey();
      Menu();
    }
    static void GoodList()
    {
      Console.Clear();
      Console.WriteLine("Lista do que é bom comer na gravidez: ");
      Console.WriteLine("");
      Console.WriteLine("A alimentação na gravidez tem que ser rica em cereais integrais, legumes, frutas, leite e derivados, leguminosas, peixe e carne magra, como peru e frango. É importante que os alimentos sejam preparados grelhados ou ao vapor, evitando as frituras, os alimentos processados, os alimentos congelados e as comidas prontas.");
      Console.ReadKey();
      Menu();
    }
    static void Formacao()
    {
      Console.Clear();
      Console.WriteLine("Lista de estagios da formação de um bebe");
      Console.WriteLine("1 - Na quarta semana de gravidez");
      Console.WriteLine("2 - Entre a 9 e 12 semana");
      Console.WriteLine("3 - Entre a 15 e 16 semana");
      Console.WriteLine("4 - Entre a 27 e 30 semana");
      Console.WriteLine("5 - Retorne para o Menu");
      Console.WriteLine("--------------------------------------------");
      Console.WriteLine("Escolha uma das opções acima");
      short num = short.Parse(Console.ReadLine());
      switch (num)
      {
        case 1: Quarta(); break;
        case 2: Nona(); break;
        case 3: Quinzena(); break;
        case 4: Ultimas(); break;
        case 5: Menu(); break;
        default: Formacao(); break;
      }
      Console.ReadKey();
    }
    static void InicioGestacao()
    {
      Console.Clear();
      Console.WriteLine("Qual foi a ultima vez que voce menstruou em semanas? Escreva:");
      float Semanas = float.Parse(Console.ReadLine());
      Console.WriteLine("");
      float Meses = Semanas / 4;
      Console.WriteLine($"Voce esta gravida de {Meses} meses");
      Console.ReadKey();
      Menu();

    }
    static void Quarta()
    {
      Console.Clear();
      Console.WriteLine("Com quatro semanas, o embrião apresenta-se do tamanho de um grãozinho de arroz. O coração começa a bater a partir dessa semana. Já é possível observar os locais onde serão formados os braços e pernas.");
      Console.ReadKey();
      Formacao();
    }
    static void Nona()
    {
      Console.Clear();
      Console.WriteLine("Nessa etapa de desenvolvimento, o rosto já está praticamente formado, sendo possível observar, por exemplo, os olhos com pálpebras. O cérebro inicia seu funcionamento nessa etapa, e o bebê já apresenta movimento dos braços e pernas.");
      Console.ReadKey();
      Formacao();
    }

    static void Quinzena()
    {
      Console.Clear();
      Console.WriteLine("Inicia-se o engrossamento da pele. Cílios e sobrancelhas podem ser observados. A mãe consegue perceber os movimentos do bebê.");
      Console.ReadKey();
      Formacao();
    }
    static void Ultimas()
    {
      Console.Clear();
      Console.WriteLine("27ª semana à 30ª semana: Nessa fase, o bebê é capaz de perceber a luz fora do útero. Vale destacar que formas e cores só serão percebidas após o nascimento. Ele também é capaz de identificar sons. A partir desse momento, o bebê está formado, porém ainda não está maduro o suficiente para nascer.");
      Console.ReadKey();
      Formacao();
    }

  }
}