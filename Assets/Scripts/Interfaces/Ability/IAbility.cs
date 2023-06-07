using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAbility
{
    public void Fire();
    public int GetCost();
    public float GetCooldown();
    public void SetCooldown(float cooldown);

    


}
