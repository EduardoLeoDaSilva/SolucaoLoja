using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Objetos
{
    [DataContract]
    public class Pessoa
    {
        [DataMember]
        [Required]
        public int PessoaId { get; set; }

        [DataMember]
        [Required(ErrorMessage ="Insira seu Sexo")]
        public string Sexo { get; set; }

        [DataMember]
        [Required(ErrorMessage ="Insira a sua idade")]
        public int Idade { get; set; }

        [DataMember]
        [DataType("dd/MM/yyyy")]
        [Required(ErrorMessage ="Por favor insira a data do seu nascimento!!")]
        public DateTime Nascimento { get; set; }

        public Pedido Pedido { get; set; }
        
    }
}
