using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllers : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform cam;
    public PlayerMovement pm;

    void Update() {

        if(!pm.Dead){
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }else{
            transform.position = new Vector3(cam.position.x, cam.position.y, transform.position.z);
        }
    }
}
