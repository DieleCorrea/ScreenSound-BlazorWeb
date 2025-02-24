using System.ComponentModel.DataAnnotations;

namespace ScreamSound.Web.Requests;
public record ArtistaRequest([Required] string nome, [Required] string bio);

