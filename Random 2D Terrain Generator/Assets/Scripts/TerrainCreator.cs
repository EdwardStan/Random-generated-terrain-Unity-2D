using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class TerrainCreator : MonoBehaviour
{
    [SerializeField] int scale;
    [SerializeField] public SpriteShapeController shape;
    [SerializeField] public int nrOfPoints;
    [SerializeField] InputField Lenght;
    [SerializeField] InputField Points;

    public GameObject Button;
    public GameObject InputS;
    public GameObject InputP;
    public GameObject Rack;

    public void GenerateTerrain()
    {
        scale = int.Parse(Lenght.text);
        nrOfPoints = int.Parse(Points.text);

        shape = GetComponent<SpriteShapeController>();
        float distanceBetweenPoints = scale / nrOfPoints;
        shape.spline.SetPosition(2, shape.spline.GetPosition(2) + Vector3.right * scale);
        shape.spline.SetPosition(3, shape.spline.GetPosition(2) + Vector3.right * scale);

        for (int i = 0; i < nrOfPoints; i++)
        {
            float xPos = shape.spline.GetPosition(i + 1).x + distanceBetweenPoints;

            shape.spline.InsertPointAt(i + 2, new Vector3(xPos, 10 * Mathf.PerlinNoise(i * Random.Range(5f, 15f), 0)));
        }

        for (int i = 2; i < 152; i++)
        {
            shape.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
            shape.spline.SetLeftTangent(i, new Vector3(-1, 0, 0));
            shape.spline.SetRightTangent(i, new Vector3(1, 0, 0));
        }

        Button.SetActive(false);
        InputS.SetActive(false);
        InputP.SetActive(false);
        Rack.SetActive(false);
    }
}
