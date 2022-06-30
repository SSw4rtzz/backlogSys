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
        public int Id { get; set; }

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

        public int EquipaFK { get; set; }

        /// <summary>
        /// FK IdEquipa
        /// </summary>
        //[Display(Name ="Equipa")]
        //public int EquipaFK { get; set; }
        //[ForeignKey(nameof(EquipaFK))]
        //public Equipa Equipa { get; set; }


        /// <summary>
        /// Lista de tarefas efectuadas por cada membro 
        /// </summary>
        public ICollection<Tarefas> ListaTarefas { get; set; }
    }
}
