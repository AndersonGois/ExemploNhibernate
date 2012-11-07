
namespace Domain.Interfaces
{
   public interface IAggregateRoot<T>
    {
       T Id { get; }
    }
}
