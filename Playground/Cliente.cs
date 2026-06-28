namespace Playground
{
    public class Cliente
    {
        // Declare as quatro propriedades públicas com os tipos corretos:
        // Nome, Sobrenome, Email e CPF — todas string

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }

        public string CPF { get; set; }


        // Implemente FormatarNomeCompleto()
        // Retorna Nome e Sobrenome concatenados com um espaço
        // Cada palavra deve ter a primeira letra maiúscula e o restante minúsculo
        // Use ToLower(), ToUpper() e Substring() para montar o resultado
        public string FormatarNomeCompleto()
        {
            //   sua implementação aqui

            // Nome: RAFAEL => Rafael
            //Rafael
            //                    R + afael
            string nomeFormatado = Nome.Substring(0, 1).ToUpper() + Nome.Substring(1).ToLower();

            //                                     M                        + ota 
            string sobrenomeFormatado = Sobrenome.Substring(0, 1).ToUpper() + Sobrenome.Substring(1).ToLower();



            return nomeFormatado + " " + sobrenomeFormatado;
        }

        // Implemente ValidarEmail()
        // Retorna true somente se o email contiver "@"
        // E se houver pelo menos um "." depois da posição do "@"
        // Use Contains() e IndexOf() para localizar os caracteres
        public bool ValidarEmail()
        {
            // sua implementação aqui

            string emailFormatado = Email.Substring(0).ToLower();

            if (!emailFormatado.Contains("@"))
            {
                Console.WriteLine("Erro ao digitar o email. Ausência do @ no email.");

                return false;
            }

            // variavel = indice que está localizado o arroba.com se a varivel contém . retorna verdadeiro
            // passo 1 descobrir onde está o index do arroba
            // passo 2 tirar uma substring do @ até o final
            // passo 3 validar se nessa substring tem o "."
            //cabrunco@gmail.com

            string depoisDoArroba = emailFormatado.Substring(emailFormatado.IndexOf("@"));

            if (!depoisDoArroba.Contains("."))
            {
                Console.WriteLine("Erro ao digitar o email. Ausência do '.' após o @.");

                return false;
            }

            return true;
        }

        // Implemente MascararCPF()
        // O CPF de entrada tem 11 dígitos numéricos sem formatação, ex: "12345678945"
        // Retorne no formato "123.***.***-45"
        // Use Substring() para extrair os três primeiros e os dois últimos dígitos

        public bool ValidarCPF()
        {
            // função para validar cpf 
            // cpf nao pode ser nulo 
            // cpf tem que ter 11 digitos
            // cpf nao pode ter letras 

            if (string.IsNullOrWhiteSpace(CPF))
            {
                Console.WriteLine("Erro ao validar o CPF, pois não pode ser nulo ou vazio.");

                return false;
            }

            string cpfLimpo = CPF.Replace(".", "").Replace("-", "");


            if(cpfLimpo.Length != 11)
            {
                Console.WriteLine("ERRO: CPF deve conter apenas 11 dígitos.");

                return false;
            }

            // após as verificações

            return true;

        }




        public string MascararCPF()
        {
            // sua implementação aqui

            string cpfTresPrimeirosDigitos = CPF.Substring(0, 3);

            string cpfDoisUltimosDigitos = CPF.Substring(9, 2);
            
            Console.WriteLine($"{cpfTresPrimeirosDigitos}******-{cpfDoisUltimosDigitos}");

            return "";
        }

        // Implemente ExibirResumo()
        // Chame FormatarNomeCompleto(), ValidarEmail() e MascararCPF() dentro deste método
        // Exiba: nome formatado, status do email (válido/inválido) e CPF mascarado
        public void ExibirResumo()
        {
            // sua implementação aqui
            Console.Write("Nome: ");
            Console.WriteLine(FormatarNomeCompleto());
            Console.Write("Validade do email: ");
            Console.WriteLine(ValidarEmail() );
            Console.Write("CPF: ");
            Console.WriteLine(MascararCPF());
    }
}
}
