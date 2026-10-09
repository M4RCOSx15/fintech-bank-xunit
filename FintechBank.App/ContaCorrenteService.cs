namespace FintechBank.App
{

public class ContaCorrente{
  
  public string CalcularTaxaMannutencao(float saldo, bool clienteEspecial){
   if(saldo >= 5000 || clienteEspecial == true)
    {
        return "0.00m (isento)";
    }
    if(saldo >= 1000)
    {
      return "12.50m";
    }
    return "25.00m";
  }
}
}
