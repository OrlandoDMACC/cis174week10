using CIS174Winters.Models;
using CIS174Winters.Services.Interfaces;
using System;

namespace CIS174Winters.Services
{
    public class DateofBirthService : IDateofBirthService
    {
        private readonly IDateTimeService _dateTimeService;

        public DateofBirthService(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }
        public bool IsTodayYourBirthday(Employee employee)
        {
            return employee.birthDate.DayOfYear == _dateTimeService.Now().DayOfYear;
        }
    }
}