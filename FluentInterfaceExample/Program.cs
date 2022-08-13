using System;

namespace FluentInterfaceExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var emailFluent = new EmailFluent();

            var email = emailFluent.RemetenteEmail("edson@teste.com")
                                   .DestinatarioEmail("destino@teste.com")
                                   .AssuntoEmail("Teste da classe Email")
                                   .BodyEmail("Teste de utilização da classe Email")
                                   .DataEnvioEmail(DateTime.Now)
                                   .Build();

            Console.WriteLine(email.ToString());
            Console.ReadKey();
        }
    }
}
