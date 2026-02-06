using UnityEngine;

public class CalledCollision : MonoBehaviour
{
    [SerializeField] private Material obstacleMaterial;
    [SerializeField] private Color matColor;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            MeshRenderer rend = collision.gameObject.GetComponent<MeshRenderer>();
            obstacleMaterial = rend.material;
            matColor = obstacleMaterial.color;

            obstacleMaterial.color = GetRandomColor();
        }
    }

    private Color GetRandomColor()
    {
        int rand = Random.Range(0, 5);

        if (rand == 0) return Color.white;
        if (rand == 1) return Color.black;
        if (rand == 2) return Color.red;
        if (rand == 3) return Color.yellow;
        return Color.blue;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            MeshRenderer rend = collision.gameObject.GetComponent<MeshRenderer>();
            rend.material.color = matColor;
        }
    }

}
