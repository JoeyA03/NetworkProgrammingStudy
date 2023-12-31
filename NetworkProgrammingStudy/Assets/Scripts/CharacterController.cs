using System.Collections;
using UnityEngine;
using Unity.Netcode;

public class CharacterController : NetworkBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (!IsOwner) return;

        Vector3 moveDir = Vector3.zero;

        if(Input.GetKey(KeyCode.W)) moveDir.z = +1f;
        if(Input.GetKey(KeyCode.S)) moveDir.z = -1f;
        if(Input.GetKey(KeyCode.A)) moveDir.x = -1f;
        if(Input.GetKey(KeyCode.D)) moveDir.x = +1f;

        float moveSpeed = 3f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;

    }
}



