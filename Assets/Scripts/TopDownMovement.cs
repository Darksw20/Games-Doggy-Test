using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        animator.SetFloat("Vertical", 0.0f, Input.GetAxis("Vertical"), 0.0f);


        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;

        Vector3 vertical = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
        transform.position = transform.position + vertical * Time.deltaTime;

    }
}
