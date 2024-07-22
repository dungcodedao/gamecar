using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float speed = 25f;
    public float disLimit = 6f;
    public float ranPos = 0;

    private void Start()
    {
        this.player = PlayerCtrl.instance.transform;
        this.ranPos = Random.Range(-6, 6);
    }
    private  void FixedUpdate()
    {
        this.Follow();
    }
    private void Follow()
    {
        Vector3 pos = this.player.position;  
        pos.x = this.ranPos;
        Vector3 distance = pos - transform.position;


        if (distance.magnitude >= this.disLimit)
        {
            Vector3 targetPoint = pos - distance.normalized * this.disLimit;

           transform.position =  Vector3.MoveTowards(transform.position, targetPoint, this.speed * Time.fixedDeltaTime);
        }
    }
}
