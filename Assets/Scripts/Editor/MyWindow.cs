using UnityEditor;
using UnityEngine;

namespace RollAndBall
{
    public class MyWindow : EditorWindow
    {
        public static GameObject ObjectInstantiate;
        public string nameObject;
        public bool groupEnabled;
        public bool randomColor = true;
        public int countObject = 1;
        public float radius = 10.0f;

        private void OnGUI()
        {
            GUILayout.Label("Базовые настройки", EditorStyles.boldLabel);
            ObjectInstantiate = EditorGUILayout.ObjectField("Объект, который хотим вставить", 
                ObjectInstantiate, typeof(GameObject), true) as GameObject;
            nameObject = EditorGUILayout.TextField("Имя объекта", nameObject);
            groupEnabled = EditorGUILayout.BeginToggleGroup("Дополнительные настройки", groupEnabled);
            randomColor = EditorGUILayout.Toggle("Случайный цвет", randomColor);
            countObject = EditorGUILayout.IntSlider("Количество объектов", countObject, 1, 100);
            radius = EditorGUILayout.Slider("Радиус окружности", radius, 10, 50);
            EditorGUILayout.EndToggleGroup();
            var button = GUILayout.Button("Создать объекты");

            if (button)
            {
                if (ObjectInstantiate)
                {
                    GameObject root = new GameObject("Root");
                    for (int i = 0; i < countObject; i++)
                    {
                        float angle = i * Mathf.PI * 2 / countObject;
                        Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle) * radius);
                        GameObject temp = Instantiate(ObjectInstantiate, pos, Quaternion.identity);
                        temp.name = nameObject + "(" + i + ")";
                        temp.transform.parent = root.transform;
                        var tempRenderer = temp.GetComponent<Renderer>();

                        if (tempRenderer && randomColor)
                        {
                            tempRenderer.material.color = Random.ColorHSV();
                        }
                    }
                }
            }
        }

    }
}