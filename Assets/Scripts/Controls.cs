using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    public GameObject verticalBeam;
    public GameObject horizontalPlatform;

    bool reset = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reset)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            var mouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
            var world = Camera.main.ScreenToWorldPoint(mouse);

            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(verticalBeam, world, Quaternion.identity);
            }
            else if (Input.GetMouseButtonDown(1))
            {
                Instantiate(horizontalPlatform, world, Quaternion.identity);
            }
        }
    }
    private void OnMouseDown()
    {
        reset = true;
    }
}
