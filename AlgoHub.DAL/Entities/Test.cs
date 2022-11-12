﻿namespace AlgoHub.DAL.Entities;

public class Test : IEntity
{
    public int Id { get; set; }

    public int ProblemId { get; set; }

    public string? Input { get; set; }

    public string? Output { get; set; }
}