
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float zoom;
    public Transform Pos;


    //public float speed;
    void Start()
    {
        transform.rotation = Quaternion.identity;
    }
    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        if (movement>0)
        {
            transform.Rotate(0, -20 * Time.deltaTime,0);
        }
        else if (movement<0)
        {
            transform.Rotate(0, 20 * Time.deltaTime,0);
        }

        // key input
       /* if (Input.GetKey("w") )
        {
            Pos.position -= new Vector3(0.05f, 0, 0);
        }
        if (Input.GetKey("s") )
        {
            Pos.position += new Vector3(0.05f, 0, 0);
        }*/





        // else if (Input.GetKey("a") && transform.rotation.y < 0.36)
        // {
        //     transform.Rotate(0, 20 * Time.deltaTime,0);
           
        // }
        //&& transform.rotation.y > -0.45
        
    }
}
