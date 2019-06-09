using UnityEngine;
using UnityEngine.UI;

public class Lifebar : MonoBehaviour
{
    [SerializeField]
    private Transform owner;

    [SerializeField]
    private Vector3 offset = Vector3.up;

    [SerializeField]
    private Image lifebar;

    [SerializeField]
    private Color[] colors;

    private void Update()
    {
        transform.position = owner.position + offset;
    }

    public void SetLife(float value)
    {
        var clamped = Mathf.Clamp(value, 0, 1);
        lifebar.fillAmount = clamped;
        
        
    }

    private void ChangeColor(float value)
    {
        if (value > 0.75)
        {
            lifebar.color = colors[0];
        }
        else if (value > 0.5)
        {
            lifebar.color = colors[1];
        }
        else if (value > 0.25)
        {
            lifebar.color = colors[2];
        }
        else
        {
            lifebar.color = colors[3];
        }
    }
}
