using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O Título do filme é um campo obrigatório")]//Usa o data anotation. deixa o campo a baixo obrigatorio
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O Gênero do filme é um campo obrigatório")]
    [StringLength(50, ErrorMessage = "O Gênero deve conter no máximo 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ser de no mínimo 70 minutos e no máximo 600")]
    public int Duracao { get; set; }
}
