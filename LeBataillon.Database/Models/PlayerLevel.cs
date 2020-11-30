using System.ComponentModel.DataAnnotations;

namespace LeBataillon.Database.Models
{
    public enum PlayerLevel
    {
        novice,
        [Display(Name="Débutant")]
        débutant,
        [Display(Name="Intermédiaire")]
        intermédiaire,
        [Display(Name="Avancé")]
        avancé

    }
}