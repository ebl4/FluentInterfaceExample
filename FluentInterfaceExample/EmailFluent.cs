using System;

namespace FluentInterfaceExample
{
    public class EmailFluent
    {
        private readonly Email email;

        public EmailFluent()
        {
            email = new Email();
        }

        public EmailFluent RemetenteEmail(string remetente)
        {
            email.Remetente = remetente;
            return this;
        }

        public EmailFluent DestinatarioEmail(string destinatario)
        {
            email.Destinatario = destinatario;
            return this;
        }

        public EmailFluent AssuntoEmail(string assunto)
        {
            email.Assunto = assunto;
            return this;
        }

        public EmailFluent BodyEmail(string body)
        {
            email.Body = body;
            return this;
        }

        public EmailFluent DataEnvioEmail(DateTime dataEnvio)
        {
            email.DataEnvio = dataEnvio;
            return this;
        }

        public Email Build()
        {
            return email;
        }
    }
}
