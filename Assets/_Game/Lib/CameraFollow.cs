using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform TF;
    public Player player;
    public Vector3 offset;
    public float lerpRate;

    void Awake()
    {
        player = FindObjectOfType<Player>();
        TF= gameObject.transform;
    }

    void FixedUpdate()
    {
        if(player!= null)
        {
            Follow();
        }

    }

    void Follow()
    {
        Vector3 pos = TF.position;
        Vector3 targetPos = player.TF.position + offset;
        pos = Vector3.Lerp(pos, targetPos, lerpRate*Time.fixedDeltaTime);
        TF.position = pos;
    }
    
    public void FollowEndGame(Vector3 position)
    {
        Vector3 pos = TF.position;
        Vector3 targetPos = position + offset;
        TF.position = targetPos;
    }
}
