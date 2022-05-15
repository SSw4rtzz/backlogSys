using Microsoft.AspNetCore.Mvc;
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
        public string Titulo { get; set; }

        /// <summary>
        /// Descrição da Tarefa
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Status da tarefa, Por Fazer/Em progresso/Stand-by/Aguarda Intervanção/Concluido
        /// </summary>
        public string PontoSituacao { get; set; }

        /// <summary>
        /// FK MembrosEq, Membros a desempenhar a tarefa
        /// </summary>
        [ForeignKey(nameof(Membros))]
        public int MembrosFK { get; set; }
        public MembrosEq Membros { get; set; }

        /// <summary>
        /// Data de criação da tarefa
        /// </summary>
        public DateTime DataCriacao { get; set; }

        /// <summary>
        /// Prazo para terminar a tarefa
        /// </summary>
        public DateTime Prazo { get; set; }

        /// <summary>
        /// Data de conclusão da tarefa
        /// </summary>
        public DateTime DataConclusao { get; set; }


    }
}
