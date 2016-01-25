using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroDeClienteSample.Models
{
    public class Cliente
    {
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor preencha o campo Nome *")]
        [StringLength(50, ErrorMessage = "Limite máximo de 50 caracteres")]
        public string Nome { get; set; }
        [Display(Name = "Empresa")]
        public string Empresa { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
        [Display(Name = "Celular")]
        public string Celular { get; set; }
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "WebSite")]
        public string Site { get; set; }
    }
}