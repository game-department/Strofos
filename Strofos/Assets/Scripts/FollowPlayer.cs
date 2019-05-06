using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraPos;

    void Start()
    {
        cameraPos = this.transform.position;
    }

    void Update()
    {
        cameraPos.x = player.transform.position.x;
        this.transform.position = cameraPos;
    }
}
