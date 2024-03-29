﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backlogSys.Models {

    /// <summary>
    /// Dados da Equipa
    /// </summary>
    public class Equipa {

        public Equipa() {
            ListaMembros = new HashSet<MembrosEquipa>();
        }

        /// <summary>
        /// PK da Equipa
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da Equipa
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        public string Nome { get; set; }

        /// <summary>
        /// Email da Equipa
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [EmailAddress(ErrorMessage = "Deve inserir um {0} válido")]
        public string? Email { get; set; }

        /// <summary>
        /// NEmpregado do TeamLeader da Equipa
        /// </summary>
        public int? TeamLeader { get; set; }

        /// <summary>
        /// NEmpregado do Chefe
        /// </summary>
        public int? Chefe { get; set; }

        /// <summary>
        /// Lista de membros da Equipa
        /// </summary>
        public ICollection<MembrosEquipa> ListaMembros { get; set; }

    }

}
