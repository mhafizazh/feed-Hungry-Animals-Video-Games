using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float rightBoundry = 15.0f;
    public float leftBoundry = -15.0f;

    public GameObject projectilePreafab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftBoundry)
        {
            transform.position = new Vector3(leftBoundry, transform.position.y, transform.position.z);
            
        } else if (transform.position.x > rightBoundry)
        {
            transform.position = new Vector3(rightBoundry, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePreafab, transform.position, projectilePreafab.transform.rotation);
        }
    }
}
