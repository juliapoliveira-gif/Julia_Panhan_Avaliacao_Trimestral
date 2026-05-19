using System.ComponentModel.Design;
using System.Diagnostics;

Console.OutputEncoding =  System.Text.Encoding.UTF8;
Console.WriteLine("🧙‍♀️ Você está na forja de Thorin!" +
    "\nAjude a somar o valor dos equipamentos." +
    "\n⚠️Se digitar letras (goblins), o valor será 0.\n");

int resultado = somarequipamentos(lermoeda(), lermoeda());
Console.WriteLine("🪙 preço total dos equipamentos:" + resultado);
int somarequipamentos(int valor1, int valor2)
{
    return valor1 + valor2;
}
//Fazer subtração, multiplicação e divisão

int lermoeda()
{
    Console.WriteLine("Digite o valor:  ");
    if (int.TryParse(Console.ReadLine()!, out int n))
    {
        return n;
    }
    else
    {
        Console.WriteLine("Entrada inválida! Goblins não podem usar letras aqui!");
        return 0;
    }
}
//Fazer subtração, multiplicação e divisão
int lermoedas()

{
    Console.WriteLine("Digite o número");
    if (int.TryParse(Console.ReadLine(), out int n))
    {
        return n;
    }
    else
    {
        return 0;
    }
}


//lancarMagia();
//int opcao = menu();

//switch (opcao)
//{
//    case 1:
//        Console.WriteLine("I don't like P Diddiy💀");
//        break;
//    case 2:
//        Console.WriteLine("Expresso is my favorite song");
//        break;
//    case 3:
//        Console.WriteLine("You're no uniform. Goes to Directory now!");
//        break;
//    case 4:
//        Console.WriteLine("Calorias são unidades de medida, que são responsáveis" +
//            "por medir a energia do corpo humano. As calorias, podem ser\n convertidas em Joules," +
//            "e também em Volts. As calorias vem dos carboidratos, oriundos da quebra" +
//            "da glicose no ciclo ácido cítrico e na cadeia transportadora" +
//            "de elétrons na mitocôndria");
//        break;
//    default:
//        Console.WriteLine("Digite um valor válido");
//        break;
//}

//int menu()
//{
//    Console.WriteLine("Bem vindo!\nDigite:\n1 - Justin Bieber" +
//        "\n2 - Sabrina Carpenter\n3 - Marcio\n4 - Lucia ");
//    if (int.TryParse(Console.ReadLine()!, out int escolha))
//    {
//        return escolha;
//    }
//    else
//    {
//        return 0;
//    }
//}
//void lancarMagia()
//{
//    Console.WriteLine("Bem-vindos ao mundo da magia✨");
//}
