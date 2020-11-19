using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LeBataillon.Database.Models
{
    public class Team
    {

        public Team()
        {


        }

        public Team(int Id, string TeamName, int? CaptainId, int JoueurMaximum)
        {
            this.Id = Id;
            this.TeamName = TeamName;
            this.CaptainId = CaptainId;
            this.JoueurMaximum = JoueurMaximum;

        }

        public void EditFrom(Team t)
        {
            this.Id = t.Id;
            this.TeamName = t.TeamName;
            this.CaptainId = t.CaptainId;
            this.JoueurMaximum = t.JoueurMaximum;

        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "Nom de l'équipe")]
        [Required(ErrorMessage = "Nom de l'équipe requis")]
        [MaxLength(25, ErrorMessage = "Maximum de 25 caractères pour le champ {0}.")]
        public string TeamName { get; set; }

        [Display(Name = "Capitain de l'équipe")]
        [Required(ErrorMessage = "Capitain de l'équipe requis")]
        public int? CaptainId { get; set; }
        [Display(Name = "Capitain de l'équipe")]
        [ForeignKey("CaptainId")]
        public virtual Player Captain { get; set; }


        [InverseProperty("Team")]
        public List<Player> Players = new List<Player>();

        [Display(Name = "nombre de Joueurs Maximum")]
        [Required(ErrorMessage = "Nombre de joueurs maximum de l'équipe requis")]
        [Range(6, 10, ErrorMessage = "Minimum de joueurs est de 6 et maximum de joueurs est 10")]
        public int JoueurMaximum { get; set; }

    }
}