using UnityEngine;



[RequireComponent(typeof(Rigidbody))]   // adds rigidbody if none exists in object



public class MoveObject : MonoBehaviour

{

    private GameObject gameObject;

    private Rigidbody rigidbody;

    public float m_Speed = 2f;

    public float distance = 0.5f;



    // Start is called before the first frame update

    void Start()

    {

        rigidbody = GetComponent<Rigidbody>();

        gameObject = GameObject.Find("Chair");

    }



    private void Update()

    {

        if (Input.GetKeyDown(KeyCode.P))

        {

            Move(distance);

        }

    }

    public void Move(float distance)

    {

        Vector3 moveIt = transform.position;

        Debug.Log(moveIt);

        moveIt.Normalize();





        rigidbody.MovePosition(transform.position + moveIt * distance * m_Speed);

    }

}
