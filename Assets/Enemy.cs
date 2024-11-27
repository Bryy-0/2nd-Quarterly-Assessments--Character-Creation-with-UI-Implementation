using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string labelText2;
    public string Knight = "Companion Knight";
    public string Demon = "DEMON KING";

    [SerializeField] public int Health_Companion = 200;
    [SerializeField] public int Health_King = 500;

    [SerializeField] public int Companion_Attack = 20;
    [SerializeField] public int King_Attack = 50;

    void OnGUI()
    {
        GUI.Box(new Rect(1000, 100, 250, 250), labelText2);
        labelText2 = "" + Knight + "\n\rHealth: " + Health_Companion + "\n\r" + "\n\r" + Demon + "\n\rBOSS HEALTH: " + Health_King;
    }
}