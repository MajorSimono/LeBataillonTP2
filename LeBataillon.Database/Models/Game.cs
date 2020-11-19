using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeBataillon.Database.Models
{
    public class Game
    {
        public Game()
        {


        }

        public Game(int Id, DateTime GameDateTime, int TeamDefendant, int TeamAttacker, GameStatus status)
        {
            this.Id = Id;
            this.GameDateTime = GameDateTime;
            this.TeamDefendantId = TeamDefendant;
            this.TeamAttackerId = TeamAttacker;
            this.status = status;

        }

        public void EditFrom(Game g)
        {
            this.Id = g.Id;
            this.GameDateTime = g.GameDateTime;
            this.TeamDefendantId = g.TeamDefendantId;
            this.TeamAttackerId = g.TeamAttackerId;
            this.status = g.status;

        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Date de la partie")]
        [Required(ErrorMessage = "Date de la partie requis")]
        [DataType(DataType.Date)]
        public DateTime GameDateTime { get; set; }
        [Display(Name = "Équipe défendante de la partie")]
        public int? TeamDefendantId { get; set; }
        [Display(Name = "Équipe attaquante de la partie")]
        public int? TeamAttackerId { get; set; }


        public virtual Team TeamDefendant { get; set; }

        public virtual Team TeamAttacker { get; set; }

        [Display(Name = "Status de la partie")]
        [Required(ErrorMessage = "Status de la partie requis")]
        public GameStatus status { get; set; }
    }
}