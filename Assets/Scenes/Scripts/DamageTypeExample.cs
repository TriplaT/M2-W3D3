using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    public enum DAMAGE_TYPE
    {
        SLASHING,
        PIERGING,
        BLUDGEONING,
        MAGICAL,
        FORCE
    }
    public DAMAGE_TYPE attackingType;
    public DAMAGE_TYPE resistance;
    public DAMAGE_TYPE weakness;
    public int baseDamage;
    // Start is called before the first frame update
    void Start()
    {
        int finalDamage = baseDamage;

        if (attackingType == resistance)
        {
            Debug.Log("Enemy is resistant to this attack type.");
            finalDamage = Mathf.Max(0, baseDamage / 2);
            Debug.Log("New baseDamage: " + finalDamage);
        }
        else if (attackingType == weakness)
        {
            finalDamage = baseDamage * 2;
            Debug.Log("Enemy is weak to this attack type.");
            Debug.Log("New baseDamage: " + finalDamage);
        }

        Debug.Log("Final baseDamage: " + finalDamage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
