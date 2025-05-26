static void Main(String[] args){
    console.Writeline("1: Adição");
    console.Writeline("2: Subtração");
    console.Writeline("Qual a opção desejada?");

    int opcao = Convert.ToInt16(Console.ReadLine());

    switch (opcao)
    {
        case 1 : metAdicao(); break;
        case 2 : metSubitracao(); break;
        default: Console.Writeline("Fim do programa."); break;
    }
}

void metAdicao(){
    Console.Writeline("Qual o primeiro número?")
    decimal numero1 = Convert.ToDecimal(Console.ReadLine());

    Console.Writeline("Qual o segundo número?");
    decimal numero2 = Convert.ToDecimal(Console.ReadLine());

    decimal resultado = numero1 + numero2;
    Console.Writeline("A soma é:" + resultado)
}

void metSubitracao(){
    Console.Writeline("Qual o primeiro número?")
    decimal numero1 = Convert.ToDecimal(Console.ReadLine());

    Console.Writeline("Qual o segundo número?");
    decimal numero2 = Convert.ToDecimal(Console.ReadLine());

    decimal resultado = numero1 - numero2;
    Console.Writeline("A subtração é:" + resultado)
}
