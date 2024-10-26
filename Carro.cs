class Carro : iVeiculo{
    public string modelo {get;set;}
    public void Dirigir(){
        Console.WriteLine($"Dirigindo o carro {modelo}");
    }
}