using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaLooking : MonoBehaviour
{
    public Transform torreta, player;

    // Update is called once per frame
    void Update()
    {
        torreta.transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));
    }
}
