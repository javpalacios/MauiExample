﻿namespace MauiExampleApp.Models;

public class Cosa
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string? ToString() => $"{Id} {Name}";
}
