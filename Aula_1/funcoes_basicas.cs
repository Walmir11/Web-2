static void Main(String[ args]){
    int a, result; //Cria duas variáveis numéricas
    a = 10;
    //Incrementa a de 1
    a++;
    console.Writeline("A é: " + a); //REsultado
    //Atribui a para esulte depois incrementa de 1 à a
    result = a++;
    result = ++a;
    result = 20;
    result += a;
    console.Writeline("Result é : " + result + "E a é: " + a);
}

----------------------------------------------------------------------

static void Main(String[] args){
    int x = 10;
    double y = 2.5;
    x = y; //erro
    x = (int) y; //correto
}
