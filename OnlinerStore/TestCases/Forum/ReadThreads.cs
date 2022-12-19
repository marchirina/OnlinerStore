using OnlinerStore.PageObjects;

namespace OnlinerStore.TestCases.Forum
{
	public class ReadThreads : BaseTest
    {
        [Test]
        public void ReadLostPetsThread()
        {
            Pages.Main.OpenForumPage();
            Pages.Forum.OpenForumTheadPage("Потерянные/найденные домашние животные.");
            Pages.Thread.IsThreadTitleDisplayed("Потерянные/найденные домашние животные.");
            Pages.Thread.IsPinnedMessageDisplayed("ссылка на международную базу чипированных животных");
        }
    }
}

