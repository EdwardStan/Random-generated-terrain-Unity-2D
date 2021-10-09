using UnityEngine;

public class camera : MonoBehaviour
{

    [SerializeField] Transform target;

    /*[SerializeField]  float smoothSpeed = 0.125f;*/
    [SerializeField] Vector3 offset;

    private void LateUpdate()
    {
        /*Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;*/



        transform.position = target.position + offset;
    }





}
