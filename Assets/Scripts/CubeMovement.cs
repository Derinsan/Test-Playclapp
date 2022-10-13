using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.position += Vector3.right * InfoForCube._speed * Time.deltaTime;
    }

    void FixedUpdate()
    {
        if (gameObject.transform.position.x >= InfoForCube.distance)
        {
            Destroy(gameObject);
            Debug.Log("Destroy cube");
        }
    }
}
