using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyBehavior
{
    public void Attack();
    public void Move();
    public void Die();
    public void TakeDamage();

}
