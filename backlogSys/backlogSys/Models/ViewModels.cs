using System;
namespace backlogSys.Models{
    /// <summary>
    /// ViewModel a ser usado na API dos Membros
    /// </summary>
    public class MembrosViewModel {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Efetividade { get; set; }
        public string Foto { get; set; }
        public string NomeEquipa { get; set; }
    }

    /// <summary>
    /// Dados das equipas para a API
    /// </summary>
    public class EquipaViewModel {
		public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int TeamLeader { get; set; }
        public int Chefe { get; set; }
    }
}

