using UnityEngine;

namespace HalfBlind.Attributes
{
    public class StringButtonAttribute : PropertyAttribute
    {
        public string ActionName;

        public StringButtonAttribute(string actionName)
        {
            ActionName = actionName;
        }
    }
}
