using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
[RequireComponent(typeof(Renderer))]
public class ObjectOrderOnY : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }
    private const int IsometricRangePerYUnit = -100;
    private const int IsometricRangePerXUnit = 100;
    //private const int IsometricRangePerXUnit = 100;
    [SerializeField]
    public Transform Target;
    public Transform Target2;
    public int TargetOffset = 0;

    void Update()
    {
        
        bool positive = Target.position.x > 0;
        bool negative = Target.position.x < 0;

        if (Target == null)
            Target = transform;
        Renderer renderer = GetComponent<Renderer>();
        if (Target.position.x > Target2.position.x && Target.position.y > Target2.position.y)
        {
            renderer.sortingOrder = 10;
        }
        else if (Target.position.x > Target2.position.x && Target.position.y < Target2.position.y)
        {
            renderer.sortingOrder = 0; 
        }
        else if (Target.position.x == Target2.position.x && Target.position.y > Target2.position.y)
        {
            renderer.sortingOrder = 10;
        }
        else if (Target.position.x > Target2.position.x && Target.position.y == Target2.position.y)
        {
            renderer.sortingOrder = 10;
        }
        else if (Target.position.x == Target2.position.x && Target.position.y < Target2.position.y)
        {
            renderer.sortingOrder = 0;
        }
        else if (Target.position.x < Target2.position.x && Target.position.y == Target2.position.y)
        {
            renderer.sortingOrder = 0;
        }
        else if (Target.position.x < Target2.position.x && Target.position.y < Target2.position.y)
        {
            renderer.sortingOrder = 0; 
        }
        else if (Target.position.x < Target2.position.x && Target.position.y > Target2.position.y)
        {
            renderer.sortingOrder = 10; 
            //kept for reference
            //-(int)(Target.position.x * IsometricRangePerXUnit) + -(int)(Target.position.y * IsometricRangePerYUnit) + TargetOffset;
        }
        }
    
}
