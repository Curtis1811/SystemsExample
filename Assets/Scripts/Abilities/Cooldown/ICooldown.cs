using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICooldown
{

    // This are our defined methods for the cooldown system
    float GetCooldown();
    void SetCooldown(float cooldown);
    void StartCooldown();
    void StopCooldown();
    bool IsOnCooldown();
    void UpdateCooldown();
    void ResetCooldown();
}
