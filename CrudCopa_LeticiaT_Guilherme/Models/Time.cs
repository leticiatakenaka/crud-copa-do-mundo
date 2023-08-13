using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CrudCopa_LeticiaT_Guilherme.Models
{
    [Index(nameof(Time.Nome), IsUnique = true)]

    public class Time
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Número de Títulos")]
        public int QtdTitulos { get; set; }
    }
}
