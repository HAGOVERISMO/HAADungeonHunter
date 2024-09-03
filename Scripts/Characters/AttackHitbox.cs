using Godot;
using System;

public partial class AttackHitbox : Area3D, IHitBox
{
    public bool CanStun()
    {
        return false;
    }


    public float GetDamage()
    {
        return GetOwner<Character>().GetStatResource(Stat.Strngth)
            .StatValue;
    }
}
