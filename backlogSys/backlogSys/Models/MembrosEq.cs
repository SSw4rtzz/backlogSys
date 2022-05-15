using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace backlogSys.Models {
    public class MembrosEq {

        public MembrosEq() {
            ListaTarefas = new HashSet<Tarefas>();
        }

        /// <summary>
        /// Pk MembrosEq (N de Empregado)
        /// </summary>
        public int IdEmpregado { get; set; }

        /// <summary>
        /// Nome do empregado
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Email do Empregado
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Efeitividade do empregado Estagiário ou Efetivo
        /// </summary>
        public string Efetividade { get; set; }

        public string Foto { get; set; }

        /// <summary>
        /// FK IdEquipa
        /// </summary>
        [ForeignKey(nameof(Equipa))]
        public int EquipaFK { get; set; }
        public Equipa Equipa { get; set; }


        /// <summary>
        /// Lista de tarefas efectuadas por cada membro 
        /// </summary>
        public ICollection<Tarefas> ListaTarefas { get; set; }
    }
}
