public class program{
    static decimal atrNumero1 = 0;
    static decimal atrNumero2 = 0;
    static decimal atrResultado = 0;

    static void Main(String[] args){
        console.Writeline("Qual o primeiro número?");
        atrNumero1 = Convert.ToDecimal(Console.ReadLine());
        decimal varNumero1 = atrNumero1;

        console.Writeline("Qual o segundo número?");
        atrNumero2 = Convert.ToDecimal(Console.ReadLine());
        decimal varNumero2 = atrNumero2;

        Console.Writeline("1: Adição");
        Console.Writeline("2: Subtração");
        Console.Writeline("3: Qual a opção desejada?");
        int opcao = Convert.ToInt16(Console.ReadLine());

        switch (opcao)
        {
            case 1 : atrResultado = metAdicao(varNumero1,varNumero2); break;
            case 2 : atrResultado = metSubitracao(varNumero1,varNumero2); break;
            default: Console.Writeline("Fim do programa."); break;
        }
        Console.Writeline("O resultado é " + atrResultado);
    }
}