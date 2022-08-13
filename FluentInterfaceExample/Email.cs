using System;

namespace FluentInterfaceExample
{
    public class Email
    {
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Body { get; set; }
        public DateTime DataEnvio { get; set; }

        public override string ToString()
        {
            return $"{Destinatario} - {Remetente}\n {Assunto}\n {Body}\n {DataEnvio}\n";
        }
    }
}
