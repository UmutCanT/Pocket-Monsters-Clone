using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(ICanMove))]
public class CharacterMovement : MonoBehaviour
{
    private ICanMove movementController;
    private IAnimated characterAnimations;
    [SerializeField] TilePaths tilePaths;

    [SerializeField] float movementSpeed = 5f;
    private bool isMoving;
    Vector3 targetPosition;
    readonly Vector3 characterOffset = new Vector3(0,0.5f,0);

    private void Awake()
    {
        movementController = GetComponent<ICanMove>();
        characterAnimations = GetComponent<IAnimated>();
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isMoving && movementController.MovementInput != Vector2.zero)
        {
            characterAnimations.SetDirectionForCharacter(movementController.MovementInput.x, movementController.MovementInput.y);
            
            targetPosition = transform.position;
            targetPosition.x += movementController.MovementInput.x;
            targetPosition.y += movementController.MovementInput.y;

            if(tilePaths.SolidPathTileChecker(targetPosition-characterOffset))
                StartCoroutine(Move(targetPosition));
        }        
        characterAnimations.SetCharacterMovement(isMoving);
    }

    IEnumerator Move(Vector3 targetPos)
    {       
        isMoving = true;
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, movementSpeed * Time.fixedDeltaTime);          
            yield return null;
        }
        transform.position = targetPos;
        isMoving = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(targetPosition - characterOffset, 0.2f);
    }
}
