using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace lr5
{
    [TestFixture]
    class TestingClass
    {
        [Test]
        public void TestGetDayOfWeekName()
        {
            Assert.AreEqual("Понедельник", WeekDayConverter.GetNameByDay(1));
            Assert.AreEqual("Вторник", WeekDayConverter.GetNameByDay(2));
            Assert.AreEqual("Среда", WeekDayConverter.GetNameByDay(3));
            Assert.AreEqual("Четверг", WeekDayConverter.GetNameByDay(4));
            Assert.AreEqual("Пятница", WeekDayConverter.GetNameByDay(5));
            Assert.AreEqual("Суббота", WeekDayConverter.GetNameByDay(6));
            Assert.AreEqual("Воскресенье", WeekDayConverter.GetNameByDay(7));
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void TestGetDayOfWeekNameInvalidArgument()
        {
            WeekDayConverter.GetNameByDay(8);
        }
    }
}
