using System;
using System.ComponentModel.DataAnnotations;

namespace ExerciseTracker;

public class Pushup
{
    [Key]
    public int Id { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public int Repetitions{ get; set; }
    public string? Comments { get; set; }

    public TimeSpan Duration => DateEnd - DateStart; 
}