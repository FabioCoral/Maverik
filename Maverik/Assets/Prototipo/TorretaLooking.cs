using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaLooking : MonoBehaviour
{
    [SerializeField] private Transform airPlane;
    [SerializeField] private float airPlaneHeight = 50.0f;
    [SerializeField] private GameObject projectile;
    public Transform torreta, player;

    // Update is called once per frame
    void Update()
    {
        if (airPlane != null){
            torreta.transform.LookAt(player.position);
        }
        if(airPlane.position.y >= airPlaneHeight){
            ShootingAirPlane();
            Instantiate(projectile);
        }
        
        void ShootingAirPlane(){
            Debug.Log("Disparando no Avião");
        }
    }
}
