using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(ICanMove))]
public class CharacterMovement : MonoBehaviour
{
    private ICanMove movementController;
    private IAnimated characterAnimations;

    [SerializeField] float movementSpeed = 5f;
    private bool isMoving;

    private void Awake()
    {
        movementController = GetComponent<ICanMove>();
        characterAnimations = GetComponent<IAnimated>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving && movementController.MovementInput != Vector2.zero)
        {
            characterAnimations.SetDirectionForCharacter(movementController.MovementInput.x, movementController.MovementInput.y);

            var targetPosition = transform.position;
            targetPosition.x += movementController.MovementInput.x;
            targetPosition.y += movementController.MovementInput.y;

            StartCoroutine(Move(targetPosition));
        }

        characterAnimations.SetCharacterMovement(isMoving);
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
