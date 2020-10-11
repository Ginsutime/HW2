using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class InspectorWindow : EditorWindow
{
    Color color;

    [MenuItem("Window/Colorizer")]
    public static void ShowWindow()
    {
        GetWindow<InspectorWindow>("Colorizer");
    }

    private void OnGUI()
    {
        GUILayout.Label("Color the selected objects!", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("COLORIZE!"))
        {
            Colorize();
        }

        GUILayout.Label("Activate renderer of selected objects!", EditorStyles.boldLabel);

        if (GUILayout.Button("ACTIVATE RENDERER!"))
        {
            ActivateRenderer();
        }

        GUILayout.Label("Disable renderer of selected objects!", EditorStyles.boldLabel);

        if (GUILayout.Button("DISABLE RENDERER!"))
        {
            DisableRenderer();
        }
    }

    void Colorize()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();

            if (renderer != null)
            {
                renderer.sharedMaterial.color = color;
            }
        }
    }

    void ActivateRenderer()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();

            if (renderer != null)
            {
                renderer.enabled = true;
            }
        }
    }

    void DisableRenderer()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();

            if (renderer != null)
            {
                renderer.enabled = false;
            }
        }
    }
}
