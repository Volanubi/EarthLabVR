
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    [SerializeField] float distanceToCover;
    [SerializeField] float speeds;

    private Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move(speeds);
    }

    public void Move(float speed)
    {
        speeds = speed;
        Vector3 v = startingPosition;
        v.z += distanceToCover * Mathf.Sin(Time.time * speeds);
        transform.position = v;
    }
}
