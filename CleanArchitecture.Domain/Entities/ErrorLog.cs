﻿using CleanArchitecture.Domain.Abstraction;

namespace CleanArchitecture.Domain.Entities;

public sealed class ErrorLog : Entity
{
    public string ErrorMEssage { get; set; }
    public string StackTrace { get; set; }
    public string RequestPath { get; set; }
    public string RequestMethod { get; set; }
    public DateTime Timestamp { get; set; }
}
