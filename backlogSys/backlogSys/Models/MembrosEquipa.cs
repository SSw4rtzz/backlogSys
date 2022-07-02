using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backlogSys.Models {

    public class MembrosEquipa {

        public MembrosEquipa() {
            ListaTarefas = new HashSet<Tarefas>();
        }

        /// <summary>
        /// Pk MembrosEq (N de Empregado)
        /// </summary>

        [Key]
        [Display(Name = "Nº Empregado")]
        public int Id { get; set; }

        /// <summary>
        /// Nome do empregado
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(50, ErrorMessage ="O {0} não pode ter mais que {1} caracteres")]
        [RegularExpression("[A-Za-záéíóúâêîôûàèìòùñçãõÁÉÍÓÚÂ '-]+",ErrorMessage = "Apenas são aceites letras no {0}")]
        public string? Nome { get; set; }

        /// <summary>
        /// Email do Empregado
        /// </summary>
        [EmailAddress(ErrorMessage = "Deve inserir um {0} válido")]
        public string? Email { get; set; }

        /// <summary>
        /// Efeitividade do empregado Estagiário ou Contratado
        /// </summary>
        public string? Efetividade { get; set; }

        /// <summary>
        /// Foto do Empregado
        /// </summary>
        public string? Foto { get; set; }

        /// <summary>
        /// Chave FK ID da equipa a que pertence o empregado
        /// </summary>
        
        [Display(Name = "Equipa")]
        public int EquipaFK { get; set; }
        [ForeignKey(nameof(EquipaFK))]
        public Equipa? Equipa { get; set; }


        /// <summary>
        /// Lista de tarefas efectuadas por cada membro 
        /// </summary>
        public ICollection<Tarefas> ListaTarefas { get; set; }

        /// <summary>
        /// FK que relaciona o Empregado com a Autenticação
        /// </summary>
        public string? UserId { get; set; }
    }
}
