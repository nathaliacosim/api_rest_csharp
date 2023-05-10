﻿using System.ComponentModel.DataAnnotations;
namespace FilmesAPI.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string? Titulo { get; set; }

    [Required(ErrorMessage = "O genero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não deve exceder 50 caracteres")]
    public string? Genero { get; set; }

    [Required]
    [Range(60, 500, ErrorMessage = "A duração deve ter entre 60 e 500 minutos")]
    public int Duracao { get; set; }
}
