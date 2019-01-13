using System.ComponentModel.DataAnnotations;

namespace AlterSpamTool.Model
{
    /// <summary>
    /// Модель сущности "Отправитель"
    /// </summary>
    public class Sender
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
