using UnityEngine;

public class addLight : MonoBehaviour
{


    public Light luz;

    // Variables públicas para controlar la luz
    public float intensidad = 5f;
    public float intensidadFinal = 0f;
    public float delay = 10f;
    public float temporitzador;

    public Color colorLuz = Color.red;
    public LightType tipoLuz = LightType.Point;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        luz = GetComponent<Light>();

        // Verificar si el componente Light existe
        if (luz != null)
        {
            // Inicializamos las características de la luz al principio
            luz.intensity = intensidad;
            luz.color = colorLuz;
            luz.type = tipoLuz;
        }
        else
        {
            Debug.LogError("No se encontró el componente Light en este objeto.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        temporitzador += Time.deltaTime;

        // Fer la disminució despres dels primers 10 segons
        if(temporitzador >= delay)
        {
            luz.intensity = intensidadFinal;
            
            // Desactivar el script després de executar aquesta linea
            enabled = false;
        }
    }
}
