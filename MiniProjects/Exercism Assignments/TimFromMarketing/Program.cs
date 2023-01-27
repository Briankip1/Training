// See https://aka.ms/new-console-template for more information
using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var dept = (department ?? "OWNER").ToUpper();
        return id == null ? $"{name} - {dept}" : $"[{id}] - {name} - {dept}";
    }
}