using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float m_timer = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, m_timer);
    }

    
}
