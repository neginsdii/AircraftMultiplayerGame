using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftController : MonoBehaviour
{
    [SerializeField] private float MovementSpeed;
    [SerializeField] private float MaxMovementSpeed;
    [SerializeField] private float YawAmount;
    [SerializeField] private float RollAmount;
    [SerializeField] private float PitchAmount;
    [SerializeField] private Vector2 YawRange;
    [SerializeField] private Vector2 RollRange;
    [SerializeField] private Vector2 PitchRange;

    private float roll=0;
    private float pitch=0;
    private float Yaw=0;

    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {

     
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (MovementSpeed <= MaxMovementSpeed)
            MovementSpeed += Time.deltaTime * Input.GetAxisRaw("Vertical");
        else
            MovementSpeed = MaxMovementSpeed;
        if (MovementSpeed <= 0)
            MovementSpeed = 0;
        transform.position += transform.forward * MovementSpeed * Time.deltaTime;

        Yaw += Input.GetAxis("Horizontal") * YawAmount*Time.deltaTime;
       // Yaw = Mathf.Clamp(Yaw, YawRange.x, YawRange.y);
       
        pitch += Input.GetAxis("Mouse Y")* -Time.deltaTime*PitchAmount;
        pitch = Mathf.Clamp(pitch, PitchRange.x, PitchRange.y);
        float horizontalInput = Input.GetAxis("Horizontal");

        roll = Mathf.LerpAngle( RollRange.x, RollRange.y,Mathf.Abs( horizontalInput * 0.5f))*-Mathf.Sign(horizontalInput);
        transform.rotation = Quaternion.Euler(Vector3.up * Yaw+ Vector3.forward*roll + Vector3.right*pitch);

    }

	private void FixedUpdate()
	{
       // MoveForward();
	}

	public void MoveForward()
	{

    }
}
