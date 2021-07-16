using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    private Vector3 destination;
    public GameObject projectile;
    public float projectileSpeed = 12000.0f;
    public Camera cam;

    





    // Start is called before the first frame update
    void shootRay()
    {

        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, Mathf.Infinity));

        RaycastHit hit;

        if(Physics.Raycast(ray,out hit,1000))
        {
            destination = hit.point;
           
        }
        else
        {
            destination = ray.GetPoint(1000);
           
        }

        InstantiateProjectile();
        
    }


    void InstantiateProjectile()
    {
        var projectileObj = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject ;
       
        projectileObj.GetComponent<Rigidbody>().velocity = (destination - cam.transform.position ).normalized * projectileSpeed;
        Destroy(projectileObj, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Fire1"))
        {
            shootRay();
        }
        
    }
}
