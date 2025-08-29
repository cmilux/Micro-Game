using UnityEngine;

public class ScreenLimit : MonoBehaviour
{
    public float _xMinRange = -17f;
    public float _xMaxRange = 16f;

    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerSideScreenLimit();
    }

    public void PlayerSideScreenLimit()
    {
        if (player.transform.position.x < _xMinRange)
        {
            player.transform.position = new Vector2(_xMinRange, player.transform.position.y);
        }

        if (player.transform.position.x > _xMaxRange)
        {
            player.transform.position = new Vector2(_xMaxRange, player.transform.position.y);
        }
    }
}
