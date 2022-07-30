using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorRotation : MonoBehaviour
{
    [SerializeField] private Vector2 PitchRange;
    [SerializeField] private float PitchAmount;
    private float pitch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pitch += Input.GetAxis("Mouse Y") * Time.deltaTime * PitchAmount;
        pitch = Mathf.Clamp(pitch, PitchRange.x, PitchRange.y);
        transform.localRotation = Quaternion.Euler( pitch,0,0);

    }
}
