using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace backlogSys.Models {
    public class Tarefas {

        /// <summary>
        /// PK da Tarefa
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Titulo da tarefa
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(20, ErrorMessage = "O {0} não pode ter mais que {1} caracteres")]
        public string Titulo { get; set; }

        /// <summary>
        /// Descrição da Tarefa
        /// </summary>
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Status da tarefa, Por Fazer/Em progresso/Stand-by/Aguarda Intervanção/Concluido
        /// </summary>
        [Display(Name = "Ponto de Situação")]
        public string? PontoSituacao { get; set; }

        /// <summary>
        /// FK MembrosEq, Membros a desempenhar a tarefa
        /// </summary>
        [Display(Name = "Membros")]
        public int? MembrosFK { get; set; }
        [ForeignKey(nameof(MembrosFK))]
        public MembrosEquipa? Membros { get; set; }

        /// <summary>
        /// Data de criação da tarefa
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        [Display(Name = "Data de Criação")]
        public DateTime? DataCriacao { get; set; }

        /// <summary>
        /// Prazo para terminar a tarefa
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTime? Prazo { get; set; }

        /// <summary>
        /// Data de conclusão da tarefa
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        [Display(Name = "Data de Conclusão")]
        public DateTime? DataConclusao { get; set; }

        /// <summary>
        /// Prioridade da tarefa
        /// </summary>
        public string? Prioridade { get; set; }
    }
}
