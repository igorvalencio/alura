using byteBankAlura;
using byteBankAlura.Funcionarios;
using byteBankAlura.ParceriaComercial;
using byteBankAlura.SistemaInterno;

#region
//Funcionario pedro = new Funcionario("321654987", 1500);
//pedro.nome = "pedro";
//pedro.GetBonificacao();
//Console.WriteLine("Salário Pedro: " + pedro.salario);

//Diretor joao = new Diretor("1984982437", 5000);
//joao.nome = "João";
//joao.GetBonificacao();
//Console.WriteLine("Salário João: " + joao.salario);

//Auxiliar jonas = new Auxiliar("3212364545", 2000);
//jonas.nome = "Jonas";
//jonas.GetBonificacao();
//Console.WriteLine("Salário jonas: " + jonas.salario);

//GerenteDeContas Anizio = new GerenteDeContas("321654987", 4000);
//Anizio.nome = "Anizio";
//Anizio.GetBonificacao();
//Console.WriteLine("Salário do Anizio: " + Anizio.salario);

//Designer antonio = new Designer("321564978", 3000);
//antonio.nome = "Antônio";
//antonio.GetBonificacao();
//Console.WriteLine("Salário de Antonio: " + antonio.salario);



//GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(joao);
//gerenciador.Registrar(jonas);
//gerenciador.Registrar(Anizio);
//gerenciador.Registrar(antonio);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacoes);
//Console.WriteLine("Total de funcionarios: " + Funcionario.TotalFuncionarios);

//pedro.AumentarSalario();
//joao.AumentarSalario();
//jonas.AumentarSalario();
//Anizio.AumentarSalario();
//antonio.AumentarSalario();

//Console.WriteLine("Novo salário do Pedro: " + pedro.salario);
//Console.WriteLine("Novo salário do João: " + joao.salario);
//Console.WriteLine("Novo salário de Jonas: " + jonas.salario);
//Console.WriteLine("Novo salário de Anizio: " + Anizio.salario);
//Console.WriteLine("Novo salário de antônio: " + antonio.salario);
#endregion
CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer designer1 = new Designer("321456897");
    designer1.nome = "designer1";

    Diretor diretor1 = new Diretor("564897321");
    diretor1.nome = "diretor1";

    Auxiliar auxiliar1 = new Auxiliar("456798312");
    auxiliar1.nome = "auxiliar1";

    GerenteDeContas gerente1 = new GerenteDeContas("98754");
    gerente1.nome = "gerente1";

    gerenciador.Registrar(gerente1);
    gerenciador.Registrar(diretor1);
    gerenciador.Registrar(auxiliar1);
    gerenciador.Registrar(gerente1);

    Console.WriteLine("Total de bonificação: " + gerenciador.TotalBonificacoes);

}

 UsarSistema();
void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();
    Diretor diretor2 = new Diretor("00213654");
    diretor2.nome = "diretor2";
    diretor2.senha = "123";

    GerenteDeContas gerente2 = new GerenteDeContas("0058222");
    gerente2.nome = "gerente2";
    gerente2.senha = "321";

    ParceiroComercial parceiro1 = new ParceiroComercial();

    sistema.Logar(diretor2, "123");
    sistema.Logar(gerente2, "322");

}

