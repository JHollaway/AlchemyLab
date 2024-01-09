using UnityEngine;



public class LightSwitch : MonoBehaviour

{

    private GameObject unlitObject;

    private GameObject litObject;

    private bool isLit = true;

    private void Start()

    {

        // Get the Light component attached to the same GameObject

        unlitObject = transform.Find("TorchUnlit").gameObject;

        litObject = transform.Find("TorchLit").gameObject;



        /* Ensure the Light component is not null

        if (myLight == null)

        {

            Debug.LogError("Light component not found on the GameObject.");

        }

        */

    }



    private void Update()

    {

        // Check for mouse click

        if (Input.GetKeyDown(KeyCode.L))

        {

            // Cast a ray from the camera to the mouse position

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            // Check if the ray hits the object with a Collider

            if (Physics.Raycast(ray, out hit))

            {

                // Check if the hit object is the one you want to interact with

                if (hit.collider.gameObject == gameObject)

                {

                    // Toggle the light state

                    isLit = !isLit;

                    SetObjectsState();

                }

            }

        }

    }



    void SetObjectsState()

    {

        // Set the active state of objects based on whether it is lit or unlit

        unlitObject.SetActive(!isLit);

        litObject.SetActive(isLit);

    }

}
