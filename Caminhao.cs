class Caminhao : iVeiculo{
    public string modelo {get;set;}
    public void Dirigir(){
        Console.WriteLine($"Conduzinho o caminhão {modelo}");
    }
}