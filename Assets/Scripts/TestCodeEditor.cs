using UnityEditor;
using UnityEngine;

namespace RollAndBall
{
    [CustomEditor(typeof(TestCode))]
    public class TestCodeEditor : UnityEditor.Editor
    {
        private bool _isPressButtonOk;

        public override void OnInspectorGUI()
        {
            TestCode testTarget = (TestCode)target;

            testTarget.count = EditorGUILayout.IntSlider(testTarget.count, 10, 50);
            testTarget.offset = EditorGUILayout.IntSlider(testTarget.offset, 1, 5);

            testTarget.obj = EditorGUILayout.ObjectField("Объект, который хотим вставить", 
                testTarget.obj, typeof(GameObject), false) as GameObject;

            var isPressButtonOk = GUILayout.Button("Создание объектов по кнопке", EditorStyles.miniButtonLeft);
            isPressButtonOk = GUILayout.Toggle(_isPressButtonOk, "Ok");

            if (isPressButtonOk)
            {
                testTarget.CreateObj();
                _isPressButtonOk = true;
            }

            if (_isPressButtonOk)
            {
                testTarget.test = EditorGUILayout.Slider(testTarget.test, 10, 50);
                EditorGUILayout.HelpBox("Вы нажали на кнопку", MessageType.Warning);

                var isPressAddButton = GUILayout.Button("Add Component", EditorStyles.miniButtonLeft);
                var isPressRemoveButton = GUILayout.Button("Remove Component", EditorStyles.miniButtonLeft);

                if (isPressAddButton)
                {
                    testTarget.AddComponent();
                }

                if (isPressRemoveButton)
                {
                    testTarget.RemoveComponent();
                }
            }
        }

    }
}