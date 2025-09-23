using UnityEngine;

public class addLight : MonoBehaviour
{


    public Light luz;

    // Variables p�blicas para controlar la luz
    public float intensidad = 2f;
    public Color colorLuz = Color.red;
    public LightType tipoLuz = LightType.Point;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        luz = GetComponent<Light>();

        // Verificar si el componente Light existe
        if (luz != null)
        {
            // Inicializamos las caracter�sticas de la luz al principio
            luz.intensity = intensidad;
            luz.color = colorLuz;
            luz.type = tipoLuz;
        }
        else
        {
            Debug.LogError("No se encontr� el componente Light en este objeto.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
