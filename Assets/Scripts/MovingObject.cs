using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] float distanceToCover;
    [SerializeField] float speed;

    private Vector3 _startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        _startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = _startingPosition;
        v.z += distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = v;

    }
}
