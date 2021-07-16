using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketShip : MonoBehaviour
{
    float speed = 20f;
    float acceleration = 0.5f;

    public float rollSpeed;
    public float pitchSpeed;
    float roll;
    float pitch;
    float yaw; /// unused
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
       
        



    }

   

    // Update is called once per frame
    void Update()
    {
        Vector3 moveCamTo = transform.position - transform.forward * 30.0f + Vector3.up * 5.0f;
        float bias = 0.96f;
        Camera.main.transform.position = Camera.main.transform.position * bias + moveCamTo *(1.0f-bias);
      
        Camera.main.transform.LookAt(transform.position + transform.forward * 40.0f) ;

     
        
        
        
        roll = Input.GetAxis("Horizontal");
        pitch = Input.GetAxis("Vertical");
        
        transform.Rotate(pitch*pitchSpeed,0.0f,-roll*rollSpeed);


        
            transform.position += transform.forward * speed * Time.deltaTime;
        

    }
}
