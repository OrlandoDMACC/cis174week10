using AutoMoq;
using CIS174Winters.Models;
using CIS174Winters.Services;
using CIS174Winters.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMACC.CIS174.Test
{
    [TestClass]
    public class DateOfBirthServiceTests
       
    {
        private readonly AutoMoqer _mocker = new AutoMoqer();

        [TestInitialize]
        public void Initialize()
        {
            _mocker.GetMock<IDateTimeService>()
               .Setup(x => x.Now())
               .Returns(new DateTime(2018, 10, 15));
        }
        [TestMethod]
        public void BirthdayToday_ReturnsTrue_WhenBirthdayMatchesToday()
        {


            var employee = CreateEmployee(new DateTime(1975, 10, 15));

            var dateofBirthService = _mocker.Create<DateofBirthService>();

            var isBirthday = dateofBirthService.IsTodayYourBirthday(employee);

            Assert.IsTrue(isBirthday);
        }

        private Employee CreateEmployee(DateTime dateOfBirth)
        {
           return new Employee
            {
                // = Guid.NewGuid(),
                firstName = "Luke",
                lastName = "Skywalker",
                birthDate = dateOfBirth
            };
        }
    }
}
