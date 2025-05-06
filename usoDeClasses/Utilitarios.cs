public class utilitarios{

public double IMC(double peso, double altura) 
{
  double retorno = 0;

  retorno = peso / (altura * altura);

  return retorno;
}

//criar função para coverter km em metro

public double converterKm(double km)
{
  double metros = 0;

  metros = km * 1000;

  return metros;
}

//criar função para converter real em dollar 5.94

public double converterRealDollar(double real)
{
  double dollar = 0;

  dollar = real * 5.94;

  return dollar;
}
}