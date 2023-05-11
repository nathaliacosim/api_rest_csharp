﻿using System.ComponentModel.DataAnnotations;
namespace FilmesAPI.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage ="O nome é obrigatório")]
    public string Nome { get; set; }
    public int EnderecoId { get; set; }
}
