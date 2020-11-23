using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Msc.GangOfFour.PrototypePattern.Test
{
    [TestClass]
    public class PrototypePatternTest
    {
        [TestMethod]
        public void PrototypeCloneTest()
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User clones selected colors
            Color red = colormanager["red"].Clone() as Color;
            Color green = colormanager["green"].Clone() as Color;
            Color blue = colormanager["blue"].Clone() as Color;

            // Check if the cloning yielded the expected results
            Assert.AreEqual(colormanager["red"], red);
            Assert.AreEqual(colormanager["green"], green);
            Assert.AreEqual(colormanager["blue"], blue);
        }
    }
}
