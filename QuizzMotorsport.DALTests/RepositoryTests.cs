using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizzMotorsport.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzMotorsport.DAL.Tests
{
    [TestClass()]
    public class RepositoryTests
    {
        [TestMethod()]
        public void GetQuestionsTest()
        {
            var lesQuestions = new Repository().GetQuestions();
            Assert.IsNotNull(lesQuestions);
        }
    }
}