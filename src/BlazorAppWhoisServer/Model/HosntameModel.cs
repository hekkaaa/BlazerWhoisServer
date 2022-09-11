using System.ComponentModel.DataAnnotations;

namespace BlazorAppWhoisServer.Model
{
    public class HosntameModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Minimum Length 3 ", MinimumLength = 4)]
        public string? Hostname { get; set; }
    }
}
