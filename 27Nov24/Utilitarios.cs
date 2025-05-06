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
  double retorno = 0;

  retorno = km * 1000;

  return retorno;
}

//criar função para converter real em dollar 5.94

public double converterRealDollar(double real)
{
  double retorno = 0;

  retorno = real * 5.94;

  return retorno;
}
}