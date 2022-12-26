using OnlinerStore.PageObjects;

namespace OnlinerStore.TestCases.Forum
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ReadThreads : BaseTest
    {
        [Test]
        public void ReadLostPetsThread()
        {
            Pages.Main.OpenForumPage();
            Pages.Forum.OpenForumTheadPage("Потерянные/найденные домашние животные.");
            Assert.IsTrue(Pages.Thread.IsThreadTitleDisplayed("Потерянные/найденные домашние животные."));
            Assert.IsTrue(Pages.Thread.IsPinnedMessageDisplayed("ссылка на международную базу чипированных животных"));
        }
    }
}