using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Otumn.AppTemplate
{
    public class MenusManager : Entity
    {
        [SerializeField] private Menu[] menuArray;

        private Menu currentMenu;
        private int currentMenuIndex;

        public override void OnManagersInitialized()
        {
            base.OnManagersInitialized();
            SelectNewMenu(0);
        }

        public void SelectNewMenu(int menuInt)
        {
            if (menuInt >= menuArray.Length) return;
            if (menuArray[menuInt] == currentMenu) return;

            if (currentMenu != null) currentMenu.UnfocusMenu();

            currentMenu = menuArray[menuInt];
            currentMenuIndex = menuInt;
            currentMenu.FocusMenu();

            AppManager.appInstance.CallOnMenuSwitched(currentMenu);
        }

        public int CurrentMenuIndex { get => currentMenuIndex; }
        public Menu CurrentMenu { get => currentMenu;}
    }
}
