using UnityEngine;

public class disco_lights : MonoBehaviour
{

    public Light disco_light;

    //Variables de la llum
    public float intensitat = 5f;
    Color[] disco_colors = new Color[5];
    public Color _color1, _color2, _color3, _color4, _color5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //This calls the method ChangeColor() every second
        InvokeRepeating("ChangeColor", 1, 1);

        _color1 = new Color(1.0f, 0.8f, 0.86f, 1.0f);
        _color2 = new Color(0.68f, 0.85f, 0.9f, 1.0f);
        _color3 = new Color(0.6f, 0.98f, 0.6f, 1.0f);
        _color4 = new Color(1.0f, 1.0f, 0.8f, 1.0f);
        _color5 = new Color(0.6f, 0.8f, 0.2f, 1.0f);

        disco_colors[0] = _color1;
        disco_colors[1] = _color2;
        disco_colors[2] = _color3;
        disco_colors[3] = _color4;
        disco_colors[4] = _color5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChangeColor()
    {
        int array_pos = Random.Range(0, 5);

        disco_light.color = disco_colors[array_pos];
    }
}
