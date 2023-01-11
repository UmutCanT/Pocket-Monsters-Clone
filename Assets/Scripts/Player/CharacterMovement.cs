using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(InputController))]
public class CharacterMovement : MonoBehaviour
{
    private InputController inputController;

    [SerializeField] float movementSpeed = 5f;
    private bool isMoving;

    private void Awake()
    {
        inputController = GetComponent<InputController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving && inputController.PlayerInput != Vector2.zero)
        {
            var targetPosition = transform.position;
            targetPosition.x += inputController.PlayerInput.x;
            targetPosition.y += inputController.PlayerInput.y;

            StartCoroutine(Move(targetPosition));
        }


    }

    IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;

        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, movementSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;

        isMoving = false;
    }
}
