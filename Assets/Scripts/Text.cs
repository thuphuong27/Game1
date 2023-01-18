using static UnityEditor.SceneView;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Text : MonoBehaviour
{

    public GUISkin skin;
    bool title = true;
    float size = 10;
    bool closedCapOne = false;
    bool closedCapTwo = false;
    bool closedCapThree = false;
    bool closedCapFour = false;
    bool closedCapFive = false;

    void Start()
    {
        StartCoroutine(Open());
    }

    void Update()
    {
        while (title)
        {
            size += 4 * Time.deltaTime; // Smooth time?
        }
    }

    public IEnumerator Open()
    {
    
       // CameraFade.FadeOutMain(0.1f);
        yield return new WaitForSeconds(5);
        title = false;
    }

    void OnGUI()
    {
        GUI.skin = skin;
        skin.label.fontSize = Mathf.RoundToInt(size);

        if (title)
        {
            GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
            GUILayout.Label("Game Title");
            GUILayout.EndArea();
        }
    }
}