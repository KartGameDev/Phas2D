
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody2D body;

    private void Awake(){
        body = GetComponent<Rigidbody2D>();
    }    
}
