using System;
namespace backlogSys.Models
{
	public class EquipaViewModel {
		public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int TeamLeader { get; set; }
        public int Chefe { get; set; }
    }
}

