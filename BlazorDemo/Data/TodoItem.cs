﻿namespace BlazorDemo.Data;

public class TodoItem
{
    public string? Title { get; set; }
    public bool IsDone { get; set; }
    public DateTime? DateDue { get; set; }
}