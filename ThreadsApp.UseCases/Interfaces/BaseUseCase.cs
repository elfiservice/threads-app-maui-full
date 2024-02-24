namespace ThreadsApp.UseCases;

public interface BaseUseCase<T>
{
    Task<IEnumerable<T>> ExecuteAsync();
}
