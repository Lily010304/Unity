using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UI;

public class RigidBodyCharacterController : MonoBehaviour
{
    Rigidbody Player;
    Vector3 Controllers;
    bool IsJump = false;
    float RunSpeed = 3f;
    void Start()
    {
        Player = GetComponent<Rigidbody>();
        Player.freezeRotation = true;
    }
    void Update()
    {
        Controllers = new Vector3(Input.GetAxisRaw("Vertical"),0, Input.GetAxisRaw("Horizontal"));
        Controllers = Controllers.normalized * RunSpeed;
        Controllers.y = Player.linearVelocity.y;
        if (Input.GetKey(KeyCode.Space))
        {
            IsJump = true;
        }
    }
    void FixedUpdate()
    {
        Player.linearVelocity = Controllers;
        
        if (IsJump)
        {
            Player.linearDamping = 0.7f;
            Player.AddForce(Vector3.up * 0.4f, ForceMode.Impulse);
            IsJump = false;
        }
        else
        {
            Player.linearDamping = 0f;
        }
    }
}
