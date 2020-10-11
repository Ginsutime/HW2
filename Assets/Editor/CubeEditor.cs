using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Cube cube = (Cube)target;

        GUILayout.Label("Oscillates around a base size");
        cube.baseSize = EditorGUILayout.Slider("Size", cube.baseSize, .1f, 2f);

        GUILayout.BeginHorizontal();

            if (GUILayout.Button("Generate Color"))
            {
                cube.GenerateColor();
            }

            if (GUILayout.Button("Reset"))
            {
                cube.Reset();
            }

        GUILayout.EndHorizontal();
    }
}
