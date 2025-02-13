namespace StefaniniTask;

public class DishAssignmentResult
{
    public int EstTime { get; init; }
    public bool IsSuccess { get; init; }
    public string Message { get; init; }

    private DishAssignmentResult(int estTime)
    {
        EstTime = estTime;
        IsSuccess = true;
        Message = "Success";
    }

    private DishAssignmentResult(string message)
    {
        IsSuccess = false;
        EstTime = 0;
        Message = message;
    }

    public static DishAssignmentResult Failure(string message)
    {
        return new DishAssignmentResult(message);
    }

    public static DishAssignmentResult Success(int estTime)
    {
        return new DishAssignmentResult(estTime);
    }
}