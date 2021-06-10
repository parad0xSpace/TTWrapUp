using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SimpleFunction();
        int calcDamage = DamageCalc(18, 3);
    }

    void SimpleFunction()
    {
        Debug.Log("Hey thug, what's your name? I'm about to tentacle your [REDACTED]!");
    }

    public int DamageCalc(int damage, int armor)
    {
        Debug.Log("You deal- oof! OOF! How does " + (damage - armor) + " POINTS OF DAMAGE TASTE?");
        return damage - armor;
    }
}
