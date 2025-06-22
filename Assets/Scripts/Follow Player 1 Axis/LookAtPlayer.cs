using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform Text;
    public Transform Player;

    void Update()
    {
        Text.transform.LookAt(new Vector3(Player.position.x, transform.position.y, Player.position.z));
    }
}
