using System;

namespace SharedKernel.Entities;

public class Error
{
    public string Message { get; private set; }
    public string? Code { get; private set; }

    public Error(string message, string? code)
    {
        Message = message;
        Code = code;
    }
}
