using UnityEditor;

namespace RollAndBall
{
    public class MenuItems
    {
        [MenuItem("RollAndBall/Пункт меню №0 ")]

        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "RollAndBall");
        }
    }
}
