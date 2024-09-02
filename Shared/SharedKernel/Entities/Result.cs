using System;

namespace SharedKernel.Entities;

public class Result<T>
{
    public bool IsSuccess { get; private set; }
    public Error? Error { get; private set; }

    public T? Value { get; private set; }

    private Result(bool isSuccess, Error? error, T? value)
    {
        IsSuccess = isSuccess;
        Error = error;
        Value = value;
    }

    public static Result<T> Success(T value) => new Result<T>(true, null, value);

    public static Result<T> Failure(Error error) => new Result<T>(false, error, default);

    public static implicit operator Result<T>(T value) => Success(value);

    public static implicit operator Result<T>(Error error) => Failure(error);



}
