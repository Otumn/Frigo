using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Otumn.AppTemplate
{
    public class AppManager : MonoBehaviour
    {
        #region Static Objects
        public static AppInstance appInstance = new AppInstance();
        public static MenusManager menusManager;
        public static ColorLibrary colorLibrary;
        #endregion

        [SerializeField] private MenusManager menusManagerObject;
        [SerializeField] private ColorLibrary colorLibraryObject;

        private void Start()
        {
            //INITIALIZE ALL MANAGERS HERE
            menusManager = menusManagerObject;
            colorLibrary = colorLibraryObject;

            appInstance.CallOnManagersInitialized();
        }
    }

    public class AppInstance
    {
        private List<Entity> entities = new List<Entity>();

        #region Entity Management

        public void AddEntity(Entity entity)
        {
            entities.Add(entity);
        }

        public void RemoveEntity(Entity entity)
        {
            entities.Remove(entity);
        }

        #endregion

        #region Entity Calls

        public void CallOnManagersInitialized()
        {
            for (int i = 0; i < entities.Count; i++)
            {
                entities[i].OnManagersInitialized();
            }
        }

        public void CallOnMenuSwitched(Menu newMenu)
        {
            for (int i = 0; i < entities.Count; i++)
            {
                entities[i].OnMenuSwitched(newMenu);
            }
        }

        public void CallOnMenuListShown()
        {
            for (int i = 0; i < entities.Count; i++)
            {
                entities[i].OnMenuListShown();
            }
        }

        public void CallOnMenuListHidden()
        {
            for (int i = 0; i < entities.Count; i++)
            {
                entities[i].OnMenuListHidden();
            }
        }
        
        #endregion
    }
}
