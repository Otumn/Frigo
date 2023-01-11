using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Otumn.AppTemplate
{
    public class MenusButton : Entity
    {
        [SerializeField] private Animator menusListAnimator;

        private bool menusToggled = false;

        public void ToggleMenusList()
        {
            menusListAnimator.SetBool("Enter", !menusToggled);
            menusToggled = !menusToggled;
            if(menusToggled)
            {
                AppManager.appInstance.CallOnMenuListShown();
            }
            else
            {
                AppManager.appInstance.CallOnMenuListHidden();
            }
        }

        public override void OnMenuSwitched(Menu newMenu)
        {
            base.OnMenuSwitched(newMenu);
            if(menusToggled) ToggleMenusList();
        }
    }
}
