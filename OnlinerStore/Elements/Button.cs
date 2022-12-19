﻿using OpenQA.Selenium;

namespace OnlinerStore.Elements
{
    public class Button : BaseElement
    {
        public Button(By locator) : base(locator)
        {
        }

        public Button(IWebElement element) : base(element)
        {
        }
    }
}

