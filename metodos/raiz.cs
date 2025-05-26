static void Main(String[] args){
    int y = 5;
    int z;

    metRaizQuadradaRef(ref y);
    metRaizQuadradaOut(out z);

    Console.Writeline(y)
    Console.Writeline(z)

    metRaizQuadrada(y);
    metRaizQuadrada(z);

    Console.Writeline(y)
    Console.Writeline(z)

}

static void metRaizQuadradaRef(ref int x){
    x = x * x;
}

static void metRaizQuadradaOut(out int x){
    x = 6;
    x = x * x;
}