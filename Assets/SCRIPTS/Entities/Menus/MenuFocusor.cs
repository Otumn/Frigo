using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Otumn.AppTemplate
{
    public class MenuFocusor : Entity
    {
        [SerializeField] private int LinkedMenu = 0;
        [SerializeField] private Button button;

        public void FocusLinkedMenu()
        {
            AppManager.menusManager.SelectNewMenu(LinkedMenu);
        }

        public void UpdateButtonState()
        {
            button.interactable = !(AppManager.menusManager.CurrentMenuIndex == LinkedMenu);
        }

        public override void OnMenuListShown()
        {
            base.OnMenuListShown();
            UpdateButtonState();
        }

        public override void OnMenuSwitched(Menu newMenu)
        {
            base.OnMenuSwitched(newMenu);
            UpdateButtonState();
        }
    }
}
