using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
  ErrorOr<Created> CreateBreakfast(Breakfast breakfast);
  ErrorOr<Breakfast> GetBreakfastById(Guid id);
  ErrorOr<UpsertedBreakfast> UpsertBreakfast(Breakfast breakfast);
  ErrorOr<Deleted> DeleteBreakfast(Guid id);
}