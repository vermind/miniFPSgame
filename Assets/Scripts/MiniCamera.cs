
using UnityEngine;

[AddComponentMenu("Game/minicamera")]
public class MiniCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float ratio = (float)Screen.width / (float)Screen.height;

        this.GetComponent<Camera>().rect = new Rect((1 - 0.2f), (1 - 0.2f * ratio), 0.2f, 0.2f * ratio);
    }

    
}
