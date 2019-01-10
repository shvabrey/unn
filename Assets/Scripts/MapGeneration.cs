using UnityEngine;

public class MapGeneration : MonoBehaviour
{

    public Transform tree;
    public Transform rock;
    public int treecount;
    public int rockcount;
    private Vector2 mapSize = new Vector2(50, 50);
    private float scale;
    void Start()
    {
        generate();
    }

    void generate()
    {
        for (int i = 0; i < treecount; i++)
        {
            scale = Random.Range(2, 4);
            tree.localScale = new Vector2(scale, scale);
            Instantiate(tree, new Vector2(Random.Range(0, mapSize.x), Random.Range(0, mapSize.y)), tree.rotation);
        }
        for (int i = 0; i < rockcount; i++)
        {
            scale = Random.Range(2, 4);
            rock.localScale = new Vector2(scale, scale);
            Instantiate(rock, new Vector2(Random.Range(0, mapSize.x), Random.Range(0, mapSize.y)), rock.rotation);
        }
    }

    void Update()
    {

    }
}
