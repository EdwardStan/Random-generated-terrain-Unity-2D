using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class TerrainCreator : MonoBehaviour
{
    [SerializeField] int scale = 1000;
    public SpriteShapeController shape;
    public int nrOfPoints = 150;
    
    void Start()
    {
        shape = GetComponent<SpriteShapeController>();
        float distanceBetweenPoints = scale / nrOfPoints;
        shape.spline.SetPosition(2, shape.spline.GetPosition(2) + Vector3.right * scale);
        shape.spline.SetPosition(3, shape.spline.GetPosition(2) + Vector3.right * scale);

        for (int i = 0; i < nrOfPoints; i++)
        {
            float xPos = shape.spline.GetPosition(i + 1).x + distanceBetweenPoints;

            shape.spline.InsertPointAt(i + 2, new Vector3(xPos, 10 * Mathf.PerlinNoise(i * Random.Range(5f, 15f), 0)));
        }

        for(int i = 2; i< 152; i++)
        {
            shape.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
            shape.spline.SetLeftTangent(i, new Vector3(-1, 0, 0));
            shape.spline.SetRightTangent(i, new Vector3(1, 0, 0));
        }
    }

    
    void Update()
    {
        
    }
}
