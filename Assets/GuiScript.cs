using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {  
        Rect rect = new Rect(10, 10, 200, 250);
        GUI.Box(rect, "Menu");
        GUI.Label(new Rect(20, 30, 250, 20), "Mouvements : Fleches");  
        GUI.Label(new Rect(20, 50, 250, 20), "W : Lever le mat");
        GUI.Label(new Rect(20, 70, 250, 20), "X : Descendre le mat");
        GUI.Label(new Rect(20, 90, 250, 20), "S : Etendre le mat");
        GUI.Label(new Rect(20, 110, 250, 20), "Z : Retracter le mat");
        GUI.Label(new Rect(20, 130, 250, 20), "Y : Detacher objet crochet");
        GUI.Label(new Rect(20, 150, 250, 20), "U/I : Tourner le mat");
        GUI.Label(new Rect(20, 170, 250, 20), "L/M : Tourner les pates 1");
        GUI.Label(new Rect(20, 190, 250, 20), "O/P : Tourner les pates 2");
        GUI.Label(new Rect(20, 210, 250, 20), "Shift : Sprinter");
        GUI.Label(new Rect(20, 230, 250, 20), "C : Changer de caméra");
    }

}
