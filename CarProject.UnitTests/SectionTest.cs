using CarProject.Logic;
namespace CarProject.UnitTests
{
    [TestClass]
    public class SectionTest
    {
        [TestMethod]
        public void ItShouldHaveALengthAndAMaxSpeed_GivenObjectCreated()
        {
            var someSpeed = 60;
            var someLength = 400;
            Section section = new Section(someSpeed, someLength);

            Assert.AreEqual(someSpeed, section.MaxSpeed);
            Assert.AreEqual(someLength, section.Length);
        }
        [TestMethod]
        public void ItShouldConnectASectionAfterTheCurrentSection_GivenAddAfterMeIsCalled()
        {
            Section section = new Section(60, 400);
            Section nextSection = new Section(60, 400);
            section.AddAfterMe(nextSection);

            Assert.AreEqual(nextSection, section.NextSection);
        }
        [TestMethod]
        public void ItShouldConnectASectionBeforeTheCurrentSection_GivenAddBeforeMeIsCalled()
        {
            Section section = new Section(60, 400);
            Section previousSection = new Section(60, 400);
            section.AddBeforeMe(previousSection);

            Assert.AreEqual(previousSection, section.PreviousSection);
        }
        [TestMethod]
        public void ItShouldInsertASectionBetweenTwoSections_GivenTwoConnectedSectionsAndAddAfterMeIsCalled()
        {
            Section sectionOne = new Section(60, 400);
            Section sectionTwo = new Section(60, 500);
            Section insertSection = new Section(50, 300);

            sectionOne.AddAfterMe(sectionTwo);
            sectionOne.AddAfterMe(insertSection);

            Assert.AreEqual(sectionTwo, sectionOne.NextSection.NextSection);
        }

        [TestMethod]
        public void ItShouldInsertASectionBetweenTwoSections_GivenTwoConnectedSectionsAndAddbeforeMeIsCalled()
        {
            Section sectionOne = new Section(60, 400);
            Section sectionTwo = new Section(60, 500);
            Section insertSection = new Section(50, 300);

            sectionOne.AddAfterMe(sectionTwo);
            sectionTwo.AddBeforeMe(insertSection);

            Assert.AreEqual(sectionTwo, sectionOne.NextSection.NextSection);
        }
    }
}
