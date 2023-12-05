using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 2f;
    [SerializeField] private Vector3 offset;
    private Camera cam;
    bool hasEndedMovement, hasdEndedRotation = false;
    public bool hasEndedJob => hasdEndedRotation && hasEndedMovement;
    private void Start() 
    {
        cam = Camera.main;
    }
    public void StartTransition(Transform x)
    {
        target = x;
        StartCoroutine(MoveToTargetCoroutine());
        StartCoroutine(RotateToTargetCoroutine());
    }
    float MoveToTarget()
    {
        Vector3 currentTarget = target.position - offset;
        cam.transform.position = Vector3.Lerp(cam.transform.position, currentTarget, speed * Time.deltaTime);

        return Vector3.Distance(cam.transform.position, currentTarget);
    }
    float RotateToTarget()
    {
        var targetRotation = Quaternion.LookRotation(target.position - cam.transform.position);
        cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, targetRotation, speed * Time.deltaTime);
        float angle  = 180 - Vector3.Angle(target.forward, cam.transform.forward);
        return angle;
    }
    IEnumerator RotateToTargetCoroutine()
    {
        yield return new WaitUntil( () => RotateToTarget() <= 5f );
        hasdEndedRotation = true;
    }
    IEnumerator MoveToTargetCoroutine()
    {
        yield return new WaitUntil( () => MoveToTarget() <= .5f);
        hasEndedMovement = true;

    }
}