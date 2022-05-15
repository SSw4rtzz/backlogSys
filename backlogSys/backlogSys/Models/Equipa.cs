using Microsoft.AspNetCore.Mvc;

namespace backlogSys.Models {

    /// <summary>
    /// Dados da Equipa
    /// </summary>
    public class Equipa {

        public Equipa() {
            ListaMembros = new HashSet<MembrosEq>();
        }

        /// <summary>
        /// PK da Equipa
        /// </summary>
        public int IdEquipa { get; set; }

        /// <summary>
        /// Nome da Equipa
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Email da Equipa
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// NEmpregado do TeamLeader da Equipa
        /// </summary>
        public string TeamLeader { get; set; }

        /// <summary>
        /// NEmpregado do Chefe
        /// </summary>
        public int Chefe { get; set; }

        /// <summary>
        /// Lista de membros da Equipa
        /// </summary>
        public ICollection<MembrosEq> ListaMembros { get; set; }

    }

}
