using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdemServicos.Models
{
    public class Cliente
    {
        private string Name { get; set; }

        private decimal CPF { get; set; }

        private string Email { get; set; }

        private string Telefone { get; set; }

        private string Celular { get; set; }

        private string Endereco { get; set; }

        private string Cidade { get; set; }

        private string UF { get; set; }

        private string CEP { get; set; }

        public Cliente(string name, decimal cPF, string email, string telefone, string celular, string endereco, string cidade, string uF, string cEP)
        {
            Name = name;
            CPF = cPF;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            Endereco = endereco;
            Cidade = cidade;
            UF = uF;
            CEP = cEP;
        }


    }
}
