using CIS174Winters.Models;

namespace CIS174Winters.Services.Interfaces
{
    public interface IDateofBirthService
    {
        bool IsTodayYourBirthday(Employee employee);
    }
}
