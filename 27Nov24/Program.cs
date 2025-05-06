utilitarios util = new utilitarios();


double imc = util.IMC(95, 1.86);

double km = util.converterKm(5);

double realParaDollar = util.converterRealDollar(5);

Console.WriteLine($"{imc} o IMC, {km} o KM em Metros, {realParaDollar} o Real para Dolar");

