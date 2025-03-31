using UnityEngine;

public class CloudScript : MonoBehaviour
{
    [SerializeField] private float speed;
    private float endPosX;

    public void StartFloating(float _speed, float _endPosX)
    {
        speed = _speed;
        endPosX = _endPosX;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * (Time.deltaTime * speed));
        if (transform.position.x > endPosX)
        {
            Destroy(gameObject);
        }
    }
}
