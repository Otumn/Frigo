using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Otumn.AppTemplate
{
    [CreateAssetMenu(fileName = "ColorLibrary", menuName = "Frigo SO/ColorLibrary", order = 1)]
    public class ColorLibrary : ScriptableObject
    {
        public Color ButtonEnabled = Color.white;
        public Color ButtonDisabled = Color.gray;
    }
}
