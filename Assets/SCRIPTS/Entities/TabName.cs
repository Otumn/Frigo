using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Otumn.AppTemplate
{
    public class TabName : Entity
    {
        [SerializeField] private TextMeshProUGUI text;

        public override void OnMenuSwitched(Menu newMenu)
        {
            base.OnMenuSwitched(newMenu);
            text.text = newMenu.MenuName;
        }
    }
}
