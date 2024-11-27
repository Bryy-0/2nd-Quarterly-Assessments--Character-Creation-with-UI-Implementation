using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public string labeltext;

    [SerializeField] public int Health1 = 300;
    [SerializeField] public int Health2 = 280;
    [SerializeField] public int Health3 = 250;

    [SerializeField] public int Attack1 = 45;
    [SerializeField] public int Attack2 = 30;
    [SerializeField] public int Attack3 = 30;

    [SerializeField] int Defense1 = 100;
    [SerializeField] int Defense2 = 50;
    [SerializeField] int Defense3 = 30;

    [SerializeField] public int Health_Companion = 200;
    [SerializeField] public int Health_King = 500;

    [SerializeField] public int Companion_Attack = 20;
    [SerializeField] public int King_Attack = 50;

    void OnGUI()
    {
        if (GUI.Button(new Rect(5, 5, 100, 50), "Swordsman"))
        {
            labeltext = "Swordsman stats\n\rHealth: " + Health1 + "\n\rAttack Damage: " + Attack1 + "\n\rDefense: " + Defense1;
        }
        if (GUI.Button(new Rect(5, 65, 100, 50), "Archer"))
        {
            labeltext = "Archer stats\n\rHealth: " + Health2 + "\n\rAttack Damage: " + Attack2 + "\n\rDefense: " + Defense2;
        }
        if (GUI.Button(new Rect(5, 125, 100, 50), "Mage"))
        {
            labeltext = "Mage stats\n\rHealth: " + Health3 + "\n\rAttack Damage: " + Attack3 + "\n\rDefense: " + Defense3;
        }
        
        GUI.Box(new Rect(200, 100, 250, 250), labeltext);

        
        }
    void Start()
    {
        Health1 = Health1 - King_Attack;
        Debug.Log("Current hp is " + Health1);
        if (GUI.Button(new Rect(5, 185, 100, 50), "Attack"))
        {
            GUI.Box(new Rect(200, 100, 250, 250), labeltext);
        }
    }
}