using System.ComponentModel.DataAnnotations;

namespace LeBataillon.Database.Models
{
    public enum GameStatus
    {
        [Display(Name="Finished")]
        finished,
        [Display(Name="Ongoing")]
        ongoing,
        [Display(Name="Forthcoming")]
        forthcoming

    }
}