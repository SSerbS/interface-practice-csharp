Carro carro = new Carro();
carro.modelo = "Sentra";

Moto moto = new Moto();
moto.modelo = "Yamaha";

Caminhao caminhao = new Caminhao();
caminhao.modelo = "Scania";

List<iVeiculo> iVeiculos= new List<iVeiculo>();
iVeiculos.Add(carro);
iVeiculos.Add(moto);
iVeiculos.Add(caminhao);

foreach (iVeiculo veic in iVeiculos){
    veic.Dirigir();
}