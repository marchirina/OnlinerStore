﻿namespace OnlinerStore.PageObjects.Popups
{
    public class BasePopup
    {
        public static string PopupXpath { get; set; }

        public BasePopup(string popupXpath)
        {
            PopupXpath = popupXpath;
        }
    }
}


