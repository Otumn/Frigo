using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Otumn.AppTemplate
{
    public class Entity : MonoBehaviour
    {
        #region monobehaviour events

        protected virtual void Start()
        {

        }

        protected virtual void Update()
        {

        }

        protected virtual void OnEnable()
        {
            AppManager.appInstance.AddEntity(this);
        }

        protected virtual void OnDisable()
        {
            AppManager.appInstance.RemoveEntity(this);
        }

        #endregion

        #region Entity events

        public virtual void OnManagersInitialized()
        {

        }

        public virtual void OnMenuSwitched(Menu newMenu)
        {

        }

        public virtual void OnMenuListShown()
        {

        }

        public virtual void OnMenuListHidden()
        {

        }

        #endregion
    }
}
